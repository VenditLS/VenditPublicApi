using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportContact : Contact
    {
        public new Results<Phone> Phones { get; set; }
        public new string Title { get; set; }
        public new string MiddleName { get; set; }
        public new string Gender { get; set; }
        public string Function { get; set; }
    }
}
