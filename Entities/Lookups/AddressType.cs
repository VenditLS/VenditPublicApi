using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class AddressType
    {
        public int AddressTypeId { get; set; }
        public string AddressTypeDescription { get; set; }
        public short SortOrder { get; set; }
        public bool DeliveryAddress { get; set; }
        public bool InvoiceAddress { get; set; }

        public override string ToString()
        {
            return AddressTypeDescription;
        }
    }
}
