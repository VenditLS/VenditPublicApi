using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// <para>A transfer order is a single flat row (one product per order), so it has no Details flag.</para>
    /// </summary>
    [Flags]
    public enum IncludeStockOfficeTransferOrderDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the office the goods are ordered from.
        /// </summary>
        [Description("Office the goods come from")]
        OfficeFrom = 1,

        /// <summary>
        /// Include the office the goods are ordered for.
        /// </summary>
        [Description("Office the goods go to")]
        OfficeTo = 2,

        /// <summary>
        /// Include the employee that placed the order.
        /// </summary>
        [Description("Ordering employee")]
        OrderEmployee = 4,

        /// <summary>
        /// Include the employee that created the picklist.
        /// </summary>
        [Description("Picklist employee")]
        PicklistEmployee = 8,

        /// <summary>
        /// Include the ordered product.
        /// </summary>
        [Description("Product")]
        Product = 16,

        /// <summary>
        /// Include the ordered size/color variant.
        /// </summary>
        [Description("Product size/color")]
        ProductSizeColor = 32
    }
}
