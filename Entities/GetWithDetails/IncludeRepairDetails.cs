using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Flags]
    public enum IncludeRepairDetails
    {
        [Description("No details")]
        None = 0,
        [Description("Products")]
        Details = 1,
        [Description("Work (to be) done on the repair job")]
        Tasks = 2,
        [Description("Payments recieved")]
        DownPayments = 4,
        
        [Description("Parts (to be) replaced")]
        Replacements = 8,
        
        [Description("Additional accessories")]
        Accessoires = 16,

        [Description("Insurance")]
        Insurance = 32
    }
}
