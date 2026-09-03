using System;

namespace VenditPublicSdk.Entities
{
    /// <summary>
    /// Betaallink
    /// </summary>
    public class PaymentLink
    {
        /// <summary>
        /// The payment URL
        /// </summary>
        public string PaymentUrl { get; set; }

        /// <summary>
        /// Template comes from payNlSettings
        /// </summary>
        public bool LinkAsText { get; set; }

        /// <summary>
        /// Template Comes from payNlSettings
        /// </summary>
        public string LinkHtml { get; set; }

        /// <summary>
        /// Link expiry date
        /// </summary>
        public DateTime LinkExpire { get; set; }
    }
}
