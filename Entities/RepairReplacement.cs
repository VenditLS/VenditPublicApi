using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairReplacement
    {
        public int RepairReplacementId { get; set; }

        public int? RepairHeaderId { get; set; }

        public int BrancheId { get; set; }

        public System.DateTime? ReplacementDate { get; set; }

        public string ReplacementDescription { get; set; }

        public string IdentificationNumber { get; set; }

    }
}
