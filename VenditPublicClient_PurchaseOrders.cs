using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.GetWithDetails;
using VenditPublicSdk.Entities.Import;
using VenditPublicSdk.Entities.Internal;
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

            public Task<ProductPurchaseOrder> GetPurchaseOrder(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductPurchaseOrder>(id.ToString(), cancel, "/VenditPublicApi/PurchaseOrders/");
            }

            public Task<ProductPurchaseOrder[]> GetPurchaseOrders(params long[] ids)
            {
                return GetPurchaseOrders(CancellationToken.None, ids);
            }

            public Task<ProductPurchaseOrder[]> GetPurchaseOrders(CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<ProductPurchaseOrder, long>(ids, cancel, "/VenditPublicApi/PurchaseOrders");
            }

            public Task<ProductPurchaseOrder[]> GetPurchaseOrders(IncludePurchaseOrderDetails details, CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<ProductPurchaseOrder, long>(ids, cancel, "/VenditPublicApi/PurchaseOrders", $"?detailFlags={(long)details}");
            }

            public Task<ProductPurchaseOrder> GetPurchaseOrderWithDetails(long id, IncludePurchaseOrderDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductPurchaseOrder>(cancel, $"/VenditPublicApi/PurchaseOrders/GetWithDetails/{id}/{(int)details}");
            }

            public Task<ProductPurchaseOrder> GetPurchaseOrderWithDetails(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductPurchaseOrder>(id.ToString(), cancel, "/VenditPublicApi/PurchaseOrders/GetWithDetails");
            }

            public Task<long[]> GetAllPurchaseOrderIds(CancellationToken cancel = default)
            {
                return _client.GetSomething<long[]>(cancel, $"/VenditPublicApi/PurchaseOrders/GetAllIds");
            }

            // --- HistoryPurchaseOrder

            public Task<HistoryPurchaseOrderResults> FindHistoryPurchaseOrder(HistoryPurchaseOrderFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<HistoryPurchaseOrderResults, HistoryPurchaseOrderFilters>(filters, cancel, "/VenditPublicApi/HistoryPurchaseOrders/Find");
            }

            public Task<HistoryPurchaseOrderResults> FindHistoryPurchaseOrder(HistoryPurchaseOrderFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<HistoryPurchaseOrderResults, HistoryPurchaseOrderFilters>(new HistoryPurchaseOrderFilters(new HistoryPurchaseOrderFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/HistoryPurchaseOrders/Find");
            }

            public Task<HistoryPurchaseHeader> GetHistoryPurchaseOrder(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<HistoryPurchaseHeader>(id.ToString(), cancel, "/VenditPublicApi/HistoryPurchaseOrders/");
            }

            public Task<HistoryPurchaseHeader[]> GetHistoryPurchaseOrders(params long[] ids)
            {
                return GetHistoryPurchaseOrders(CancellationToken.None, ids);
            }

            public Task<HistoryPurchaseHeader[]> GetHistoryPurchaseOrders(CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<HistoryPurchaseHeader, long>(ids, cancel, "/VenditPublicApi/HistoryPurchaseOrders");
            }

            public Task<HistoryPurchaseHeader[]> GetHistoryPurchaseOrders(IncludeHistoryPurchaseOrderDetails details, CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<HistoryPurchaseHeader, long>(ids, cancel, "/VenditPublicApi/HistoryPurchaseOrders", $"?detailFlags={(long)details}");
            }

            public Task<HistoryPurchaseHeader> GetHistoryPurchaseOrderWithDetails(long id, IncludeHistoryPurchaseOrderDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<HistoryPurchaseHeader>(cancel, $"/VenditPublicApi/HistoryPurchaseOrders/GetWithDetails/{id}/{(int)details}");
            }

            public Task<HistoryPurchaseHeader> GetHistoryPurchaseOrderWithDetails(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<HistoryPurchaseHeader>(id.ToString(), cancel, "/VenditPublicApi/HistoryPurchaseOrders/GetWithDetails");
            }

            // --- ProductPreorder

            public Task<PrePurchaseOrder> GetPrePurchaseOrder(int prePurchaseOrderId, CancellationToken cancel = default)
            {
                return _client.GetSomething<PrePurchaseOrder>(prePurchaseOrderId.ToString(), cancel, "/VenditPublicApi/PrePurchaseOrders/");
            }

            public Task<PrePurchaseOrder[]> GetPrePurchaseOrders(params int[] ids)
            {
                return GetPrePurchaseOrders(CancellationToken.None, ids);
            }

            public Task<PrePurchaseOrder[]> GetPrePurchaseOrders(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<PrePurchaseOrder, int>(ids, cancel, "/VenditPublicApi/PrePurchaseOrders/");
            }

            /// <summary>
            /// Get multiple order advices by their IDs, including the requested details
            /// </summary>
            /// <param name="details">Add up all wanted details to get multiple details in one call</param>
            /// <param name="cancel">Cancellation token</param>
            /// <param name="ids">PrePurchaseOrder IDs (PRODUCT_PREORDER_ID)</param>
            /// <returns>Collection of order advices</returns>
            public Task<PrePurchaseOrder[]> GetPrePurchaseOrders(IncludePrePurchaseOrderDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<PrePurchaseOrder, int>(ids, cancel, "/VenditPublicApi/PrePurchaseOrders/", $"?detailFlags={(long)details}");
            }

            /// <summary>
            /// Get one order advice including the requested details
            /// </summary>
            /// <param name="prePurchaseOrderId">PrePurchaseOrder ID (PRODUCT_PREORDER_ID)</param>
            /// <param name="details">Add up all wanted details to get multiple details in one call</param>
            /// <param name="cancel">Cancellation token</param>
            public Task<PrePurchaseOrder> GetPrePurchaseOrderWithDetails(int prePurchaseOrderId, IncludePrePurchaseOrderDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<PrePurchaseOrder>(cancel, $"/VenditPublicApi/PrePurchaseOrders/GetWithDetails/{prePurchaseOrderId}/{(int)details}");
            }

            public Task<PrePurchaseOrder[]> GetAllPrePurchaseOrders(CancellationToken cancel = default)
            {
                return _client.GetAll<PrePurchaseOrder>(cancel, "/VenditPublicApi/PrePurchaseOrders/");
            }

            public async Task<int> ImportProductsToBeOrdered(CancellationToken cancel, params PrePurchaseOrder[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/PrePurchaseOrders/Import", new Results<PrePurchaseOrder>(import));
                int    ret   = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }
        }
    }
}
