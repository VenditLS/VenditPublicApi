using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Address
    {
        public int    addressId         { get; set; }
        public string streetName        { get; set; }
        public string houseNumber       { get; set; }
        public string zipcode           { get; set; }
        public string city              { get; set; }
        public int    countryId         { get; set; }
        public int    addressTypeId     { get; set; }
        public bool   defaultAddress    { get; set; }
        public string emailAddress      { get; set; }
        public string houseNumberSuffix { get; set; }
        public string companyName       { get; set; }
        public string glnNumber         { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(companyName))
                return $"{streetName} {houseNumber}{houseNumberSuffix}, {zipcode} {city}";
            else
                return $"{companyName}: {streetName} {houseNumber}{houseNumberSuffix}, {zipcode} {city}";
        }
    }
}
