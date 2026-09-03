using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductVat:ProductVat
    {
        public OfficeMinimal Office { get; set; }
    }
}
