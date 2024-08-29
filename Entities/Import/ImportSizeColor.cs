using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportSizeColor
    {
        public int ProductSizeColorId { get; set; }
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public bool IsDeleted { get; set; }

        public Size Size { get; set; }
        public Color Color { get; set; }

        public Results<ProductBarcode> Barcodes { get; set; }
        public Results<ProductActionPrice> ActionPrices { get; set; }
        public Results<ImportProductSalesPrice> SalesPrices { get; set; }
    }
}
