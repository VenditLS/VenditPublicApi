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
        public TradeInsSection TradeIns;

        public class TradeInsSection
        {
            private VenditPublicClient _client;

            internal TradeInsSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<TradeInResults> FindTradeIn(TradeInFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<TradeInResults, TradeInFilters>(filters, cancel, "/VenditPublicApi/TradeIns/Find");
            }

            public Task<TradeInResults> FindTradeIn(TradeInFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<TradeInResults, TradeInFilters>(new TradeInFilters(new TradeInFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/TradeIns/Find");
            }

            public Task<TradeIn> GetTradeIn(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<TradeIn>(id.ToString(), cancel, "/VenditPublicApi/TradeIns/");
            }

            public Task<TradeIn[]> GetTradeIns(params int[] ids)
            {
                return GetTradeIns(CancellationToken.None, ids);
            }

            public Task<TradeIn[]> GetTradeIns(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<TradeIn, int>(ids, cancel, "/VenditPublicApi/TradeIns");
            }

            /// <summary>
            /// Retrieve multiple trade-ins including the requested details
            /// </summary>
            /// <param name="details">Add up all wanted details to get multiple details in one call</param>
            /// <param name="cancel">Cancellation token</param>
            /// <param name="ids">TradeIn IDs</param>
            public Task<TradeIn[]> GetTradeIns(IncludeTradeInDetails details, CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<TradeIn, int>(ids, cancel, "/VenditPublicApi/TradeIns", $"?detailFlags={(long)details}");
            }

            /// <summary>
            /// Get one trade-in including the requested details
            /// </summary>
            /// <param name="id">TradeIn ID</param>
            /// <param name="details">Add up all wanted details to get multiple details in one call</param>
            /// <param name="cancel">Cancellation token</param>
            public Task<TradeIn> GetTradeInWithDetails(int id, IncludeTradeInDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<TradeIn>(cancel, $"/VenditPublicApi/TradeIns/GetWithDetails/{id}/{(int)details}");
            }

            public Task<int[]> GetAllTradeInIds(CancellationToken cancel = default)
            {
                return _client.GetSomething<int[]>(cancel, $"/VenditPublicApi/TradeIns/GetAllIds");
            }
        }
    }
}
