using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class HistoryPurchaseOrderFilter : BaseFilter<HistoryPurchaseOrderFields>
    {
        public HistoryPurchaseOrderFilter(HistoryPurchaseOrderFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public HistoryPurchaseOrderFilter(HistoryPurchaseOrderFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class HistoryPurchaseOrderFilters : BaseFilters<HistoryPurchaseOrderFields, HistoryPurchaseOrderFilter>
    {
        public HistoryPurchaseOrderFilters(params HistoryPurchaseOrderFilter[] filters) : base(filters) { }
    }

    public class HistoryPurchaseOrderResults : BaseResultsReply<int>
    {
    }

    public class FindHistoryPurchaseOrders : FindClientBase<int, HistoryPurchaseOrderFields>
    {
    }

    public enum HistoryPurchaseOrderFields
    {
        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OfficeId = 804,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        OrderDateTime = 200,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        DeliveryDateTime = 401,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PurchaseOrderNumber = 154,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        EmployeeId = 155,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OrderEmployeeId = 156,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        EmployeeName = 152,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductNumber = 205,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierName = 213,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierProductNumber = 544,

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
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GlnNumber = 701,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierNumber = 703,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SupplierId = 706,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        DeliveryDocumentNumber = 709,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderReference = 733,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderRemark = 734,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        HistoryPurchaseDetailId = 743,
    }
}
