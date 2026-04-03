using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Flags]
    public enum IncludeTransactionDetails
    {
        [Description("No details")]
        None = 0,
        [Description("Products")]
        Details = 1,
        [Description("Payments recieved")]
        Payments = 2,
        [Description("Unpaid account")]
        UnpaidAccount = 4,
        [Description("Insurance (on Details)")]
        Insurance = 8
    }
}
