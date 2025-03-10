using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductSupplier: ProductSupplier
    {
        public ImportSupplier Supplier { get; set; }
        public OfficeMinimal  Office   { get; set; }
    }
}
