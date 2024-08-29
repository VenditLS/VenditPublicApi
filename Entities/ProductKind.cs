using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductKind
    {
        public int ProductKindId { get; set; }
        public int BrancheId { get; set; }
        public string KindDescription { get; set; }
    }
}
