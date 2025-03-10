using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public OffersSection Offers;

        public class OffersSection
        {
            private VenditPublicClient _client;

            internal OffersSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<OfferResults> FindOffer(OfferFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<OfferResults, OfferFilters>(filters, cancel, "/VenditPublicApi/Offers/Find");
            }

            public Task<OfferResults> FindOffer(OfferFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<OfferResults, OfferFilters>(new OfferFilters(new OfferFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Offers/Find");
            }

            public Task<Offer> GetOffer(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Offer>(id.ToString(), cancel, "/VenditPublicApi/Offers/");
            }

            public Task<Offer[]> GetOffers(params long[] ids)
            {
                return GetOffers(CancellationToken.None, ids);
            }

            public Task<Offer[]> GetOffers(CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<Offer, long>(ids, cancel, "/VenditPublicApi/Offers");
            }

            public Task<Offer> GetOfferWithDetails(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Offer>(id.ToString(), cancel, "/VenditPublicApi/Offers/GetWithDetails");
            }

            public Task<long[]> GetOfferIdsForCustomer(int customerId, CancellationToken cancel = default)
            {
                return _client.GetSomething<long[]>(customerId.ToString(), cancel, "/VenditPublicApi/Offers/GetForCustomer");
            }

            // OfferStatus

            public Task<OfferStatus> GetOfferStatus(int statusId, CancellationToken cancel = default)
            {
                return _client.GetSomething<OfferStatus>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/OfferStatuses/");
            }

            public Task<OfferStatus[]> GetOfferStatuses(params int[] ids)
            {
                return GetOfferStatuses(CancellationToken.None, ids);
            }

            public Task<OfferStatus[]> GetOfferStatuses(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<OfferStatus, int>(ids, cancel, "/VenditPublicApi/Lookups/OfferStatuses/");
            }

            public Task<OfferStatus[]> GetAllOfferStatuses(CancellationToken cancel = default)
            {
                return _client.GetAll<OfferStatus>(cancel, "/VenditPublicApi/Lookups/OfferStatuses/");
            }

            public Task UpdateStatus(long offerId, int newOfferStatusId, CancellationToken cancel = default)
            {
                return _client.Put(cancel, $"/VenditPublicApi/Offers/UpdateStatus/{offerId}/{newOfferStatusId}");
            }
        }
    }
}
