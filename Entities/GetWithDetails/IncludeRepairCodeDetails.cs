using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeRepairCodeDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the detail records (the individual repair codes) of this repair code group
        /// </summary>
        [Description("Details")]
        Details = 1,

        /// <summary>
        /// Include the product references on every detail (implies <see cref="Details"/>).
        /// <para>These are references only: quantity and product ID, not the product itself.</para>
        /// </summary>
        [Description("Product references on the details")]
        Products = 2,

        /// <summary>
        /// Include the full product behind every product reference (implies <see cref="Details"/> and <see cref="Products"/>)
        /// </summary>
        [Description("Products of the product references")]
        Product = 4,

        /// <summary>
        /// Include the branche this repair code belongs to
        /// </summary>
        [Description("Branche")]
        Branche = 8
    }
}
