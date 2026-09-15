using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Flags]
    public enum IncludeOfferDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the product rows of the offer.
        /// </summary>
        [Description("Products")]
        Details = 1,

        /// <summary>
        /// Include the customer the offer was made to.
        /// </summary>
        [Description("Customer")]
        Customer = 2,

        /// <summary>
        /// Include the office the offer belongs to.
        /// </summary>
        [Description("Office")]
        Office = 4,

        /// <summary>
        /// Include the employee that created the offer.
        /// </summary>
        [Description("Employee")]
        Employee = 8,

        /// <summary>
        /// Include the size/color variant of the product on every offer row (implies Details).
        /// </summary>
        [Description("Product size/color on the rows")]
        ProductSizeColor = 16,

        /// <summary>
        /// Include the brand of the product on every offer row (implies Details).
        /// </summary>
        [Description("Brand on the rows")]
        Brand = 32,

        /// <summary>
        /// Include the VAT definition of every offer row (implies Details).
        /// </summary>
        [Description("VAT on the rows")]
        Vat = 64
    }
}
