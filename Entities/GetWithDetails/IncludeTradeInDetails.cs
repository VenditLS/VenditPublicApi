using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeTradeInDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the branche of the traded in item
        /// </summary>
        [Description("Branche")]
        Branche = 1,

        /// <summary>
        /// Include the product group of the traded in item
        /// </summary>
        [Description("Product group")]
        ProductGroup = 2,

        /// <summary>
        /// Include the office the item was traded in at
        /// </summary>
        [Description("Trade-in office")]
        TradeInOffice = 4
    }
}
