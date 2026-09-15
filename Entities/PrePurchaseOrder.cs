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

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePrePurchaseOrderDetails.Office"/> was requested
        /// </summary>
        public Office Office { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePrePurchaseOrderDetails.Employee"/> was requested
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePrePurchaseOrderDetails.Product"/> was requested
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePrePurchaseOrderDetails.ProductSizeColor"/> was
        /// requested and <see cref="ProductSizeColorId"/> is not 0 (0 means the product has no size/color variations)
        /// </summary>
        public ProductSizeColor ProductSizeColor { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePrePurchaseOrderDetails.TargetSupplier"/> was requested
        /// </summary>
        public Supplier TargetSupplier { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePrePurchaseOrderDetails.TargetOffice"/> was requested
        /// </summary>
        public Office TargetOffice { get; set; }
    }
}
