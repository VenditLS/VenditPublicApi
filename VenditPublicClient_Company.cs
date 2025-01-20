using System.Threading.Tasks;
using System.Threading;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public CompanySection Company;

        public class CompanySection
        {
            private VenditPublicClient _client;

            internal CompanySection(VenditPublicClient client)
            {
                _client = client;
            }


            // --- Employees

            public Task<Employee> GetEmployee(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Employee>(id.ToString(), cancel, "/VenditPublicApi/Employees/");
            }

            public Task<Employee[]> GetEmployees(params int[] ids)
            {
                return GetEmployees(CancellationToken.None, ids);
            }

            public Task<Employee[]> GetEmployees(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Employee, int>(ids, cancel, "/VenditPublicApi/Employees");
            }

            public Task<Employee[]> GetAllEmployees(CancellationToken cancel = default)
            {
                return _client.GetMultiple<Employee>(cancel, "/VenditPublicApi/Employees/GetAll");
            }

            // --- Offices

            public Task<Office> GetOffice(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Office>(id.ToString(), cancel, "/VenditPublicApi/Offices/");
            }

            public Task<Office[]> GetOffices(params int[] ids)
            {
                return GetOffices(CancellationToken.None, ids);
            }

            public Task<Office[]> GetOffices(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Office, int>(ids, cancel, "/VenditPublicApi/Offices");
            }

            public Task<Office[]> GetAllOffices(CancellationToken cancel = default)
            {
                return _client.GetAll<Office>(cancel, "/VenditPublicApi/Offices");
            }
        }
    }
}
