using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Lookups;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<OrderResults> FindOrder(OrderFilters filters, CancellationToken cancel = default)
        {
            return FindSomething<OrderResults, OrderFilters>(filters, cancel, "/VenditPublicApi/Orders/Find");
        }

        public Task<OrderResults> FindOrder(OrderFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
        {
            return FindSomething<OrderResults, OrderFilters>(new OrderFilters(new OrderFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Orders/Find");
        }

        public Task<Order> GetOrder(int id, CancellationToken cancel = default)
        {
            return GetSomething<Order>(id.ToString(), cancel, "/VenditPublicApi/Orders/");
        }

        public Task<Order[]> GetOrders(params int[] ids)
        {
            return GetOrders(CancellationToken.None, ids);
        }

        public Task<Order[]> GetOrders(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Order, int>(ids, cancel, "/VenditPublicApi/Orders");
        }

        public Task<long[]> GetOrderIdsForCustomer(int customerId, CancellationToken cancel = default)
        {
            return GetSomething<long[]>(customerId.ToString(), cancel, "/VenditPublicApi/Orders/GetForCustomer");
        }

        public Task<Order> GetOrderWithDetails(int id, CancellationToken cancel = default)
        {
            return GetSomething<Order>(id.ToString(), cancel, "/VenditPublicApi/Orders/GetWithDetails");
        }

        // OrderStatus

        public Task<OrderStatus> GetOrderStatus(int statusId, CancellationToken cancel = default)
        {
            return GetSomething<OrderStatus>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/OrderStatuses/");
        }

        public Task<OrderStatus[]> GetOrderStatuses(params int[] ids)
        {
            return GetOrderStatuses(CancellationToken.None, ids);
        }

        public Task<OrderStatus[]> GetOrderStatuses(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<OrderStatus, int>(ids, cancel, "/VenditPublicApi/Lookups/OrderStatuses/");
        }

        public Task<OrderStatus[]> GetAllOrderStatuses(CancellationToken cancel = default)
        {
            return GetAll<OrderStatus>(cancel, "/VenditPublicApi/Lookups/OrderStatuses/");
        }


        // OrderType

        public Task<OrderType> GetOrderType(int statusId, CancellationToken cancel = default)
        {
            return GetSomething<OrderType>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/OrderTypes/");
        }

        public Task<OrderType[]> GetOrderTypes(params int[] ids)
        {
            return GetOrderTypes(CancellationToken.None, ids);
        }

        public Task<OrderType[]> GetOrderTypes(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<OrderType, int>(ids, cancel, "/VenditPublicApi/Lookups/OrderTypes/");
        }

        public Task<OrderType[]> GetAllOrderTypes(CancellationToken cancel = default)
        {
            return GetAll<OrderType>(cancel, "/VenditPublicApi/Lookups/OrderTypes/");
        }
    }
}
