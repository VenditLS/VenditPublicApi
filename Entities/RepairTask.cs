using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairTask
    {
        public int RepairTaskId { get; set; }
        public int RepairHeaderId { get; set; }
        public int? RepairCodeDetailId { get; set; }
        public string DetailGroupDescription { get; set; }
        public decimal? RequiredTime { get; set; }
        public decimal? FixedPrice { get; set; }
        public int VatUsage { get; set; }
        public int BtServiceId { get; set; }
        public string LeaseTaskCode { get; set; }
        public int? LeaseTaskAmount { get; set; }
        public decimal? LeaseTaskPriceEx { get; set; }
        public decimal? LeaseTaskMaxPriceEx { get; set; }
        public bool? LeaseTaskIsLabour { get; set; }
        public bool? LeaseTaskIsApproved { get; set; }
        public string LeaseTaskStatusCode { get; set; }
        public string LeaseTaskStatusDescription { get; set; }
    }
}
