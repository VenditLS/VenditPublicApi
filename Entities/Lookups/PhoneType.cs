using System.ComponentModel;
using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class PhoneType
    {
        public int PhoneTypeId { get; set; }
        public string PhoneTypeDescription { get; set; }
        public PhoneKind PhoneKind { get; set; }
        public short? SortOrder { get; set; }
    }

    [Serializable]
    public enum PhoneKind
    {
        [Description("Vaste Lijn")]
        LandLine = 1,
        [Description("Mobiel")]
        Mobile = 2,
        [Description("Fax")]
        Fax = 3,
        [Description("Pieper")]
        Pager = 4
    }
}
