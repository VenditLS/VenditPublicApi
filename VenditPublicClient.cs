using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient: VenditPublicClientBase
    {
        /// <summary>
        /// Recommended constructor
        /// </summary>
        public VenditPublicClient(VenditPublicClientSettings settings, ILogger logger = null) : base(settings, logger) { }

        /// <summary>
        /// For users who persist the token in private database
        /// </summary>
        public VenditPublicClient(string apiKey, string token, DateTime tokenExpire, ILogger logger = null) : base(apiKey, token, tokenExpire, logger) { }

        /// <summary>
        /// For convenience, your requests will be faster if you preserve the token.
        /// <para>
        /// The token and its expiration will be available in the Settings property after the first request.
        /// We recommend persisting the whole VenditPublicClientSettings object and using the constructor that accepts it.
        /// </para>
        /// </summary>
        public VenditPublicClient(string apiKey, string userName, string password, ILogger logger = null) : base(apiKey, userName, password, logger) { }



        // --- Employees

        public Task<Employee> GetEmployee(int id, CancellationToken cancel = default)
        {
            return GetSomething<Employee>(id.ToString(), cancel, "/VenditPublicApi/Employees/");
        }

        public Task<Employee[]> GetEmployees(params int[] ids)
        {
            return GetEmployees(CancellationToken.None, ids);
        }

        public Task<Employee[]> GetEmployees(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Employee, int>(ids, cancel, "/VenditPublicApi/Employees");
        }

        public Task<Employee[]> GetAllEmployees(CancellationToken cancel = default)
        {
            return GetMultiple<Employee>(cancel, "/VenditPublicApi/Employees/GetAll");
        }

        // --- Offices

        public Task<Office> GetOffice(int id, CancellationToken cancel = default)
        {
            return GetSomething<Office>(id.ToString(), cancel, "/VenditPublicApi/Offices/");
        }

        public Task<Office[]> GetOffices(params int[] ids)
        {
            return GetOffices(CancellationToken.None, ids);
        }

        public Task<Office[]> GetOffices(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Office, int>(ids, cancel, "/VenditPublicApi/Offices");
        }

        public Task<Office[]> GetAllOffices(CancellationToken cancel = default)
        {
            return GetAll<Office>(cancel, "/VenditPublicApi/Offices");
        }

    }
}
