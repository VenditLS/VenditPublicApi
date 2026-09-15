using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeAddressDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the phone numbers belonging to the address.
        /// </summary>
        [Description("Phone numbers of the address")]
        Phones = 1,

        /// <summary>
        /// Include the contact persons belonging to the address.
        /// </summary>
        [Description("Contact persons")]
        Contacts = 2,

        /// <summary>
        /// Include the phone numbers of every contact person (implies Contacts).
        /// </summary>
        [Description("Phone numbers of the contact persons")]
        ContactPhones = 4,

        /// <summary>
        /// Include the country of the address.
        /// </summary>
        [Description("Country")]
        Country = 8,

        /// <summary>
        /// Include the address type (invoice, delivery, ...) of the address.
        /// </summary>
        [Description("Address type")]
        AddressType = 16
    }
}
