using System;
using VenditPublicSdk.Entities.Lookups;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneTypeId { get; set; }
        public bool DefaultPhone { get; set; }
        public string DialingCode { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludePhoneDetails.PhoneType"/> was requested
        /// </summary>
        public PhoneType PhoneType { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(DialingCode))
                return PhoneNumber;
            return $"({DialingCode}) {PhoneNumber}";
        }
    }
}
