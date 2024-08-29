using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductSalesPrice:ProductSalesPrice
    {
        public OfficeMinimal Office { get; set; }
    }
}
