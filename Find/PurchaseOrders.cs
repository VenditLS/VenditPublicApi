using System.ComponentModel;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class PurchaseOrderFilter : BaseFilter<PurchaseOrderFields>
    {
        public PurchaseOrderFilter(PurchaseOrderFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public PurchaseOrderFilter(PurchaseOrderFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class PurchaseOrderFilters : BaseFilters<PurchaseOrderFields, PurchaseOrderFilter>
    {
        public PurchaseOrderFilters(params PurchaseOrderFilter[] filters) : base(filters) { }
    }

    public class PurchaseOrderResults : BaseResultsReply<int, ProductPurchaseOrder>
    {
    }

    public class FindPurchaseOrders : FindClientBase<int, PurchaseOrderFields>
    {
    }

    public enum PurchaseOrderFields
    {
        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        ExpectedDeliveryDate = 401,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ExpectedDeliveryWeek = 731,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OfficeId = 804,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OnlineOrderReference = 732,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        OrderDateTime = 200,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderReference = 733,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PurchaseOrderNumber = 154,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Remark = 734,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GlnNumber = 701,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SupplierId = 706,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierName = 213,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierNumber = 703,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CertificateNumber = 556,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraPriceInfo = 735,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        FrameNumber = 202,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ImeiNumber = 203,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderDetailRemark = 736,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductDescription = 204,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        ProductExpectedDeliveryDate = 737,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ProductExpectedDeliveryWeek = 738,

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
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductNumber = 205,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductSubDescription = 206,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductType = 211,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        PurchaseOrderDetailId = 743,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        Quantity = 406,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        QuantityDelivered = 740,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SerialNumber = 207,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierProductNumber = 544,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        EmployeeId = 155,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        EmployeeName = 152,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PreorderEmployeeId = 741,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PreorderEmployeeName = 742,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SizeColorId = 553,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ColorCode = 508,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ColorId = 554,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ColorName = 221,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SizeId = 555,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SizeName = 222,
    }
}
