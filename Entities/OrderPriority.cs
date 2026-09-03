namespace VenditPublicSdk.Entities
{
    public class OrderPriority
    {
        public int OrderPriorityId { get; set; }

        public int PriorityValue { get; set; }

        public string PriorityDescription { get; set; }

        public bool DefaultPriority { get; set; }
    }
}
