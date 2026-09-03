using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Flags]
    public enum IncludeProductDetails
    {
        [Description("No details")]
        None = 0,
        [Description("Brand")]
        Brand = 1,
        [Description("Group")]
        Group = 2,
        [Description("AvailablilityStatus")]
        AvailabilityStatus = 4,
        [Description("SalesVisibility")]
        SalesVisibility = 8,
        [Description("Suppliers")]
        Suppliers = 16,
        [Description("SalesPrices")]
        SalesPrices = 32,
        [Description("Vat")]
        Vat = 64,
        [Description("AvailableStock")]
        AvailableStock = 128,
        [Description("Branche")]
        Branche = 256,
        [Description("ProductKind")]
        ProductKind = 512,
        [Description("Barcodes")]
        Barcodes = 1024,
    }
}
