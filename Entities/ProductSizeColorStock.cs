using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductSizeColorStock
    {
        public string SizeName { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public decimal? Stock { get; set; }
        public decimal? AvailableStock { get; set; }
        public string LocationName { get; set; }
        public string StorageName { get; set; }
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int ProductSizeColorId { get; set; }
        public int ProductStockId { get; set; }
        public int StockLocationId { get; set; }
        public int StorageLocationId { get; set; }
        public int OfficeId { get; set; }
        public int ProductId { get; set; }

        public override string ToString()
        {
            return Stock.ToString();
        }
    }
}
