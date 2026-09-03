using System;
using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.GetWithDetails;
using VenditPublicSdk.Entities.Import;
using VenditPublicSdk.Entities.Lookups;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public OrdersSection Orders;

        public class OrdersSection
        {
            private VenditPublicClient _client;

            internal OrdersSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<OrderResults> FindOrder(OrderFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<OrderResults, OrderFilters>(filters, cancel, "/VenditPublicApi/Orders/Find");
            }

            public Task<OrderResults> FindOrder(OrderFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<OrderResults, OrderFilters>(new OrderFilters(new OrderFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Orders/Find");
            }

            public Task<Order> GetOrder(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Order>(id.ToString(), cancel, "/VenditPublicApi/Orders/");
            }

            public Task<Order[]> GetOrders(params long[] ids)
            {
                return GetOrders(CancellationToken.None, ids);
            }

            public Task<Order[]> GetOrders(CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<Order, long>(ids, cancel, "/VenditPublicApi/Orders");
            }

            public Task<Order[]> GetOrders(IncludeOrderDetails details, CancellationToken cancel, params long[] ids)
            {
                return _client.GetMultiple<Order, long>(ids, cancel, "/VenditPublicApi/Orders", $"?detailFlags={(long)details}");
            }

            public Task<long[]> GetOrderIdsForCustomer(int customerId, CancellationToken cancel = default)
            {
                return _client.GetSomething<long[]>(customerId.ToString(), cancel, "/VenditPublicApi/Orders/GetForCustomer");
            }

            public Task<Order> GetOrderWithDetails(long id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Order>(id.ToString(), cancel, "/VenditPublicApi/Orders/GetWithDetails");
            }

            public Task<Order> GetOrderWithDetails(long id, IncludeOrderDetails details, CancellationToken cancel = default)
            {
                return _client.GetSomething<Order>(cancel, $"/VenditPublicApi/Orders/GetWithDetails/{id}/{(int)details}");
            }

            public Task<long[]> GetAllOrderIds(CancellationToken cancel = default)
            {
                return _client.GetSomething<long[]>(cancel, $"/VenditPublicApi/Orders/GetAllIds");
            }

            // OrderStatus

            public Task<OrderStatus> GetOrderStatus(int statusId, CancellationToken cancel = default)
            {
                return _client.GetSomething<OrderStatus>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/OrderStatuses/");
            }

            public Task<OrderStatus[]> GetOrderStatuses(params int[] ids)
            {
                return GetOrderStatuses(CancellationToken.None, ids);
            }

            public Task<OrderStatus[]> GetOrderStatuses(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<OrderStatus, int>(ids, cancel, "/VenditPublicApi/Lookups/OrderStatuses/");
            }

            public Task<OrderStatus[]> GetAllOrderStatuses(CancellationToken cancel = default)
            {
                return _client.GetAll<OrderStatus>(cancel, "/VenditPublicApi/Lookups/OrderStatuses/");
            }

            public Task UpdateStatus(long orderId, int newOrderStatusId, CancellationToken cancel = default)
            {
                return _client.Put(cancel, $"/VenditPublicApi/Orders/UpdateStatus/{orderId}/{newOrderStatusId}");
            }

            public Task<PaymentLink> GetPaymentLink(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<PaymentLink>(cancel, $"/VenditPublicApi/Orders/GetPaymentUrl/{id}");
            }


            // OrderType

            public Task<OrderType> GetOrderType(int statusId, CancellationToken cancel = default)
            {
                return _client.GetSomething<OrderType>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/OrderTypes/");
            }

            public Task<OrderType[]> GetOrderTypes(params int[] ids)
            {
                return GetOrderTypes(CancellationToken.None, ids);
            }

            public Task<OrderType[]> GetOrderTypes(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<OrderType, int>(ids, cancel, "/VenditPublicApi/Lookups/OrderTypes/");
            }

            public Task<OrderType[]> GetAllOrderTypes(CancellationToken cancel = default)
            {
                return _client.GetAll<OrderType>(cancel, "/VenditPublicApi/Lookups/OrderTypes/");
            }

            // Import

            public Task<EcommerceSettings[]> GetEcommerceSettings()
            {
                return _client.GetSomething<EcommerceSettings[]>(CancellationToken.None, "/VenditPublicApi/Orders/GetEcommerceSettings");
            }

            public Task<OrderImportResult> ImportOrder(OrderImport item, Guid ecommerceSettingsId, CancellationToken cancel = default)
            {
                return _client.PostObj<OrderImportResult>(cancel, $"/VenditPublicApi/Orders/ImportOrder/{ecommerceSettingsId}", item);
            }
        }
    }
}
