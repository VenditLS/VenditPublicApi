using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Base
{
    public class VenditPublicClientBase
    {
        private static HttpClient _client;

        private static VenditPublicClientSettings _settings;

        private static ProductInfoHeaderValue _productInfo;

        private readonly SemaphoreSlim _applyChangesLock = new SemaphoreSlim(1, 1);

        protected readonly ILogger Logger;

        public VenditPublicClientSettings Settings
        {
            get { return _settings; }
        }

        /// <summary>
        /// This should be used when multiple applications are sharing an API key and the other application renewed the Token
        /// <para>
        /// Can also be used after settings were edited by a user during configuration.
        /// </para>
        /// </summary>
        public async Task SetSettings(VenditPublicClientSettings settings, CancellationToken cancel)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            try
            {
                await _applyChangesLock.WaitAsync(cancel).ConfigureAwait(false);
                if (!_settings.Equals(settings))
                {
                    // HttpClient oldClient = _client;
                    _client = null;
                    _productInfo = null;
                    // oldClient.Dispose(); // rather leak a socket than trip up other threads, should eventually be disposed by the Garbage Collector any way
                }

                _settings = settings;
            }
            finally
            {
                _applyChangesLock.Release();
            }
        }

        /// <summary>
        /// Will be called when a token expires and a new token has been fetched.
        /// <para>
        /// The settings should be persisted to a file or database. When creating a new VenditPublicClient they should be retrieved and provided to the constructor.
        /// </para>
        /// <remarks>
        /// This will most probably be running in a ThreadPool context.
        /// </remarks>
        /// </summary>
        public Func<VenditPublicClientSettings, CancellationToken, Task> PersistSettings { get; set; }

        /// <summary>
        /// Recommended constructor
        /// </summary>
        public VenditPublicClientBase(VenditPublicClientSettings settings, ILogger logger = null)
        {
            _settings = settings;
            Logger = logger;
        }

        /// <summary>
        /// For users who persist the token in private database
        /// </summary>
        public VenditPublicClientBase(string apiKey, string token, DateTime tokenExpire, ILogger logger = null)
        {
            _settings = new VenditPublicClientSettings
            {
                ApiKey = apiKey,
                Token = token,
                TokenExpire = tokenExpire.Ticks
            };
            Logger = logger;
        }

        /// <summary>
        /// For convenience, your requests will be faster if you preserve the token.
        /// <para>
        /// The token and its expiration will be available in the Settings property after the first request.
        /// We recommend persisting the whole VenditPublicClientSettings object and using the constructor that accepts it.
        /// </para>
        /// </summary>
        public VenditPublicClientBase(string apiKey, string userName, string password, ILogger logger = null)
        {
            _settings = new VenditPublicClientSettings
            {
                ApiKey = apiKey,
                Username = userName,
                Password = password
            };
            Logger = logger;
        }

        /// <summary>
        /// Returns an authenticated client having the required ApiKey and Token headers (may involve refreshing the token in the process)
        /// </summary>
        public async Task<HttpClient> GetClient(CancellationToken cancel)
        {
            if (_client is null || CheckTokenExpire())
            {
                try
                {
                    await _applyChangesLock.WaitAsync(cancel);

                    if (_client is null || CheckTokenExpire()) // bail out if previous thread already completed this task (thread my have been waiting on the lock in a queue)
                    {
                        if (string.IsNullOrWhiteSpace(_settings.BaseAddress))
                            _settings.BaseAddress = "https://api2.vendit.online/VenditPublicApi"; // set to default production

                        HttpClient client = new HttpClient()
                        {
                            BaseAddress = new Uri(_settings.BaseAddress),
                        };

                        SetUserAgent(client);
                        bool shouldPersist = await CheckToken(cancel).ConfigureAwait(false);

                        client.DefaultRequestHeaders.Remove("ApiKey");
                        client.DefaultRequestHeaders.Remove("Token");

                        client.DefaultRequestHeaders.Add("ApiKey", _settings.ApiKey);
                        client.DefaultRequestHeaders.Add("Token",  _settings.Token);

                        _client = client;

                        if (shouldPersist && PersistSettings != null) // persist outside the lock so threads can continue
                            await PersistSettings(_settings, cancel).ConfigureAwait(false);
                    }
                }
                finally
                {
                    _applyChangesLock.Release();
                }
            }

            return _client;
        }

        private void SetUserAgent(HttpClient client)
        {
            if (_productInfo is null)
            {
                if (_settings.AutomaticallySetUserAgent)
                {
                    AssemblyName asmName = Assembly.GetEntryAssembly()?.GetName() ?? Assembly.GetCallingAssembly().GetName();

                    string userAgent = asmName.Name ?? _settings.UserAgentName;
                    string version = asmName.Version.ToString(4) ?? _settings.UserAgentVersion;

                    if (!string.IsNullOrWhiteSpace(userAgent))
                        _productInfo = new ProductInfoHeaderValue(userAgent, version);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(_settings.UserAgentName))
                        _productInfo = new ProductInfoHeaderValue(_settings.UserAgentName, _settings.UserAgentVersion);
                }
            }

            client.DefaultRequestHeaders.UserAgent.Add(_productInfo);
        }

        private bool CheckTokenExpire()
        {
            if (_settings.TokenExpire <= 0)
                return true;

            return _settings.TokenExpireDateTime < DateTime.Now.AddMinutes(-10);
        }

        /// <summary>
        /// Returns true if the token was refreshed (Settings should be persisted when true)
        /// </summary>
        /// <remarks>
        /// This should always be called from within a _applyChangesLock lock.
        /// </remarks>
        /// <exception cref="InvalidCredentialException">When the credentials are invalid</exception>
        /// <exception cref="AuthenticationException">When the authentication server is not available or a network error occurs</exception>
        private async Task<bool> CheckToken(CancellationToken cancel)
        {
            // Check if the token will expire in the next 30 minutes
            if (CheckTokenExpire())
                _settings.Token = null;

            // Get a token if needed
            if (string.IsNullOrWhiteSpace(_settings.Token))
            {
                if (string.IsNullOrWhiteSpace(_settings.AuthenticationAddress))
                    _settings.AuthenticationAddress = "https://oauth.vendit.online/Api";

                string url = _settings.AuthenticationAddress.TrimEnd('/', '\\') + "/GetToken";

                MultipartFormDataContent req = new MultipartFormDataContent
                {
                    { new StringContent(_settings.ApiKey), "apiKey" },
                    { new StringContent(_settings.Username), "username" },
                    { new StringContent(_settings.Password), "password" }
                };

                HttpClient client = new HttpClient();
                SetUserAgent(client);

                HttpResponseMessage response = await client.PostAsync(url, req, cancel).ConfigureAwait(false);
                if (!(response?.IsSuccessStatusCode ?? false))
                {
                    if (response?.StatusCode == HttpStatusCode.Unauthorized)
                        throw new InvalidCredentialException(response?.ReasonPhrase);
                    throw new AuthenticationException(response?.ReasonPhrase);
                }

                string rep = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (string.IsNullOrWhiteSpace(rep))
                    throw new Exception("Emty response from Authorization server.");
                TokenResponse tr = JsonConvert.DeserializeObject<TokenResponse>(rep);
                if (tr == null)
                    throw new Exception("Unexpected reply from Authorization server.");

                _settings.Token = tr.Token;
                _settings.TokenExpire = DateTimeOffset.FromUnixTimeSeconds(tr.Expire).Ticks; // Convert Unix time to ticks

                return true;
            }

            return false;
        }

        /// <summary>
        /// Will check if the token is currently valid by calling Utils/CheckApiKeyAndToken and if not will do one attempt to recover and recheck
        /// </summary>
        public async Task<bool> ValidateApiKeyAndToken(CancellationToken cancel = default)
        {
            bool ok = await CheckApiKeyAndToken(cancel).ConfigureAwait(false); ;
            if (!ok)
            {
                try
                {
                    await _applyChangesLock.WaitAsync(cancel).ConfigureAwait(false);
                    _settings.Token = null;
                    await CheckToken(cancel).ConfigureAwait(false);

                    bool shouldPersist = await CheckToken(cancel).ConfigureAwait(false);

                    _client.DefaultRequestHeaders.Remove("Token");
                    _client.DefaultRequestHeaders.Add("Token",  _settings.Token);

                    if (shouldPersist && PersistSettings != null) // persist outside the lock so threads can continue
                        await PersistSettings(_settings, cancel).ConfigureAwait(false);

                }
                finally
                {
                    _applyChangesLock.Release();
                }
                ok = await CheckApiKeyAndToken(cancel).ConfigureAwait(false);
            }

            return ok;
        }
        
        public class TokenResponse
        {
            public string Token { get; set; }
            public long Expire { get; set; }

        }

        protected async Task<TResults> FindSomething<TResults, TFilters>(TFilters filters, CancellationToken cancel, string url)
        where TResults : IResultsReply
        where TFilters : IBaseFilters
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            string payload = JsonConvert.SerializeObject(filters);

            StringContent body = new StringContent(payload, Encoding.UTF8, "application/json");

            Logger?.LogTrace(string.Concat("Calling ", url, " with ", filters.Count, " filters."));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.PostAsync(url, body, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogError(message);
                throw new Exception(message);
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            TResults results = JsonConvert.DeserializeObject<TResults>(responseString);

            Logger?.LogTrace(string.Concat("Calling ", url, " returned ", results?.PaginationRowCount.ToString() ?? "null", " results."));

            return results;
        }


        protected async Task<TResults> GetSomething<TResults>(string id, CancellationToken cancel, string url)
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            url = string.Concat(url.TrimEnd('/', '\\'), '/', id);

            Logger?.LogTrace(string.Concat("Calling ", url, " (ID = ", id, ")."));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.GetAsync(url, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogError(message);
                throw new Exception(message);
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            TResults results = JsonConvert.DeserializeObject<TResults>(responseString);

            Logger?.LogTrace(string.Concat("Called ", url, " successfully."));

            return results;
        }

        protected async Task<TResults[]> GetMultiple<TResults, TPrimaryKey>(TPrimaryKey[] ids, CancellationToken cancel, string url)
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            url = string.Concat(url.TrimEnd('/', '\\'), "/GetMultiple");

            Ids<TPrimaryKey> bdy = new Ids<TPrimaryKey>(ids);

            string payload = JsonConvert.SerializeObject(bdy);
            StringContent body = new StringContent(payload, Encoding.UTF8, "application/json");

            Logger?.LogTrace(string.Concat("Calling ", url, " with ", ids.Length, " IDs."));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.PostAsync(url, body, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogError(message);
                throw new Exception(message);
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            Results<TResults> results = JsonConvert.DeserializeObject<Results<TResults>>(responseString);

            Logger?.LogTrace(string.Concat("Calling ", url, " returned ", results?.Items?.Length.ToString() ?? "null", " results."));

            return results?.Items;
        }

        protected async Task<TResults[]> GetAll<TResults>(CancellationToken cancel, string url)
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            url = string.Concat(url.TrimEnd('/', '\\'), "/GetAll");

            Logger?.LogTrace(string.Concat("Calling ", url));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.GetAsync(url, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogError(message);
                throw new Exception(message);
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            Results<TResults> results = JsonConvert.DeserializeObject<Results<TResults>>(responseString);

            Logger?.LogTrace(string.Concat("Calling ", url, " returned ", results?.Items?.Length.ToString() ?? "null", " results."));

            return results?.Items;
        }

        protected async Task<TResults[]> GetMultiple<TResults>(CancellationToken cancel, string url)
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            Logger?.LogTrace(string.Concat("Calling ", url));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.GetAsync(url, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogError(message);
                throw new Exception(message);
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            Results<TResults> results = JsonConvert.DeserializeObject<Results<TResults>>(responseString);

            Logger?.LogTrace(string.Concat("Calling ", url, " returned ", results?.Items?.Length.ToString() ?? "null", " results."));

            return results?.Items;
        }

        protected async Task<bool> CheckApiKeyAndToken(CancellationToken cancel = default)
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            string url = "/VenditPublicApi/Utils/CheckApiKeyAndToken";

            Logger?.LogTrace(string.Concat("Calling ", url));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.GetAsync(url, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogWarning(message);
                return false;
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Logger?.LogTrace(string.Concat("Calling ", url, " returned ", responseString));

            return responseString == "true";
        }

        protected async Task<TResults> GetSomething<TResults>(CancellationToken cancel, string url)
        {
            ConfiguredTaskAwaitable<HttpClient> clientTask = GetClient(cancel).ConfigureAwait(false);

            Logger?.LogTrace(string.Concat("Calling ", url));

            HttpClient client = await clientTask;

            HttpResponseMessage response = await client.GetAsync(url, cancel).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                string message = string.Concat("Server responded with ", (int)response.StatusCode, " : ", response.ReasonPhrase);
                Logger?.LogError(message);
                throw new Exception(message);
            }

            string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            TResults results = JsonConvert.DeserializeObject<TResults>(responseString);

            Logger?.LogTrace(string.Concat("Called ", url, " successfully."));

            return results;
        }

    }
}
