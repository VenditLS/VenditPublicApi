using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{

    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<TradeInResults> FindTradeIn(TradeInFilters filters, CancellationToken cancel = default)
        {
            return FindSomething<TradeInResults, TradeInFilters>(filters, cancel, "/VenditPublicApi/TradeIns/Find");
        }

        public Task<TradeInResults> FindTradeIn(TradeInFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
        {
            return FindSomething<TradeInResults, TradeInFilters>(new TradeInFilters(new TradeInFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/TradeIns/Find");
        }

        public Task<TradeIn> GetTradeIn(int id, CancellationToken cancel = default)
        {
            return GetSomething<TradeIn>(id.ToString(), cancel, "/VenditPublicApi/TradeIns/");
        }

        public Task<TradeIn[]> GetTradeIns(params int[] ids)
        {
            return GetTradeIns(CancellationToken.None, ids);
        }

        public Task<TradeIn[]> GetTradeIns(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<TradeIn, int>(ids, cancel, "/VenditPublicApi/TradeIns");
        }
    }
}
