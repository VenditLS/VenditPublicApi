using System;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string BankAccount { get; set; }
        public string AdditionalInfo { get; set; }
        public string EmailAddress { get; set; }
        public bool ShowInclVat { get; set; }
        public decimal? MaxCreditLimit { get; set; }
        public short? MaxOverdueDays { get; set; }
        public int? CustomerNumber { get; set; }
        public int CustomerBonusDiscountId { get; set; }
        public decimal CustomerBonusDiscountScore { get; set; }
        public string CustomerBonusCardNumber { get; set; }
        public decimal FixedDiscountPercentage { get; set; }
        public int PaymentTermId { get; set; }
        public int PickinglistOnReceiptOption { get; set; }
        public int PickinglistAutoInvoiceDays { get; set; }
        public decimal PickinglistAutoInvoiceAmount { get; set; }
        public int PickinglistPrintInvoiceShort { get; set; }
        public string VatNumber { get; set; }
        [Obsolete("Legacy field, will be removed.")]
        public int CustomerGroupBitvalue { get; set; }
        public string HintInfo { get; set; }
        public string ExtraInfo { get; set; }
        public int CustomerBonusTransactionCount { get; set; }
        public string EcommerceCustomerNumber { get; set; }
        public DateTime? DatetimeLastUpdate { get; set; }
        public DateTime? CreationDatetime { get; set; }
        public DateTime? ModifiedDatetime { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? LastTransactionDatetime { get; set; }
        public int? PricelistId { get; set; }
        public int PickinglistPrintBrutoPrices { get; set; }
        public bool AllowOnAccount { get; set; }
        public string CustomerNumber2 { get; set; }
        public int InvoiceDebitCustomerId { get; set; }
        public int InvoiceDebitAddressId { get; set; }
        public int InvoiceDebitContactId { get; set; }
        public string KvkNumber { get; set; }
        public int CreatedOfficeId { get; set; }
        public string IbanNumber { get; set; }
        public bool? NoTransactions { get; set; }
        public bool? NoInformation { get; set; }
        public bool IsResale { get; set; }
        public bool IsRaisePercent { get; set; }
        public int? VatRegimeId { get; set; }
        public string TomirrowId { get; set; }
        public string Loyalty4GId { get; set; }
        public string WebVideoPwd { get; set; }
        public bool NoNewsletter { get; set; }
        public int UnpaidAccountTypeId { get; set; }
        public int? LanguageId { get; set; }
        public bool HideCustomerInfo { get; set; }
        public string InvoiceEmailAddress { get; set; }
        public bool OptIn { get; set; }
        public DateTime? OptInDatetime { get; set; }
        public int? EdifactTypeEnum { get; set; }

        /// <summary>
        /// EDIFACT_TYPE_ENUM (int NULL)
        /// </summary>
        [XmlIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public EdifactTypeEnum? EdifactType
        {
            get { return (EdifactTypeEnum?)EdifactTypeEnum; }
            set { EdifactTypeEnum = (int?)value; }
        }

        public override string ToString()
        {
            return $"[{CustomerNumber2}] {CompanyName}";
        }
    }

    [Serializable]
    public enum EdifactTypeEnum
    {
        None = 0,
        RetailPay_D96A_DynamoRetail = 1,
        RetailPay_D96A_Euretco = 2,
    }

    [Serializable]
    public class Salecustomer
    {
        public int AddCustomerBonusDiscountScore { get; set; }
        public int AddCustomerBonusDiscountCreditScore { get; set; }
        public int AddCustomerBonusTransactionCount { get; set; }
        public int SaleCustomerId { get; set; }
        public int SaleHeaderId { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceZipcode { get; set; }
        public string InvoiceCity { get; set; }
        public int InvoiceAddressId { get; set; }
        public int InvoiceContactId { get; set; }
        public int DeliveryAddressId { get; set; }
        public int DeliveryContactId { get; set; }
        public int InvoiceDebitCustomerId { get; set; }
        public int InvoiceCountryId { get; set; }
    }

}
