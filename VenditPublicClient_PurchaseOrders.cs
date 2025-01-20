using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public PurchaseOrdersSection PurchaseOrders;

        public class PurchaseOrdersSection
        {
            private VenditPublicClient _client;

            internal PurchaseOrdersSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<PurchaseOrderResults> FindPurchaseOrder(PurchaseOrderFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<PurchaseOrderResults, PurchaseOrderFilters>(filters, cancel, "/VenditPublicApi/PurchaseOrders/Find");
            }

            public Task<PurchaseOrderResults> FindPurchaseOrder(PurchaseOrderFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<PurchaseOrderResults, PurchaseOrderFilters>(new PurchaseOrderFilters(new PurchaseOrderFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/PurchaseOrders/Find");
            }

            public Task<ProductPurchaseOrder> GetPurchaseOrder(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductPurchaseOrder>(id.ToString(), cancel, "/VenditPublicApi/PurchaseOrders/");
            }

            public Task<ProductPurchaseOrder[]> GetPurchaseOrders(params int[] ids)
            {
                return GetPurchaseOrders(CancellationToken.None, ids);
            }

            public Task<ProductPurchaseOrder[]> GetPurchaseOrders(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<ProductPurchaseOrder, int>(ids, cancel, "/VenditPublicApi/PurchaseOrders");
            }

            public Task<ProductPurchaseOrder> GetPurchaseOrderWithDetails(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductPurchaseOrder>(id.ToString(), cancel, "/VenditPublicApi/PurchaseOrders/GetWithDetails");
            }
        }
    }
}
