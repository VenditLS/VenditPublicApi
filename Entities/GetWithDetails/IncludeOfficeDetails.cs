using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// <para>The fax numbers of an office are deliberately not exposed.</para>
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeOfficeDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the visiting address of the office.
        /// </summary>
        [Description("Address")]
        Address = 1,

        /// <summary>
        /// Include the invoice address of the office.
        /// </summary>
        [Description("Invoice address")]
        InvoiceAddress = 2,

        /// <summary>
        /// Include the delivery address of the office.
        /// </summary>
        [Description("Delivery address")]
        DeliveryAddress = 4,

        /// <summary>
        /// Include the country of the office.
        /// </summary>
        [Description("Country")]
        Country = 8,

        /// <summary>
        /// Include the phone number of the office.
        /// </summary>
        [Description("Phone number")]
        Phone = 16,

        /// <summary>
        /// Include the phone number used for invoicing.
        /// </summary>
        [Description("Invoice phone number")]
        InvoicePhone = 32,

        /// <summary>
        /// Include the phone number used for deliveries.
        /// </summary>
        [Description("Delivery phone number")]
        DeliveryPhone = 64
    }
}
