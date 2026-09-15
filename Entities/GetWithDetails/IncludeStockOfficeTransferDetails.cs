using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Flags]
    public enum IncludeStockOfficeTransferDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the transferred product rows.
        /// </summary>
        [Description("Products")]
        Details = 1,

        /// <summary>
        /// Include the office the goods are sent from.
        /// </summary>
        [Description("Office the goods come from")]
        OfficeFrom = 2,

        /// <summary>
        /// Include the office the goods are sent to.
        /// </summary>
        [Description("Office the goods go to")]
        OfficeTo = 4,

        /// <summary>
        /// Include the employee that created the transfer.
        /// </summary>
        [Description("Employee")]
        Employee = 8,

        /// <summary>
        /// Include the transferred product on every row (implies Details).
        /// </summary>
        [Description("Product on the rows")]
        Product = 16,

        /// <summary>
        /// Include the transferred size/color variant on every row (implies Details).
        /// </summary>
        [Description("Product size/color on the rows")]
        ProductSizeColor = 32,

        /// <summary>
        /// Include the trade-in of every row that transfers one (implies Details).
        /// </summary>
        [Description("Trade-in on the rows")]
        TradeIn = 64
    }
}
