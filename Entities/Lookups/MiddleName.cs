using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class MiddleName
    {
        public int MiddleNameId { get; set; }
        public string Middlename { get; set; }
        public int LanguageId { get; set; }

        public override string ToString()
        {
            return Middlename;
        }
    }
}
