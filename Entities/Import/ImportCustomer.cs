using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportCustomer : Customer
    {
        public Results<ImportAddress> Addresses { get; set; }

        public Results<ImportCustomerGroup> CustomerGroups { get; set; }

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
        public ImportBusinessRules ImportBusinessRules { get; set; } = ImportBusinessRules.Import;
    }
}
