using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class HistoryPurchaseHeader
    {
        public Results<HistoryPurchaseDetail> Details { get; set; }
        public long ProductPurchaseHeaderId { get; set; }
        public int OfficeId { get; set; }
        public int SupplierId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DeliveryDatetime { get; set; }
        public string DeliveryDocumentNumber { get; set; }
        public string OrderRemark { get; set; }

        public override string ToString()
        {
            return DeliveryDocumentNumber;
        }
    }

    [Serializable]
    public class HistoryPurchaseDetail
    {
        public long ProductPurchaseDetailId { get; set; }
        public long ProductPurchaseHeaderId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int ProductId { get; set; }
        public int ProductSizeColorId { get; set; }
        public string SupplierProductNumber { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSubdescription { get; set; }
        public string ProductExtraInfo { get; set; }
        public decimal AmountOrdered { get; set; }
        public decimal AmountDelivered { get; set; }
        public decimal PurchasePriceEx { get; set; }
        public bool OnetimePurchasePrice { get; set; }
        public decimal MinOrderQuantity { get; set; }
        public string SerialNumber { get; set; }
        public string FrameNumber { get; set; }
        public string ImeiNumber { get; set; }
        public string ExtraPriceInfo { get; set; }
        public int Bebat { get; set; }
        public decimal? BrutoPurchasePriceEx { get; set; }
        public bool UseFormula { get; set; }
        public long? ProductPurchaseFormulaId { get; set; }
        public int OrderEmployeeId { get; set; }
        public string AssortmentCode { get; set; }
        public int? PromotionProductId { get; set; }
        public string OrderReference { get; set; }
        public DateTime? OrderDatetime { get; set; }
        public string CertificateNumber { get; set; }
        public string OptiplyId { get; set; }

        public override string ToString()
        {
            return $"{ProductNumber} ({SupplierProductNumber}) {AmountDelivered} x {ProductDescription} - {ProductSubdescription}";
        }
    }
}
