using System.ComponentModel;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class TradeInFilter : BaseFilter<TradeInFields>
    {
        public TradeInFilter(TradeInFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public TradeInFilter(TradeInFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class TradeInFilters : BaseFilters<TradeInFields, TradeInFilter>
    {
        public TradeInFilters(params TradeInFilter[] filters) : base(filters) { }
    }

    public class TradeInResults : BaseResultsReply<int, TradeIn>
    {
    }

    public class FindTradeIns : FindClientBase<int, TradeInFields>
    {

    }

    public enum TradeInFields
    {
        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Barcode = 201,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BatteryNumber = 214,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BikeImeiNumber = 1000,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrandName = 208,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CertificateNumber = 556,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ColorName = 221,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        DataTagNumber = 1001,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Description = 204,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        DisplayNumber = 215,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        EcommerceExport = 1002,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraInfo1 = 1003,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraInfo2 = 1004,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraInfo3 = 1005,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraInfo4 = 1006,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraInfo5 = 1007,

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
        KeyNumber = 216,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        KeyNumber2 = 1008,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        LastExportDateTime = 1009,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LeaseContractNumber = 1010,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LeaseVehicleNumber = 1011,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LicensePlateMeldcode = 1012,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LicensePlateNumber = 217,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LockNumber = 218,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Memo = 1013,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Mileage = 1014,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ModelYear = 526,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        MotorNumber = 539,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PassportNumber = 209,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        ReadyForSale = 1015,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        SalesPrice = 1016,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SerialNumber = 207,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SizeName = 222,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SubDescription = 206,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        TradeInDateTime = 1017,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        TradeInNumber = 1018,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        TradeInVatProduct = 1019,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        VeloPassNumber = 1020,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        VinNumber = 1021,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        VatType = 1022,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        StockOfficeDetailId = 1023,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PurchaseDetailId = 1024,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SaleDetailId = 1025,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        RepairDetailId = 1026,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PurchaseOrderDetailId = 743,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PurchasePicklistDetailId = 1027,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OrderDetailId = 1028,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OfficeCode = 1029,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OfficeId = 804,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OfficeName = 1030,

        /// <summary>
        /// Type = System.Int16
        /// </summary>
        [Description("Type = Int16")]
        OfficeNumber = 1031,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OfferDetailId = 1032,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        KindId = 1033,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        KindName = 210,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        GroupId = 1034,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Comments = 1035,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        DateOfSale = 802,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        DorExcludeReason = 1036,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        DorId = 1037,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        DorSendError = 1038,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Number = 1039,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        ObtainedDate = 1040,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Title = 1041,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        DorExcludeEmployeeId = 1042,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        DorExcludeEmployeeName = 1043,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        CustomerPickinglistDetailId = 1044,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PurchaseContactId = 1045,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrancheDescription = 1046,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        BrancheId = 1047,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrancheName = 1048,
    }
}
