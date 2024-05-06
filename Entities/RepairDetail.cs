using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairDetail
    {
        public int RepairDetailId { get; set; }

        public int RepairHeaderId { get; set; }

        public int BrancheId { get; set; }

        public int ProductGroupId { get; set; }

        public int ProductId { get; set; }

        public int ProductSizeColorId { get; set; }

        public string ProductNumber { get; set; }

        public string ProductType { get; set; }

        public string ProductKindDescription { get; set; }

        public string ProductDescription { get; set; }

        public string ProductSubdescription { get; set; }

        public int? BrandId { get; set; }

        public string ProductColorCode { get; set; }

        public string ProductColorName { get; set; }

        public string ProductSizeName { get; set; }

        public decimal ProductQuantity { get; set; }

        public decimal ProductSalesPriceEx { get; set; }

        public decimal ProductSalesPriceWithVat { get; set; }

        public decimal ProductTotalDiscountEx { get; set; }

        public decimal ProductTotalDiscountProEx { get; set; }

        public decimal TotalSalesPriceEx { get; set; }

        public decimal TotalSalesPriceWithVat { get; set; }

        public decimal TotalSalesPriceInc { get; set; }

        public int VatId { get; set; }

        public string FrameNumber { get; set; }

        public string LockNumber { get; set; }

        public string KeyNumber { get; set; }

        public string DataTagNumber { get; set; }

        public string SerialNumber { get; set; }

        public string ImeiNumber { get; set; }

        public int TradeIn { get; set; }

        public int TradeInId { get; set; }

        public System.DateTime? TradeInDatetime { get; set; }

        public string TradeInIdNumber { get; set; }

        public decimal? TradeInPurchasePrice { get; set; }

        public int SortOrder { get; set; }

        public string MotorNumber { get; set; }

        public string LicensePlateNumber { get; set; }

        public string LicensePlateMeldcode { get; set; }

        public int StockStatusEnum { get; set; }

        public int? PreorderId { get; set; }

        public int TurnoverEmployeeId { get; set; }

        public decimal? InvoiceDiscountEx { get; set; }

        public decimal? InvoiceDiscountInc { get; set; }

        public int LinkId { get; set; }

        public string TradeInMemo { get; set; }

        public int ProductSetId { get; set; }

        public bool? OverruleAvailabilityStatus { get; set; }

        public int ServiceCategoryId { get; set; }

        public string PassportNumber { get; set; }

        public decimal? ProductPurchasePriceEx { get; set; }

        public int? TradeInOfficeId { get; set; }

        public bool DamageReportClaimSelected { get; set; }

        public string BatteryNumber { get; set; }

        public string DisplayNumber { get; set; }

        public int? StockOfficeId { get; set; }

        public int Bebat { get; set; }

        public int? ExtraProductCostsId { get; set; }

        public string ExtraProductCostsGroupGuid { get; set; }

        public bool WebserviceProcessed { get; set; }

        public bool TradeInVatProduct { get; set; }

        public bool PreorderProcessed { get; set; }

        public int? TradeInVatType { get; set; }

        public string ExtraOrderInformation { get; set; }

        public string LeaseContractNumber { get; set; }

        public string LeaseVehicleNumber { get; set; }

        public System.Guid? CopyLevyGuid { get; set; }

        public bool IsCopyLevy { get; set; }

        public string LeaseTaskCodeLink { get; set; }

        public int? StockLocationId { get; set; }

        public string KeyNumber2 { get; set; }

        public string BikeImeiNumber { get; set; }

        public string VinNumber { get; set; }

        public string VelopassNumber { get; set; }

    }
}
