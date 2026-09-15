using System.Threading.Tasks;
using System.Threading;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.GetWithDetails;

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

            /// <summary>
            /// Get multiple employees by their IDs, including the requested details
            /// </summary>
            /// <param name="details">Add up all wanted details to get multiple details in one call</param>
            /// <param name="cancel">Cancellation token</param>
            /// <param name="ids">Employee IDs</param>
            /// <returns>Collection of employees</returns>
            public Task<Employee[]> GetEmployees(IncludeEmployeeDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Employee, int>(ids, cancel, "/VenditPublicApi/Employees", $"?detailFlags={(long)details}");
            }

            /// <summary>
            /// Get one employee including the requested details
            /// </summary>
            /// <param name="id">Employee ID</param>
            /// <param name="details">Add up all wanted details to get multiple details in one call</param>
            /// <param name="cancel">Cancellation token</param>
            public Task<Employee> GetEmployeeWithDetails(int id, IncludeEmployeeDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<Employee>(cancel, $"/VenditPublicApi/Employees/GetWithDetails/{id}/{(int)details}");
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

            public Task<Office[]> GetOffices(IncludeOfficeDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Office, int>(ids, cancel, "/VenditPublicApi/Offices", $"?detailFlags={(long)details}");
            }

            public Task<Office> GetOfficeWithDetails(int id, IncludeOfficeDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<Office>(cancel, $"/VenditPublicApi/Offices/GetWithDetails/{id}/{(int)details}");
            }

            public Task<Office[]> GetAllOffices(CancellationToken cancel = default)
            {
                return _client.GetAll<Office>(cancel, "/VenditPublicApi/Offices");
            }
        }
    }
}
