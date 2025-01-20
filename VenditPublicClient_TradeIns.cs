using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
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
        }
    }
}
