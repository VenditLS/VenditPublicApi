using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportAddress:Address
    {
        public Results<ImportContact> Contacts { get; set; }
    }
}
