using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Import;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public SuppliersSection Suppliers;

        public class SuppliersSection
        {
            private VenditPublicClient _client;

            internal SuppliersSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<SupplierResults> FindSupplier(SupplierFilters filters, int officeId = 0, CancellationToken cancel = default)
            {
                string url = "/VenditPublicApi/Suppliers/Find";
                if (officeId != 0)
                    url = $"{url}?officeId={officeId}";
                return _client.FindSomething<SupplierResults, SupplierFilters>(filters, cancel, url);
            }

            public Task<SupplierResults> FindSupplier(SupplierFields field, object value, FilterComparison filterComparison, int officeId = 0, CancellationToken cancel = default)
            {
                string url = "/VenditPublicApi/Suppliers/Find";
                if (officeId != 0)
                    url = $"{url}?officeId={officeId}";
                return _client.FindSomething<SupplierResults, SupplierFilters>(new SupplierFilters(new SupplierFilter(field, value, filterComparison)), cancel, url);
            }

            public Task<Supplier> GetSupplier(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Supplier>(id.ToString(), cancel, "/VenditPublicApi/Suppliers/");
            }

            public Task<Supplier[]> GetSuppliers(params int[] ids)
            {
                return GetSuppliers(CancellationToken.None, ids);
            }

            public Task<Supplier[]> GetSuppliers(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Supplier, int>(ids, cancel, "/VenditPublicApi/Suppliers");
            }

            public Task<Address[]> GetSupplierAddresses(int supplierId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<Address>(cancel, $"/VenditPublicApi/Suppliers/GetAddresses/{supplierId}");
            }

            public Task<int[]> GetAllSupplierIds(CancellationToken cancel = default)
            {
                return _client.GetSomething<int[]>(cancel, $"/VenditPublicApi/Suppliers/GetAllIds");
            }

            // --- Import

            public async Task<int> ImportSuppliers(CancellationToken cancel = default, params ImportSupplier[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/Suppliers/Import", new Results<ImportSupplier>(import));
                int    ret   = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }

            public async Task<int> ImportAddressesForSupplier(int supplierId, CancellationToken cancel = default, params ImportAddress[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/Addresses/ImportForSupplier/" + supplierId, new Results<ImportAddress>(import));
                int    ret   = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }
        }
    }
}
