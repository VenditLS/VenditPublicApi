using System.ComponentModel;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class StockOfficeTransferHistoryFilter : BaseFilter<StockOfficeTransferFields>
    {
        public StockOfficeTransferHistoryFilter(StockOfficeTransferFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public StockOfficeTransferHistoryFilter(StockOfficeTransferFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class StockOfficeTransferHistoryFilters : BaseFilters<StockOfficeTransferFields, StockOfficeTransferHistoryFilter>
    {
        public StockOfficeTransferHistoryFilters(params StockOfficeTransferHistoryFilter[] filters) : base(filters) { }
    }

    public class StockOfficeTransferHistoryResults : BaseResultsReply<int, StockOfficeTransfer>
    {
    }

    public class FindStockOfficeTransferHistorys : FindClientBase<int, StockOfficeTransferFields>
    {

    }

    public enum StockOfficeTransferFields
    {
        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CustomerOrderNumber = 154,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        CustomerPickinglistHeaderId = 1049,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        TransferDateTime = 1120,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        ProcessDateTime = 1121,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        SaleHeaderId = 800,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        TransferNumber = 1110,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        TransferStatus = 1111,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        CustomerOrderDetailId = 705,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        CustomerPickinglistDetailId = 1044,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductExtraInfo = 739,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ProductId = 552,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ProductSizeColorId = 553,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        QuantityReceived = 740,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        QuantitySent = 406,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Remark = 734,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SaleDetailId = 1025,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        StockLocationIdFrom = 1231,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        StockLocationIdTo = 1232,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        StockOfficeTransferDetailHistoryId = 1200,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        TradeInId = 1000,
    }
}
