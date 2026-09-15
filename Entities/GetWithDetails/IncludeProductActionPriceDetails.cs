using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// <para>An Action price is defined either for a single product or for a product group, never for both, so
    /// requesting <see cref="Product"/> and <see cref="ProductGroup"/> together always leaves one of the two empty.</para>
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeProductActionPriceDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the product this Action price applies to (empty when the Action price is defined for a product group)
        /// </summary>
        [Description("Product")]
        Product = 1,

        /// <summary>
        /// Include the product group this Action price applies to (empty when the Action price is defined for a single product)
        /// </summary>
        [Description("Product group")]
        ProductGroup = 2,

        /// <summary>
        /// Include the size/color combination this Action price is limited to (empty when it applies to every size/color combination)
        /// </summary>
        [Description("Size/color combination")]
        ProductSizeColor = 4
    }
}
