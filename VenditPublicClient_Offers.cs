using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<OfferResults> FindOffer(OfferFilters filters, CancellationToken cancel = default)
        {
            return FindSomething<OfferResults, OfferFilters>(filters, cancel, "/VenditPublicApi/Offers/Find");
        }

        public Task<OfferResults> FindOffer(OfferFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
        {
            return FindSomething<OfferResults, OfferFilters>(new OfferFilters(new OfferFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Offers/Find");
        }

        public Task<Offer> GetOffer(int id, CancellationToken cancel = default)
        {
            return GetSomething<Offer>(id.ToString(), cancel, "/VenditPublicApi/Offers/");
        }

        public Task<Offer[]> GetOffers(params int[] ids)
        {
            return GetOffers(CancellationToken.None, ids);
        }

        public Task<Offer[]> GetOffers(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Offer, int>(ids, cancel, "/VenditPublicApi/Offers");
        }

        public Task<Offer> GetOfferWithDetails(int id, CancellationToken cancel = default)
        {
            return GetSomething<Offer>(id.ToString(), cancel, "/VenditPublicApi/Offers/GetWithDetails");
        }

        public Task<long[]> GetOfferIdsForCustomer(int customerId, CancellationToken cancel = default)
        {
            return GetSomething<long[]>(customerId.ToString(), cancel, "/VenditPublicApi/Offers/GetForCustomer");
        }
    }
}
