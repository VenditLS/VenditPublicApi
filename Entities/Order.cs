using System;
using System.ComponentModel;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Order
    {
        public long CustomerOrderHeaderId { get; set; }
        public Results<CustomerOrderDetail> OrderDetails { get; set; }
        public int CustomerId { get; set; }
        public int OfficeId { get; set; }
        public int EmployeeId { get; set; }
        public int? PlanningId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public System.DateTime CreationDatetime { get; set; }
        public int OrderTypeId { get; set; }
        public int OrderPriorityId { get; set; }
        public System.DateTime? DeliveryDate { get; set; }
        public System.DateTime ActivationDate { get; set; }
        public int OrderStatusId { get; set; }
        public bool PartialDeliveryNotification { get; set; }
        public bool CompleteDelivery { get; set; }
        public DeliveryCommunicationType? DeliveryNotificationType { get; set; }
        public bool PartialCompletedOnly { get; set; }
        public int InvoiceAddressId { get; set; }
        public int InvoiceContactId { get; set; }
        public int DeliveryAddressId { get; set; }
        public int DeliveryContactId { get; set; }
        public int JournalId { get; set; }
        public OrderStockStatusEnum StockStatusEnum { get; set; }
        public bool SaleExVat { get; set; }
        public int TurnoverEmployeeId { get; set; }
        public decimal? InvoiceDiscountPercentage { get; set; }
        public decimal? InvoiceDiscountAmount { get; set; }
        public bool? DiscountIsPercentage { get; set; }
        public string BaselineReferenceNumber { get; set; }
        public string OrderLabelNumber { get; set; }
        public System.DateTime OrderStatusDate { get; set; }
        public string OrderStatusDateStr { get; set; }
        public string OrderStatusDateFormat { get; set; }
        public string OrderSubTitle { get; set; }
        public System.Guid? EcommerceWebsiteGuid { get; set; }
        public int InvoiceDebitCustomerId { get; set; }
        public string TelecomReferenceNumber { get; set; }
        public int? OriginalWorkstationId { get; set; }
        public int? OriginalDrawerId { get; set; }
        public bool IsEcommerce { get; set; }
        public string InternalMemo { get; set; }
        public int? StatusEmployeeId { get; set; }
        public string Url { get; set; }
        public int? DropshipmentType { get; set; }
        public string IntersolveLiabCardnumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public bool? IntersolveLiabViaZipcode { get; set; }
        public string OrderOrigin { get; set; }
        public OrderPickListStatusEnum PickStatusEnum { get; set; }
        public Results<OrderDownpayment> DownPayments { get; set; }

    }

    [Serializable]
    public class CustomerOrderDetail
    {
        public long CustomerOrderDetailId { get; set; }
        public long CustomerOrderHeaderId { get; set; }
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
        public decimal ProductTotalDiscountEx { get; set; }
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
        public int? PreorderId { get; set; }
        public int SortOrder { get; set; }
        public string ProductKindDescription { get; set; }
        public int? BrancheId { get; set; }
        public DetailStockStatusEnum StockStatusEnum { get; set; }
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
        public bool? OverruleAvailabilityStatus { get; set; }
        public int StockLocationId { get; set; }
        public decimal ProductQuantityDelivered { get; set; }
        public int ServiceCategoryId { get; set; }
        public string PassportNumber { get; set; }
        public int? TradeInOfficeId { get; set; }
        public string EvoucherToken { get; set; }
        public int? EvoucherEnum { get; set; }
        public int StockOfficeId { get; set; }
        public string DisplayNumber { get; set; }
        public string BatteryNumber { get; set; }
        public string ExtraOrderInformation { get; set; }
        public bool? OrderDetailActive { get; set; }
        public int Bebat { get; set; }
        public decimal? TradeInSalePrice { get; set; }
        public int? ExtraProductCostsId { get; set; }
        public string ExtraProductCostsGroupGuid { get; set; }
        public int? ReturnFromSaleDetailId { get; set; }
        public bool WebserviceProcessed { get; set; }
        public decimal ReportPurchasePriceEx { get; set; }
        public decimal ReportPurchasePriceInc { get; set; }
        public decimal ReportTotalVatAmount { get; set; }
        public decimal ReportTotalMarginProEx { get; set; }
        public decimal ReportTotalMarginEx { get; set; }
        public string AssortmentCode { get; set; }
        public int Warranty { get; set; }
        public bool TradeInVatProduct { get; set; }
        public decimal ProductQuantityTranssmart { get; set; }
        public string Mileage { get; set; }
        public decimal? ResaleBonus { get; set; }
        public int? TradeInVatType { get; set; }
        public int? CombinationDiscountId { get; set; }
        public decimal? CombinationDiscountQuantity { get; set; }
        public decimal TotalDiscountInc { get; set; }
        public string PurchasefromIdentificationNumber { get; set; }
        public int? PurchasefromDorIdentificationId { get; set; }
        public int? PurchasefromDorCountryId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public decimal? PurchaseOrderAmount { get; set; }
        public bool? IsUnitProduct { get; set; }
        public System.Guid? UnitGuid { get; set; }
        public int? RegisteredDiscountType { get; set; }
        public System.Guid? CopyLevyGuid { get; set; }
        public bool? IsCopyLevy { get; set; }
        public bool? IsDropshipment { get; set; }
        public string LeaseContractNumber { get; set; }
        public string LeaseVehicleNumber { get; set; }
        public decimal? PurchasePriceEx { get; set; }
        public int? LeaseProviderId { get; set; }
        public string KeyNumber2 { get; set; }
        public string BikeImeiNumber { get; set; }
        public string VinNumber { get; set; }
        public long Orderpicklistid { get; set; }
        public string VelopassNumber { get; set; }
        public decimal ScannedQuantity { get; set; }
        public string Barcode { get; set; }
        public string StorageName { get; set; }
        public string OrderNumber { get; set; }

    }

    [Serializable]
    public class OrderDownpayment
    {
        public long OrderDownPaymentId { get; set; }
        public long CustomerOrderHeaderId { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal RestAmount { get; set; }
        public int PaymentCodeId { get; set; }
        public System.DateTime? ProcessingDate { get; set; }
        public int PaymentTypeId { get; set; }
    }

    [Serializable]
    public enum DeliveryCommunicationType
    {
        [Description("SMS")]
        SMS = 1,
        [Description("E-mail")]
        Email = 2,
        [Description("Telefonisch")]
        Phone = 3,
        [Description("Fax")]
        Fax = 4
    }

    /// <summary>
    /// Used on Customer Order Header
    /// </summary>
    [Serializable]
    public enum OrderStockStatusEnum
    {
        /// <summary>
        /// Geen voorraad
        /// </summary>
        [Description("Geen voorraad")]
        NoStock = 0,

        /// <summary>
        /// Gedeeltelijk op voorraad
        /// </summary>
        [Description("Gedeeltelijk op voorraad")]
        PartialInStock = 1,

        /// <summary>
        /// Op voorraad
        /// </summary>
        [Description("Op voorraad")]
        InStock = 2,

        /// <summary>
        /// Niet geactiveerd
        /// </summary>
        [Description("Niet geactiveerd")]
        NotActivated = 3,
    }

    /// <summary>
    /// Used on Order Details
    /// </summary>
    [Serializable]
    public enum DetailStockStatusEnum
    {
        /// <summary>
        /// Onbekend
        /// </summary>
        [Description("Onbekend")]
        Error = 0, // Error occured

        /// <summary>
        /// OK
        /// </summary>
        [Description("OK")]
        OK = 1, // No stock product

        /// <summary>
        /// Geen voorraad
        /// </summary>
        [Description("Geen voorraad")]
        NoStock = 2, // Red: No Stock, nothing reserved

        /// <summary>
        /// Gedeeltelijk op voorraad
        /// </summary>
        [Description("Gedeeltelijk op voorraad")]
        PartialInStock = 3, // Yellow: Partially Reserved/ready

        /// <summary>
        /// Op voorraad
        /// </summary>
        [Description("Op voorraad")]
        InStock = 4, // Green: All reserved or enough stock

        /// <summary>
        /// Niet geactiveerd
        /// </summary>
        [Description("Niet geactiveerd")]
        NotActivated = 5 // Blue: Not activated
    }

    [Serializable]
    public enum OrderPickListStatusEnum : int
    {
        Canceled   = 0,
        New        = 1,
        Processing = 2,
        Completed  = 3
    }
}
