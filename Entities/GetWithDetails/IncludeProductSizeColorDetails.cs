using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// <para>Note that a plain Get always returns the size and the color, while a call taking these flags returns exactly
    /// what was asked for: leaving <see cref="Size"/> or <see cref="Color"/> out means SizeName, ColorName and the other
    /// flattened size/color fields come back empty.</para>
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeProductSizeColorDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the size, which fills SizeGroupId, SizeName, SizeSubstitute and SizeSortOrder
        /// </summary>
        [Description("Size")]
        Size = 1,

        /// <summary>
        /// Include the color, which fills ColorGroupId, ColorName, ColorSubstitute and ColorCode
        /// </summary>
        [Description("Color")]
        Color = 2,

        /// <summary>
        /// Include the product this size/color combination belongs to
        /// </summary>
        [Description("Product")]
        Product = 4
    }
}
