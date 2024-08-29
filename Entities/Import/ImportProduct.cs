using System;
using System.Text.RegularExpressions;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Entities.Lookups;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProduct : BaseProduct
    {
        public Group Group { get; set; }
        public Brand Brand { get; set; }
        public Branche Branche { get; set; }
        public AvailabilityStatus AvailabilityStatus { get; set; }
        public ProductKind ProductKind { get; set; }
        public SalesUnit SalesUnit { get; set; }
        public Results<ImportSizeColor> SizeColors { get; set; }
        public Results<ImportProductAttribute> ProductAttributes { get; set; }
        public Results<ProductBarcode> Barcodes { get; set; }
        public Results<ProductActionPrice> ActionPrices { get; set; }
        public Results<ImportProductSupplier> Suppliers { get; set; }
        public Results<ImportProductVat> ProductVats { get; set; }
        public Results<ImportProductSalesPrice> SalesPrices { get; set; }
    }
}
