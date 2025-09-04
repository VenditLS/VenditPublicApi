using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class PrePurchaseOrder
    {
        public long ProductPreorderId { get; set; }
        public bool IsManual { get; set; }
        public int OfficeId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public int ProductSizeColorId { get; set; }
        public string SupplierProductNumber { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSubdescription { get; set; }
        public string ProductExtraInfo { get; set; }
        public int? TargetSupplierId { get; set; }
        public int? TargetOfficeId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PurchasePriceEx { get; set; }
        public bool OnetimePurchasePrice { get; set; }
        public string OrderReference { get; set; }
        public decimal MinOrderQuantity { get; set; }
        public int? ExpectedDeliveryWeek { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string ExtraPriceInfo { get; set; }
        public int Bebat { get; set; }
        public decimal? BrutoPurchasePriceEx { get; set; }
        public bool UseFormula { get; set; }
        public int? PromotionProductId { get; set; }
        public bool OrderAutomatically { get; set; }
        public Guid? LineId { get; set; }
        public DateTime? CreationDatetime { get; set; }
        public string SerialNumber { get; set; }
        public string FrameNumber { get; set; }
        public string ImeiNumber { get; set; }
        public string CertificateNumber { get; set; }
        public string OptiplyId { get; set; }
    }
}
