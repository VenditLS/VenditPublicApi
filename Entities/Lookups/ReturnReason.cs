using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class ReturnReason
    {
        public int ReturnReasonId { get; set; }
        public string Reason { get; set; }
        public bool Fixed { get; set; }
        public int SortOrder { get; set; }
    }
}
