using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Flags]
    public enum IncludePurchaseOrderDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the ordered product rows.
        /// </summary>
        [Description("Products")]
        Details = 1,

        /// <summary>
        /// Include the supplier the order was placed with.
        /// </summary>
        [Description("Supplier")]
        Supplier = 2,

        /// <summary>
        /// Include the office the order belongs to.
        /// </summary>
        [Description("Office")]
        Office = 4,

        /// <summary>
        /// Include the employee that placed the order.
        /// </summary>
        [Description("Employee")]
        Employee = 8,

        /// <summary>
        /// Include the ordered product on every order row (implies Details).
        /// </summary>
        [Description("Product on the rows")]
        Product = 16,

        /// <summary>
        /// Include the ordered size/color variant on every order row (implies Details).
        /// </summary>
        [Description("Product size/color on the rows")]
        ProductSizeColor = 32,

        /// <summary>
        /// Include the employee that created the preorder.
        /// </summary>
        [Description("Preorder employee")]
        PreorderEmployee = 64
    }
}
