using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class Country
    {
        public int    CountryId      { get; set; }
        public string CountryName    { get; set; }
        public string CountryCode    { get; set; }
        public string DialingCode    { get; set; }
        public string IcpCountryCode { get; set; }

        public override string ToString()
        {
            return CountryName;
        }
    }
}
