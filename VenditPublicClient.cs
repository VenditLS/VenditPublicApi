using Microsoft.Extensions.Logging;
using System;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        /// <summary>
        /// Recommended constructor
        /// </summary>
        public VenditPublicClient(VenditPublicClientSettings settings, ILogger logger = null) : base(settings, logger)
        {
            HookupSections();
        }

        /// <summary>
        /// For users who persist the token in private database
        /// </summary>
        public VenditPublicClient(string apiKey, string token, DateTime tokenExpire, ILogger logger = null) : base(apiKey, token, tokenExpire, logger)
        {
            HookupSections();
        }

        /// <summary>
        /// For convenience, your requests will be faster if you preserve the token.
        /// <para>
        /// The token and its expiration will be available in the Settings property after the first request.
        /// We recommend persisting the whole VenditPublicClientSettings object and using the constructor that accepts it.
        /// </para>
        /// </summary>
        public VenditPublicClient(string apiKey, string userName, string password, ILogger logger = null) : base(apiKey, userName, password, logger)
        {
            HookupSections();
        }

        private void HookupSections()
        {
            Company = new CompanySection(this);
            Customers = new CustomersSection(this);
            Offers = new OffersSection(this);
            Orders = new OrdersSection(this);
            Products = new ProductsSection(this);
            PurchaseOrders = new PurchaseOrdersSection(this);
            Repairs = new RepairsSection(this);
            Suppliers = new SuppliersSection(this);
            TradeIns = new TradeInsSection(this);
            Transactions = new TransactionsSection(this);
            StockOfficeTransfers = new StockOfficeTransferSection(this);
            ProductStocks = new ProductStockSection(this);
        }
    }
}
