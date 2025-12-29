using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairStatus
    {
        public int              RepairStatusId    { get; set; }
        public string           StatusDescription { get; set; }
        public RepairStatusEnum EnumValue         { get; set; }
        public bool             Fixed             { get; set; }
        public short            SortOrder         { get; set; }
        public int?             StatusColor       { get; set; }
        public int?             FontColor         { get; set; }
        public bool             ProcessPreorder   { get; set; }
        public bool             UnitVisible       { get; set; }

        public override string ToString()
        {
            return $"{StatusDescription} ({EnumValue})";
        }
    }
}