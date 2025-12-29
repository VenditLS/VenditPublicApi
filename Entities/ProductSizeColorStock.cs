using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductSizeColorStock
    {
        public string SizeName { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
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

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
        public decimal? PendingProductPurchase { get; set; }

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
        public decimal? OfficeTransferOrder { get; set; }

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
        public decimal? OfficeTransferOrderIn { get; set; }

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
        public decimal? Reserved { get; set; }

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
        public decimal? InfoTotalCustomerOrdered { get; set; }

        /// <summary>
        /// Aggregated per office (not per StockLocation)
        /// </summary>
        public decimal? InfoTotalPurchaseOrdered { get; set; }

        public override string ToString()
        {
            return Stock.ToString();
        }
    }
}
