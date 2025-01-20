using System;

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

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(DialingCode))
                return PhoneNumber;
            return $"({DialingCode}) {PhoneNumber}";
        }
    }
}
