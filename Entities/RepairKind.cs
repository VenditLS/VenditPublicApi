using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairKind
    {
        public int RepairKindId { get; set; }

        public int BrancheId { get; set; }

        public string KindDescription { get; set; }

        public decimal DefaultResearchCost { get; set; }

        public decimal DefaultMaterialCost { get; set; }

        public override string ToString()
        {
            return KindDescription;
        }
    }
}