using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludePrePurchaseOrderDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the office this order advice was created for
        /// </summary>
        [Description("Office")]
        Office = 1,

        /// <summary>
        /// Include the employee that created this order advice
        /// </summary>
        [Description("Employee")]
        Employee = 2,

        /// <summary>
        /// Include the product to be ordered
        /// </summary>
        [Description("Product")]
        Product = 4,

        /// <summary>
        /// Include the size/color combination to be ordered (empty when the product has no size/color variations)
        /// </summary>
        [Description("Size/color combination")]
        ProductSizeColor = 8,

        /// <summary>
        /// Include the supplier the goods are to be ordered from
        /// </summary>
        [Description("Target supplier")]
        TargetSupplier = 16,

        /// <summary>
        /// Include the office the goods are to be delivered to (empty when they are delivered to the office of the advice itself)
        /// </summary>
        [Description("Target office")]
        TargetOffice = 32
    }
}
