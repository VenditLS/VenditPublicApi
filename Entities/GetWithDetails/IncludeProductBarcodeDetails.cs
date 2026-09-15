using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeProductBarcodeDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the product this barcode belongs to
        /// </summary>
        [Description("Product")]
        Product = 1,

        /// <summary>
        /// Include the size/color combination of this barcode, which also fills SizeName, ColorName and ColorCode
        /// </summary>
        [Description("Size/color combination")]
        ProductSizeColor = 2,

        /// <summary>
        /// Include the individual stock item this barcode identifies (only set for uniquely identified items)
        /// </summary>
        [Description("Stock item")]
        ProductStockDetail = 4
    }
}
