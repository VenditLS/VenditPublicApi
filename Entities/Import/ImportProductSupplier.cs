using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductSupplier: ProductSupplier
    {
        public new ImportSupplier Supplier { get; set; }
        public new OfficeMinimal  Office   { get; set; }
    }
}
