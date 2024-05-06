using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class ProductFilter : BaseFilter<ProductFields>
    {
        public ProductFilter(ProductFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public ProductFilter(ProductFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class ProductFilters : BaseFilters<ProductFields, ProductFilter>
    {
        public ProductFilters(params ProductFilter[] filters) : base(filters) { }
    }

    public class ProductResults : BaseResultsReply<int>
    {
    }

    public class FindProducts : FindClientBase<int, ProductFields>
    {

    }

    public enum ProductFields
    {
        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        ActionDiscountPercentage = 500,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        ActionSalesPriceExVat = 501,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        AllowInvoiceDiscount = 502,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        AssortmentCode = 503,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        AvailabilityStatus = 504,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        AvailableStock = 506,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Barcode = 201,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        Bebat = 507,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrandName = 208,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Color = 221,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ColorCode = 508,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        CreationDatetime = 200,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        DeliveryFromWarehouse = 509,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        DisallowDiscount = 510,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraDescription1 = 511,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraDescription2 = 512,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraDescription3 = 513,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraDescription4 = 514,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraDescription5 = 515,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupDescription = 219,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupDescription1 = 516,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupDescription2 = 517,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupDescription3 = 518,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupDescription4 = 519,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupDescription5 = 520,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GroupNumber = 220,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        InternetSalesPriceEx = 521,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        IsBaseProduct = 522,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        IsEcommerceProduct = 523,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        KindDescription = 210,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        LastModified = 524,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        MinSalesPriceEx = 525,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ModelYear = 526,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        OtherOfficeStock = 527,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductDescription = 204,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductNumber = 205,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductSubdescription = 206,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductType = 211,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PurchaseFromWarehouse = 528,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        PurchasePriceEx = 529,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        RecommendedSalesPriceEx = 530,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        SalesPriceEx = 531,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SalesVisibilityDescription = 532,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SalesVisibilityValue = 533,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Size = 222,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SizeSortOrder = 534,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        Stock = 535,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        StockCustomerOrdered = 536,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailBatteryNumber = 214,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailDataTagNumber = 537,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailDisplayNumber = 215,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailFrameNumber = 202,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailImeiNumber = 203,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailKeyNumber = 216,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailLicensePlateMeldcode = 538,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailLicensePlateNumber = 217,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailLockNumber = 218,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailMotorNumber = 539,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailPassportNumber = 209,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailRemark = 540,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StockDetailSerialNumber = 207,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        StockPurchaseOrdered = 541,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        StockReserved = 542,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StorageLocationName = 543,

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
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierStock = 545,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        TotalCustomerOrdered = 546,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        TotalPurchaseOrdered = 547,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        TotalWarehouseStock = 548,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        UseStock = 549,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        VatPercent = 550,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ViaCollectionWarehouse = 551,


        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SizeColorId = 553,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ColorId = 554,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SizeId = 555,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ActionDiscountId = 558,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        AvailabilityStatusId = 559,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        BarcodeId = 560,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        BrancheId = 1047,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        BrandId = 561,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        GroupId = 1034,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ProductKindId = 562,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SalesVisibilityId = 563,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        StockDetailId = 564,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        SupplierId = 706,
    }
}
