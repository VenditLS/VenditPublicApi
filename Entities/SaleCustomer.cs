using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class SaleCustomer
    {
        public decimal AddCustomerBonusDiscountScore { get; set; }

        public decimal AddCustomerBonusDiscountCreditScore { get; set; }

        public int AddCustomerBonusTransactionCount { get; set; }

        public int SaleCustomerId { get; set; }

        public int SaleHeaderId { get; set; }

        public int CustomerId { get; set; }

        public string InvoiceZipcode { get; set; }

        public string InvoiceCity { get; set; }

        public int InvoiceAddressId { get; set; }

        public int? InvoiceContactId { get; set; }

        public int DeliveryAddressId { get; set; }

        public int? DeliveryContactId { get; set; }

        public int InvoiceDebitCustomerId { get; set; }

        public int? InvoiceCountryId { get; set; }

    }
}
