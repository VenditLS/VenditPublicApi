using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportCustomer:Customer
    {
        public Results<ImportAddress> Addresses { get; set; }
}
}
