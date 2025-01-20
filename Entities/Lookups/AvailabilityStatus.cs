using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class AvailabilityStatus
    {
        public int AvailabilityStatusId { get; set; }
        public int LanguageId { get; set; }
        public int DisplayValue { get; set; }
        public string DisplayName { get; set; }
        public bool DefaultOption { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
