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

        /// <summary>
        /// The product this barcode belongs to, only populated when
        /// <see cref="GetWithDetails.IncludeProductBarcodeDetails.Product"/> was requested
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// The size/color combination of this barcode, only populated when
        /// <see cref="GetWithDetails.IncludeProductBarcodeDetails.ProductSizeColor"/> was requested
        /// <para>Only the IDs are filled here; the names arrive flattened on this barcode as
        /// <see cref="SizeName"/>, <see cref="ColorName"/> and <see cref="ColorCode"/>.</para>
        /// </summary>
        public ProductSizeColor SizeColor { get; set; }

        /// <summary>
        /// The individual stock item this barcode identifies, only populated when
        /// <see cref="GetWithDetails.IncludeProductBarcodeDetails.ProductStockDetail"/> was requested
        /// </summary>
        public ProductStockDetail ProductStockDetail { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeProductBarcodeDetails.ProductSizeColor"/> was requested
        /// </summary>
        public string SizeName { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeProductBarcodeDetails.ProductSizeColor"/> was requested
        /// </summary>
        public string ColorName { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeProductBarcodeDetails.ProductSizeColor"/> was requested
        /// </summary>
        public string ColorCode { get; set; }

        public override string ToString()
        {
            return Barcode;
        }
    }
}
