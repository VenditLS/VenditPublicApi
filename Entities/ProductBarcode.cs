namespace VenditPublicSdk.Entities
{
    public class ProductBarcode
    {
        public int ProductBarcodeId { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
        public int ProductStockDetailId { get; set; }
        public string Barcode { get; set; }
        public bool IsDeleted { get; set; }
        public int SortOrder { get; set; }

        public override string ToString()
        {
            return Barcode;
        }
    }
}
