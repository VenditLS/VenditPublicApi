using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class SupplierOrder
    {
        public string PurchaseOrderNumber { get; set; }

        public System.DateTime? OrderDatetime { get; set; }

        public int? EmployeeId { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public string OrderRemark { get; set; }

        public int? OrderExpectedDeliveryWeek { get; set; }

        public System.DateTime? OrderExpectedDeliveryDate { get; set; }

        public string SupplierProductNumber { get; set; }

        public int? ProductId { get; set; }

        public int? ProductSizeColorId { get; set; }

        public string ProductNumber { get; set; }

        public string ProductDescription { get; set; }

        public decimal? Amount { get; set; }

        public decimal? BrutoPurchasePriceEx { get; set; }

        public decimal? PurchasePriceEx { get; set; }

        public bool? UseFormula { get; set; }

        public bool? OnetimePurchasePrice { get; set; }

        public string ExtraPriceInfo { get; set; }

        public string AssortmentCode { get; set; }

        public long? ProductPurchaseOrderId { get; set; }

        public int? SupplierId { get; set; }

    }
}
