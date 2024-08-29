using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class SalesUnit
    {
        public int SalesUnitId { get; set; }
        public string SalesUnitDescription { get; set; }
        public int SortOrder { get; set; }
        public string Code { get; set; }
    }
}
