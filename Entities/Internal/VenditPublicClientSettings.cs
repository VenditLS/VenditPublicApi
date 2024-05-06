using System;

namespace VenditPublicSdk.Entities.Internal
{
    [Serializable]
    public class VenditPublicClientSettings : ICloneable
    {
        /// <summary>
        /// API key for Vendit Public API
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Username required to get a token
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password required to get a token
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Current token (previously retrieved and persisted)
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Date and time in Ticks when the current token will expire
        /// </summary>
        public long TokenExpire { get; set; }

        /// <summary>
        /// Converts ticks into DateTime for convenience
        /// </summary>
        public DateTime TokenExpireDateTime
        {
            get { return new DateTime(TokenExpire); }
        }


        #region Optional fields

        /// <summary>
        /// When true sets user agent name and version using Assembly.GetEntryAssembly()?.GetName()
        /// This info is not required but may come in handy when Vendit Support needs to inspect server log files (particularly when not yet authenticated).
        /// </summary>
        public bool AutomaticallySetUserAgent { get; set; } = true;

        /// <summary>
        /// Used when AutomaticallySetUserAgent is false
        /// </summary>
        public string UserAgentName { get; set; }

        /// <summary>
        /// Used when AutomaticallySetUserAgent is false
        /// </summary>
        public string UserAgentVersion { get; set; }

        #endregion



        #region Advanced or for internal use

        /// <summary>
        /// Leave empty to connect to the public production server (https://api2.vendit.online/VenditPublicApi). This setting only needs to change when connecting to a Development, Staging or Release-Candidate server.
        /// <para>
        /// For internal use by Vendit or in rare occasions where a customer may have a test/pilot project calling APIs that are not yet available in production.
        /// </para>
        /// </summary>
        public string BaseAddress { get; set; }

        /// <summary>
        /// Leave empty to connect to the public production authentication server (https://oauth.vendit.online/Api). This setting only needs to change when connecting to a Development, Staging or Release-Candidate server.
        /// <para>
        /// For internal use by Vendit or in rare occasions where a customer may have a test/pilot project calling APIs that are not yet available in production.
        /// </para>
        /// </summary>
        public string AuthenticationAddress { get; set; }

        #endregion


        /// <summary>
        /// Compares all settings except Token and TokenExpire fields
        /// </summary>
        /// <param name="obj">Should be an other VenditPublicClientSettings instance.</param>
        public override bool Equals(object obj)
        {
            VenditPublicClientSettings other = obj as VenditPublicClientSettings;
            if (other == null)
                return false;

            return ApiKey == other.ApiKey
                   && Username == other.Username
                   && Password == other.Password
                   && AutomaticallySetUserAgent == other.AutomaticallySetUserAgent
                   && UserAgentName == other.UserAgentName
                   && UserAgentVersion == other.UserAgentVersion
                   && BaseAddress == other.BaseAddress
                   && AuthenticationAddress == other.AuthenticationAddress;
        }

        public object Clone()
        {
            return CloneTo(new VenditPublicClientSettings());
        }

        /// <summary>
        /// Inheritance friendly cloning
        /// </summary>
        public virtual VenditPublicClientSettings CloneTo(VenditPublicClientSettings other)
        {
            other.ApiKey = ApiKey;
            other.Username = Username;
            other.Password = Password;
            other.Token = Token;
            other.TokenExpire = TokenExpire;
            other.AutomaticallySetUserAgent = AutomaticallySetUserAgent;
            other.UserAgentName = UserAgentName;
            other.UserAgentVersion = UserAgentVersion;
            other.BaseAddress = BaseAddress;
            other.AuthenticationAddress = AuthenticationAddress;
            return other;
        }
    }
}
