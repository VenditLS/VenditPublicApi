using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class SaleDetail
    {
        public string ActionPriceIndicatorText { get; set; }
        public string DiscountCalculationIndication { get; set; }
        public LockFields LockFlags { get; set; }
        public bool BlockCombinationDiscount { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int SaleDetailId { get; set; }
        public int SaleHeaderId { get; set; }
        public int ProductId { get; set; }
        public decimal ProductQuantity { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductKindDescription { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSubdescription { get; set; }
        public string BrancheName { get; set; }
        public int ProductGroupId { get; set; }
        public string BrandName { get; set; }
        public string ProductColorCode { get; set; }
        public string ProductColorName { get; set; }
        public string ProductSizeName { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierName { get; set; }
        public string FrameNumber { get; set; }
        public string LockNumber { get; set; }
        public string KeyNumber { get; set; }
        public string DataTagNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ImeiNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public decimal ProductPurchasePriceEx { get; set; }
        public decimal ProductPurchasePriceInc { get; set; }
        public decimal ProductSalesPriceEx { get; set; }
        public decimal ProductSalesPriceInc { get; set; }
        public decimal ProductVatPercentage { get; set; }
        public string ProductVatDescription { get; set; }
        public decimal ProductTotalVatAmount { get; set; }
        public decimal ProductTotalSalesPriceEx { get; set; }
        public decimal ProductTotalSalesPriceInc { get; set; }
        public decimal ProductTotalDiscountEx { get; set; }
        public decimal ProductTotalDiscountProEx { get; set; }
        public decimal ProductTotalDiscountInc { get; set; }
        public decimal ProductTotalDiscountProInc { get; set; }
        public decimal ProductTotalMarginProEx { get; set; }
        public decimal ProductTotalMarginEx { get; set; }
        public decimal ProductTotalMarginProInc { get; set; }
        public decimal ProductTotalMarginInc { get; set; }
        public TradeInEnum TradeIn { get; set; }
        public int? VatId { get; set; }
        public int? ProductSizeColorId { get; set; }
        public string LicensePlateMeldcode { get; set; }
        public string MotorNumber { get; set; }
        public int TurnoverEmployeeId { get; set; }
        public decimal InvoiceDiscountEx { get; set; }
        public decimal InvoiceDiscountInc { get; set; }
        public int BrancheId { get; set; }
        public int LinkId { get; set; }
        public int ExportBit { get; set; }
        public decimal ProcessedSalePriceIncForVat { get; set; }
        public bool IsTelecomLink { get; set; }
        public int ProductSetId { get; set; }
        public int? DosImportId { get; set; }
        public string PassportNumber { get; set; }
        public int ServiceCategoryId { get; set; }
        public int StockOfficeId { get; set; }
        public bool? DamageReportClaimSelected { get; set; }
        public int? ReturnFromSaleDetailId { get; set; }
        public string BatteryNumber { get; set; }
        public string DisplayNumber { get; set; }
        public string ExtraOrderInformation { get; set; }
        public int Bebat { get; set; }
        public int? ExtraProductCostsId { get; set; }
        public string ExtraProductCostsGroupGuid { get; set; }
        public string CustomerOrderNumber { get; set; }
        public System.DateTime? CustomerOrderCreationDatetime { get; set; }
        public System.DateTime? OrderTurnoverDatetime { get; set; }
        public string AssortmentCode { get; set; }
        public int Warranty { get; set; }
        public bool TradeInVatProduct { get; set; }
        public string Mileage { get; set; }
        public decimal? ResaleBonus { get; set; }
        public TradeInVatTypeEnum? TradeInVatType { get; set; }
        public int? CombinationDiscountId { get; set; }
        public decimal? CombinationDiscountQuantity { get; set; }
        public bool? IsUnitProduct { get; set; }
        public System.Guid? UnitGuid { get; set; }
        public string ExtraRemark { get; set; }
        public int? RegisteredDiscountType { get; set; }
        public string LeaseContractNumber { get; set; }
        public string LeaseVehicleNumber { get; set; }
        public string Barcode { get; set; }
        public int ProductStockDetailId { get; set; }
        public string OriginalSearchPhrase { get; set; }
        public bool OriginalSearchSingleProductResult { get; set; }

        public override string ToString()
        {
            return $"{ProductQuantity} x [{ProductNumber}] {ProductDescription}";
        }
    }

    [Serializable]
    public enum TradeInEnum
    {
        None     = 0,
        Purchase = 1,
        Sale     = 2
    }

    [Serializable]
    public enum TradeInVatTypeEnum
    {
        None    = -1,
        Nul     = 0,
        LowVat  = 1,
        HighVat = 2
    }

    [Serializable]
    [Flags]
    public enum LockFields : uint
    {
        None                 = 0,
        All                  = uint.MaxValue,
        IsScannedFreeProduct = 1, 
        DiscountPrice      = 4,
        DiscountPercentage = 8,
        ProductPrice = 16,
        CustomerFixedPrice = 32,
        PredeterminedProductPrice = 64,
        FreeProduct = 128,
        LoadedPreExisting = 256,
    }
}
