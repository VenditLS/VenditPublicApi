using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductPurchaseOrder
    {
        public Results<ProductPurchaseOrderDetail> Details { get; set; }
        public long ProductPurchaseOrderId { get; set; }
        public int OfficeId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int SupplierId { get; set; }
        public DateTime OrderDatetime { get; set; }
        public string OrderReference { get; set; }
        public int PreorderEmployeeId { get; set; }
        public int EmployeeId { get; set; }
        public string OnlineOrderReference { get; set; }
        public string OrderRemark { get; set; }
        public int? OrderExpectedDeliveryWeek { get; set; }
        public DateTime? OrderExpectedDeliveryDate { get; set; }

        public override string ToString()
        {
            return $"[{PurchaseOrderNumber}] {OrderDatetime.ToShortDateString()}";
        }
    }

    [Serializable]
    public class ProductPurchaseOrderDetail
    {
        public long ProductPurchaseOrderDetailId { get; set; }
        public long ProductPurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductSizeColorId { get; set; }
        public string SupplierProductNumber { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSubdescription { get; set; }
        public string ProductExtraInfo { get; set; }
        public decimal? Amount { get; set; }
        public decimal PurchasePriceEx { get; set; }
        public bool OnetimePurchasePrice { get; set; }
        public decimal MinOrderQuantity { get; set; }
        public int? ExpectedDeliveryWeek { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public int? WebserviceStatusEnum { get; set; }
        public string OrderDetailRemark { get; set; }
        public string ExtraPriceInfo { get; set; }
        public int Bebat { get; set; }
        public decimal? BrutoPurchasePriceEx { get; set; }
        public bool UseFormula { get; set; }
        public string AssortmentCode { get; set; }
        public int? PromotionProductId { get; set; }
        public Guid LineId { get; set; }
        public decimal AmountDelivered { get; set; }

        public override string ToString()
        {
            return $"{Amount} x [{ProductNumber}] {ProductDescription}";
        }
    }
}
