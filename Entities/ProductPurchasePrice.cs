using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductPurchasePrice
    {
        public int ProductPurchasePriceId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int OfficeId { get; set; }
        public decimal PurchasePriceEx { get; set; }
        public int ProductSizeColorId { get; set; }
        public decimal? BrutoPurchasePriceEx { get; set; }
        public decimal? PaymentDiscount { get; set; }

        public override string ToString()
        {
            return PurchasePriceEx.ToString("N2");
        }
    }
}
