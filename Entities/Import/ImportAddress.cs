using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportAddress:Address
    {
        public new Results<ImportContact> Contacts { get; set; }
    }
}
