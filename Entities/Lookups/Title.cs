using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class Title
    {
        public int TitleId { get; set; }
        public string TitleDescription { get; set; }
        public int LanguageId { get; set; }
    }
}