using System;

namespace VenditPublicSdk.Entities
{
    public class ProductStock
    {
        public int OfficeId { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
        public decimal AvailableStock { get; set; }
        public decimal PendingProductPurchase { get; set; }
        public decimal OfficeTransferOrder { get; set; }
        public decimal OfficeTransferOrderIn { get; set; }
        public decimal Reserved { get; set; }
        public decimal InfoTotalCustomerOrdered { get; set; }
        public decimal InfoTotalPurchaseOrdered { get; set; }
        public decimal productStock { get; set; }
        public DateTime? OrderedDate { get; set; }

        public override string ToString()
        {
            return $"{AvailableStock} ({productStock})";
        }
    }
}
