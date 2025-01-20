using System;
using System.ComponentModel;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Offer
    {
        public long CustomerOfferHeaderId { get; set; }
        public Results<OfferDetail> OfferDetails { get; set; }
        public int CustomerId { get; set; }
        public int OfficeId { get; set; }
        public int EmployeeId { get; set; }
        public string CustomerOfferNumber { get; set; }
        public System.DateTime CreationDatetime { get; set; }
        public int OfferStatusId { get; set; }
        public System.DateTime DateValidTo { get; set; }
        public string OfferIntroText { get; set; }
        public int? ShowAmountsEnum { get; set; }
        public int InvoiceAddressId { get; set; }
        public int InvoiceContactId { get; set; }
        public int DeliveryAddressId { get; set; }
        public int DeliveryContactId { get; set; }
        public bool SaleExVat { get; set; }
        public int TurnoverEmployeeId { get; set; }
        public decimal? InvoiceDiscountPercentage { get; set; }
        public decimal? InvoiceDiscountAmount { get; set; }
        public bool? DiscountIsPercentage { get; set; }
        public string BaselineReferenceNumber { get; set; }
        public int InvoiceDebitCustomerId { get; set; }
        public string TelecomReferenceNumber { get; set; }

        public override string ToString()
        {
            return $"[{CustomerOfferNumber}] {CreationDatetime.ToShortDateString()}";
        }
    }

    [Serializable]
    public class OfferDetail
    {
        public long CustomerOfferDetailId { get; set; }
        public long CustomerOfferHeaderId { get; set; }
        public int ProductId { get; set; }
        public int ProductSizeColorId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSubdescription { get; set; }
        public int ProductGroupId { get; set; }
        public int BrandId { get; set; }
        public string ProductColorCode { get; set; }
        public string ProductColorName { get; set; }
        public string ProductSizeName { get; set; }
        public decimal ProductQuantity { get; set; }
        public decimal ProductSalesPriceEx { get; set; }
        public decimal ProductSalesPriceInc { get; set; }
        public decimal ProductTotalDiscountEx { get; set; }
        public decimal ProductTotalDiscountInc { get; set; }
        public decimal ProductTotalDiscountProEx { get; set; }
        public decimal ProductTotalSalesPriceEx { get; set; }
        public decimal ProductTotalSalesPriceInc { get; set; }
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
        public decimal? TradeInPurchasePrice { get; set; }
        public int SortOrder { get; set; }
        public string ProductKindDescription { get; set; }
        public int? BrancheId { get; set; }
        public string LicensePlateNumber { get; set; }
        public string LicensePlateMeldcode { get; set; }
        public string MotorNumber { get; set; }
        public int TurnoverEmployeeId { get; set; }
        public decimal? InvoiceDiscountEx { get; set; }
        public decimal? InvoiceDiscountInc { get; set; }
        public int LinkId { get; set; }
        public string TradeInIdNumber { get; set; }
        public string BrandName { get; set; }
        public string TradeInMemo { get; set; }
        public bool IsTelecomLink { get; set; }
        public int ProductSetId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string PassportNumber { get; set; }
        public int? TradeInOfficeId { get; set; }
        public int StockOfficeId { get; set; }
        public string DisplayNumber { get; set; }
        public string BatteryNumber { get; set; }
        public string ExtraOrderInformation { get; set; }
        public int Bebat { get; set; }
        public int? ExtraProductCostsId { get; set; }
        public string ExtraProductCostsGroupGuid { get; set; }
        public decimal TradeInSalePrice { get; set; }
        public string AssortmentCode { get; set; }
        public int Warranty { get; set; }
        public bool TradeInVatProduct { get; set; }
        public string Mileage { get; set; }
        public decimal? ResaleBonus { get; set; }
        public int? TradeInVatType { get; set; }
        public int? CombinationDiscountId { get; set; }
        public decimal? CombinationDiscountQuantity { get; set; }
        public bool? IsUnitProduct { get; set; }
        public string UnitGuid { get; set; }
        public int? RegisteredDiscountType { get; set; }
        public string LeaseContractNumber { get; set; }
        public string LeaseVehicleNumber { get; set; }
        public System.Guid? CopyLevyGuid { get; set; }
        public bool IsCopyLevy { get; set; }
        public bool IsDropshipment { get; set; }
        public long DorId { get; set; }
        public string KeyNumber2 { get; set; }
        public string BikeImeiNumber { get; set; }
        public string VinNumber { get; set; }
        public string VelopassNumber { get; set; }
        public decimal? ReservedAmount { get; set; }

        public override string ToString()
        {
            return $"{ProductQuantity} x [{ProductNumber}] {ProductDescription}";
        }
    }

    [Serializable]
    public class OfferStatus
    {
        public int OfferStatusId { get; set; }
        public string StatusDescription { get; set; }
        public OfferStatusEnum EnumValue { get; set; }
        public bool Fixed { get; set; }
        public short SortOrder { get; set; }
    }

    public enum OfferStatusEnum
    {
        /// <summary>
        /// Onbekend
        /// </summary>
        [Description("<onbekend>")]
        None = 0,

        /// <summary>
        /// Lopend
        /// </summary>
        [Description("Lopend")]
        Active = 1,

        /// <summary>
        /// Klant gebeld
        /// </summary>
        [Description("Klant gebeld")]
        CustomerCalled = 2,

        /// <summary>
        /// Klant akkoord
        /// </summary>
        [Description("Klant akkoord")]
        CustomerAccepted = 3,

        /// <summary>
        /// Afgesloten
        /// </summary>
        [Description("Afgesloten")]
        Closed = 4
    }
}