using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Branche
    {
        public int BrancheId { get; set; }
        public string BrancheName { get; set; }
        public string BrancheDescription { get; set; }
        public bool PreferredBranche { get; set; }
        public bool BrancheActive { get; set; }
        public int SortOrder { get; set; }
        public bool UseSize { get; set; }
        public bool UseColor { get; set; }
        public bool? UseFramenumber { get; set; }
        public bool UseSerialnumber { get; set; }
        public bool UseImeinumber { get; set; }
        public bool UseSplitfunction { get; set; }
        public bool UseDisposalfee { get; set; }
        public bool UseRepair { get; set; }
        public short Bitvalue { get; set; }
        public bool UseRepairTasks { get; set; }
        public bool UseDor { get; set; }
    }
}
