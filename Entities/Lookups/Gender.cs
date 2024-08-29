using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class Gender
    {
        public int SexId { get; set; }
        public int LanguageId { get; set; }
        public string DisplayName { get; set; }
    }
}
