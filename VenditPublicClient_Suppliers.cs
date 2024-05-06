using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<SupplierResults> FindSupplier(SupplierFilters filters, int officeId = 0, CancellationToken cancel = default)
        {
            string url = "/VenditPublicApi/Suppliers/Find";
            if (officeId != 0)
                url = string.Concat(url, "?officeId=", officeId);
            return FindSomething<SupplierResults, SupplierFilters>(filters, cancel, url);
        }

        public Task<SupplierResults> FindSupplier(SupplierFields field, object value, FilterComparison filterComparison, int officeId = 0, CancellationToken cancel = default)
        {
            string url = "/VenditPublicApi/Suppliers/Find";
            if (officeId != 0)
                url = string.Concat(url, "?officeId=", officeId);
            return FindSomething<SupplierResults, SupplierFilters>(new SupplierFilters(new SupplierFilter(field, value, filterComparison)), cancel, url);
        }

        public Task<Supplier> GetSupplier(int id, CancellationToken cancel = default)
        {
            return GetSomething<Supplier>(id.ToString(), cancel, "/VenditPublicApi/Suppliers/");
        }

        public Task<Supplier[]> GetSuppliers(params int[] ids)
        {
            return GetSuppliers(CancellationToken.None, ids);
        }

        public Task<Supplier[]> GetSuppliers(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Supplier, int>(ids, cancel, "/VenditPublicApi/Suppliers");
        }

        public Task<Address[]> GetSupplierAddresses(int supplierId, CancellationToken cancel=default)
        {
            return GetMultiple<Address>(cancel, "/VenditPublicApi/Suppliers/GetAddresses/" + supplierId);
        }
    }
}
