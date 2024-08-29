using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductSalesPrice
    {
        public int ProductSalesPriceId { get; set; }
        public int ProductId { get; set; }
        public int OfficeId { get; set; }
        public bool LockSalesPrice { get; set; }
        public decimal SalesPriceEx { get; set; }
        public decimal SalesPriceMarginProEx { get; set; }
        public decimal MinSalesPriceEx { get; set; }
        public decimal MinSalesPriceMarginProEx { get; set; }
        public decimal RecommendedSalesPriceEx { get; set; }
        public decimal InternetSalesPriceEx { get; set; }
        public decimal InternetSalesPriceMarginProEx { get; set; }
        public decimal MaxDiscountPercent { get; set; }
        public int ProductSizeColorId { get; set; }
        public bool LockMarginProEx { get; set; }
        public decimal? ResaleBonus { get; set; }
        public System.DateTime? ResaleBonusStart { get; set; }
        public System.DateTime? ResaleBonusEnd { get; set; }
    }
}
