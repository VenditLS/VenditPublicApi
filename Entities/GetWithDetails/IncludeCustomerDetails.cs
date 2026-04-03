using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeCustomerDetails
    {
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include Customer Groups
        /// </summary>
        [Description("Customer Groups")]
        Groups = 1,

        /// <summary>
        /// Include Addresses
        /// </summary>
        [Description("Addresses")]
        Addresses = 2,

        /// <summary>
        /// Include contact persons (will be ignored without Addresses)
        /// </summary>
        [Description("Contact persons")]
        Contacts = 4,

        /// <summary>
        /// Include Phone numbers belonging to addresses (will be ignored without Addresses)
        /// </summary>
        [Description("Phone numbers (belonging to addresses)")]
        AddressPhones = 8,

        /// <summary>
        /// Include Phone numbers belonging to contact persons (will be ignored without Contacts)
        /// </summary>
        [Description("Phone numbers (belonging to contact persons)")]
        ContactPhones = 16
    }
}
