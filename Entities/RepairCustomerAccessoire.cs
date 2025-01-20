using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairCustomerAccessoire
    {
        public int RepairCustomerAccessoireId { get; set; }
        public int RepairHeaderId { get; set; }
        public string ItemDescription { get; set; }

        public override string ToString()
        {
            return ItemDescription;
        }
    }
}
