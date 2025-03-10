using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class CustomerGroup
    {
        public int CustomerGroupId { get; set; }
        public string GroupName { get; set; }
        public bool DefaultGroup { get; set; }
        public int ShowOrder { get; set; }
        public long Bitvalue { get; set; }
        public string HintInfo { get; set; }

        public override string ToString()
        {
            return GroupName;
        }
    }
}
