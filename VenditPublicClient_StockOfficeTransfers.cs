using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.GetWithDetails;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public StockOfficeTransferSection StockOfficeTransfers;
        public class StockOfficeTransferSection
        {
            private VenditPublicClient _client;

            internal StockOfficeTransferSection(VenditPublicClient client)
            {
                _client = client;
            }

            // Orders

            public Task<StockOfficeTransferOrder> GetTransferOrder(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransferOrder>(id.ToString(), cancel, "/VenditPublicApi/StockOfficeOrders");
            }

            public Task<StockOfficeTransferOrder[]> GetTransferOrders(params int[] ids)
            {
                return GetTransferOrders(CancellationToken.None, ids);
            }

            public Task<StockOfficeTransferOrder[]> GetTransferOrders(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<StockOfficeTransferOrder, int>(ids, cancel, "/VenditPublicApi/StockOfficeOrders");
            }

            public Task<StockOfficeTransferOrder[]> GetTransferOrders(IncludeStockOfficeTransferOrderDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<StockOfficeTransferOrder, int>(ids, cancel, "/VenditPublicApi/StockOfficeOrders", $"?detailFlags={(long)details}");
            }

            public Task<StockOfficeTransferOrder> GetTransferOrderWithDetails(int id, IncludeStockOfficeTransferOrderDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransferOrder>(cancel, $"/VenditPublicApi/StockOfficeOrders/GetWithDetails/{id}/{(int)details}");
            }

            public Task<StockOfficeTransferOrder[]> GetAllTransferOrders(CancellationToken cancel = default)
            {
                return _client.GetAll<StockOfficeTransferOrder>(cancel, "/VenditPublicApi/StockOfficeOrders");
            }

            // Active Transfers

            public Task<StockOfficeTransfer> GetStockOfficeTransfer(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransfer>(id.ToString(), cancel, "/VenditPublicApi/StockOfficeTransfers");
            }

            public Task<StockOfficeTransfer[]> GetStockOfficeTransfers(params int[] ids)
            {
                return GetStockOfficeTransfers(CancellationToken.None, ids);
            }

            public Task<StockOfficeTransfer[]> GetStockOfficeTransfers(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<StockOfficeTransfer, int>(ids, cancel, "/VenditPublicApi/StockOfficeTransfers");
            }

            public Task<StockOfficeTransfer[]> GetStockOfficeTransfers(IncludeStockOfficeTransferDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<StockOfficeTransfer, int>(ids, cancel, "/VenditPublicApi/StockOfficeTransfers", $"?detailFlags={(long)details}");
            }

            public Task<StockOfficeTransfer> GetStockOfficeTransferWithDetails(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransfer>(id.ToString(), cancel, "/VenditPublicApi/StockOfficeTransfers/GetWithDetails");
            }

            public Task<StockOfficeTransfer> GetStockOfficeTransferWithDetails(int id, IncludeStockOfficeTransferDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransfer>(cancel, $"/VenditPublicApi/StockOfficeTransfers/GetWithDetails/{id}/{(int)details}");
            }

            public Task<StockOfficeTransfer[]> GetAllStockOfficeTransfers(CancellationToken cancel = default)
            {
                return _client.GetAll<StockOfficeTransfer>(cancel, "/VenditPublicApi/StockOfficeTransfers");
            }

            // Transfer History

            public Task<StockOfficeTransferHistoryResults> FindStockOfficeTransferHistory(StockOfficeTransferHistoryFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<StockOfficeTransferHistoryResults, StockOfficeTransferHistoryFilters>(filters, cancel, "/VenditPublicApi/StockOfficeHistoryTransfers/Find");
            }

            public Task<StockOfficeTransferHistoryResults> FindStockOfficeTransferHistory(StockOfficeTransferFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<StockOfficeTransferHistoryResults, StockOfficeTransferHistoryFilters>(new StockOfficeTransferHistoryFilters(new StockOfficeTransferHistoryFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/StockOfficeHistoryTransfers/Find");
            }

            public Task<StockOfficeTransferHistory> GetStockOfficeTransferHistory(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransferHistory>(id.ToString(), cancel, "/VenditPublicApi/StockOfficeHistoryTransfers");
            }

            public Task<StockOfficeTransferHistory[]> GetStockOfficeTransferHistorys(params int[] ids)
            {
                return GetStockOfficeTransferHistorys(CancellationToken.None, ids);
            }

            public Task<StockOfficeTransferHistory[]> GetStockOfficeTransferHistorys(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<StockOfficeTransferHistory, int>(ids, cancel, "/VenditPublicApi/StockOfficeHistoryTransfers");
            }

            public Task<StockOfficeTransferHistory[]> GetStockOfficeTransferHistorys(IncludeStockOfficeTransferHistoryDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<StockOfficeTransferHistory, int>(ids, cancel, "/VenditPublicApi/StockOfficeHistoryTransfers", $"?detailFlags={(long)details}");
            }

            public Task<StockOfficeTransferHistory> GetStockOfficeTransferHistoryWithDetails(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransferHistory>(id.ToString(), cancel, "/VenditPublicApi/StockOfficeHistoryTransfers/GetWithDetails");
            }

            public Task<StockOfficeTransferHistory> GetStockOfficeTransferHistoryWithDetails(int id, IncludeStockOfficeTransferHistoryDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<StockOfficeTransferHistory>(cancel, $"/VenditPublicApi/StockOfficeHistoryTransfers/GetWithDetails/{id}/{(int)details}");
            }
        }
    }
}
