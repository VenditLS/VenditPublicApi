using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// <para>The order layout of a supplier is deliberately not exposed; it contains the binary report template.</para>
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeSupplierDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the addresses of the supplier
        /// </summary>
        [Description("Addresses")]
        Addresses = 1,

        /// <summary>
        /// Include the phone numbers belonging to the addresses (implies Addresses)
        /// </summary>
        [Description("Phone numbers (belonging to addresses)")]
        AddressPhones = 2,

        /// <summary>
        /// Include the contact persons belonging to the addresses (implies Addresses)
        /// </summary>
        [Description("Contact persons")]
        Contacts = 4,

        /// <summary>
        /// Include the phone numbers of every contact person (implies Addresses and Contacts)
        /// </summary>
        [Description("Phone numbers (belonging to contact persons)")]
        ContactPhones = 8,

        /// <summary>
        /// Include the supplier groups this supplier belongs to
        /// </summary>
        [Description("Supplier groups")]
        SupplierGroups = 16
    }
}
