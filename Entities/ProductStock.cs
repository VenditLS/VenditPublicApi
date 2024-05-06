using System;

namespace VenditPublicSdk.Entities
{
    public class ProductStock
    {
        public int officeId { get; set; }
        public int productId { get; set; }
        public int sizeColorId { get; set; }
        public decimal availableStock { get; set; }
        public decimal pendingProductPurchase { get; set; }
        public decimal officeTransferOrder { get; set; }
        public decimal officeTransferOrderIn { get; set; }
        public decimal reserved { get; set; }
        public decimal infoTotalCustomerOrdered { get; set; }
        public decimal infoTotalPurchaseOrdered { get; set; }
        public decimal productStock { get; set; }
        public DateTime? orderedDate { get; set; }
    }
}
