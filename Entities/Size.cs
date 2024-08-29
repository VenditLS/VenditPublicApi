using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Size
    {
        public int SizeId { get; set; }
        public int SizeGroupId { get; set; }
        public string SizeName { get; set; }
        public string SizeSubstitute { get; set; }
        public short SortOrder { get; set; }
    }
}
