using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportSupplier:Supplier
    {
        public new Results<ImportAddress> Addresses { get; set; }
    }
}
