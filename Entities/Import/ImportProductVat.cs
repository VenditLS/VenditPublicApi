using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductVat:ProductVat
    {
        public Vat Vat { get; set; }
        public OfficeMinimal Office { get; set; }
    }
}
