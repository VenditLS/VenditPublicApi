using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportCustomerGroup
    {
        public int CustomerGroupId { get; set; }
        public string GroupName { get; set; }
    }
}
