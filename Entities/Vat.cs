using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Vat
    {
        public int VatId { get; set; }
        public decimal VatPercent { get; set; }
        public string VatDescription { get; set; }
        public int CountryId { get; set; }
        public bool PreferredVat { get; set; }
        public bool Fixed { get; set; }
        public short TradeIn { get; set; }
        public bool VatShiftedRule { get; set; }
        public string VatCodeExternalProgram { get; set; }
        public bool VatDisabled { get; set; }
        public bool VatShiftedRuleOutsideEu { get; set; }
        public bool VatShiftedRuleOwnCountry { get; set; }

        public override string ToString()
        {
            return $"{VatDescription} {VatPercent}";
        }
    }
}
