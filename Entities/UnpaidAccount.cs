using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class UnpaidAccount
    {
        public int UnpaidAccountId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal DueAmount { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public DateTime? LastReminderDate { get; set; }
        public byte ReminderCount { get; set; }
        public bool Active { get; set; }
        public DateTime ActivationDate { get; set; }
        public int UnpaidAccountTypeId { get; set; }
        public string Memo { get; set; }
    }
}
