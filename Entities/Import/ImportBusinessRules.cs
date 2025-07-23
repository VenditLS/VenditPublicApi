using System;
using System.Collections.Generic;
using System.Text;

namespace VenditPublicSdk.Entities.Import
{
    /// <summary>
    /// Special care for fields that impact customers, including:
    /// <list type="bullet">
    /// <item><term>CustomerBonusDiscountScore</term><description>Bonus score</description></item>
    /// <item><term>CustomerBonusTransactionCount</term><description>Bonus transaction count</description></item>
    /// <item><term>FixedDiscountPercentage</term><description>Fixed discount percentage</description></item>
    /// <item><term>MaxCreditLimit</term><description>Maximum amount the customer is allowed to pay later</description></item>
    /// <item><term>MaxOverdueDays</term><description>Maximum days that a customer can delay paying</description></item>
    /// <item><term>PickinglistAutoInvoiceAmount</term><description>Auto invoice amount for customers shopping &quot;on account&quot;</description></item>
    /// <item><term>HideCustomerInfo</term><description>Hide customers information for normal users (special module needed)</description></item>
    /// <item><term>IsRaisePercent</term><description>Special margin on purchase price for befriended competitors that run out of stock</description></item>
    /// <item><term>IsResale</term><description></description></item>
    /// <item><term>NoInformation</term><description></description></item>
    /// <item><term>NoTransactions</term><description>Revoke any transaction with this unwanted customer</description></item>
    /// <item><term>AllowOnAccount</term><description>Allow the customer to pay later</description></item>
    /// </list>
    /// </summary>
    public enum ImportBusinessRules
    {
        /// <summary>
        /// Default behaviour: fields will only be copied if the existing value is default (prefer old value), other fields will have the same behaviour as when importing e-commerce customers (semi-configurable)
        /// <para>Use this setting when the Vendit Database is more likely to be up-to-date than the import-source (add missing data)</para>
        /// </summary>
        Import = 0,

        /// <summary>
        /// If the imported field is not null or default, it will overwrite the existing (prefer new value)
        /// <para>Use this setting when you deem the import-source to be more up-to-date than the Vendit Database</para>
        /// </summary>
        UpdateNonDefault = 1,

        /// <summary>
        /// <para>Sums the fields CustomerBonusDiscountScore and CustomerBonusTransactionCount</para>
        /// <para>Takes the largest value for FixedDiscountPercentage, OptInDatetime</para>
        /// <para>Takes the smallest value for MaxCreditLimit, MaxOverdueDays, PickinglistAutoInvoiceAmount</para>
        /// <para>Uses the OR operator for the fields HideCustomerInfo, IsRaisePercent, IsResale, NoInformation, NoTransactions</para>
        /// <para>Uses the AND operation for the fields AllowOnAccount</para>
        /// </summary>
        Merge = 2,

        /// <summary>
        /// Bulldozer (overwrite) all fields with new values (backup first is recommended).
        /// </summary>
        ForceUpdate = 3
    }
}
