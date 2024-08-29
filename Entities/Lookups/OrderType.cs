using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class OrderType
    {
        public int OrderTypeId { get; set; }
        public string OrderTypeDescription { get; set; }
        public bool DefaultType { get; set; }
        public int EnumValue { get; set; }
        public short SortOrder { get; set; }
        public int? StatusColor { get; set; }
        public int? FontColor { get; set; }
    }
}
