using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class SupplierGroup
    {
        public int SupplierGroupId { get; set; }
        public string GroupName { get; set; }
        public bool DefaultGroup { get; set; }
        public int ShowOrder { get; set; }
        public int Bitvalue { get; set; }

        public override string ToString()
        {
            return GroupName;
        }
    }
}
