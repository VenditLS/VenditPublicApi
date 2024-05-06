using System;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Customer
    {
        public int customerId { get; set; }
        public string companyName { get; set; }
        public string website { get; set; }
        public string bankAccount { get; set; }
        public string additionalInfo { get; set; }
        public string emailAddress { get; set; }
        public bool showInclVat { get; set; }
        public decimal? maxCreditLimit { get; set; }
        public short? maxOverdueDays { get; set; }
        public int? customerNumber { get; set; }
        public int customerBonusDiscountId { get; set; }
        public decimal customerBonusDiscountScore { get; set; }
        public string customerBonusCardNumber { get; set; }
        public decimal fixedDiscountPercentage { get; set; }
        public int paymentTermId { get; set; }
        public int pickinglistOnReceiptOption { get; set; }
        public int pickinglistAutoInvoiceDays { get; set; }
        public decimal pickinglistAutoInvoiceAmount { get; set; }
        public int pickinglistPrintInvoiceShort { get; set; }
        public string vatNumber { get; set; }
        public int customerGroupBitvalue { get; set; }
        public string hintInfo { get; set; }
        public string extraInfo { get; set; }
        public int customerBonusTransactionCount { get; set; }
        public string ecommerceCustomerNumber { get; set; }
        public DateTime? datetimeLastUpdate { get; set; }
        public DateTime? creationDatetime { get; set; }
        public DateTime? modifiedDatetime { get; set; }
        public int? createdBy { get; set; }
        public int? modifiedBy { get; set; }
        public DateTime? lastTransactionDatetime { get; set; }
        public int? pricelistId { get; set; }
        public int pickinglistPrintBrutoPrices { get; set; }
        public bool allowOnAccount { get; set; }
        public string customerNumber2 { get; set; }
        public int invoiceDebitCustomerId { get; set; }
        public int invoiceDebitAddressId { get; set; }
        public int invoiceDebitContactId { get; set; }
        public string kvkNumber { get; set; }
        public int createdOfficeId { get; set; }
        public string ibanNumber { get; set; }
        public bool? noTransactions { get; set; }
        public bool? noInformation { get; set; }
        public bool isResale { get; set; }
        public bool isRaisePercent { get; set; }
        public int? vatRegimeId { get; set; }
        public string tomirrowId { get; set; }
        public string loyalty4GId { get; set; }
        public string webVideoPwd { get; set; }
        public bool noNewsletter { get; set; }
        public int unpaidAccountTypeId { get; set; }
        public int? languageId { get; set; }
        public bool hideCustomerInfo { get; set; }
        public string invoiceEmailAddress { get; set; }
        public bool optIn { get; set; }
        public DateTime? optInDatetime { get; set; }
        public int? edifactTypeEnum { get; set; }

        /// <summary>
        /// EDIFACT_TYPE_ENUM (int NULL)
        /// </summary>
        [XmlIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public EdifactTypeEnum? EdifactType
        {
            get { return (EdifactTypeEnum?)edifactTypeEnum; }
            set { edifactTypeEnum = (int?)value; }
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
        public int addCustomerBonusDiscountScore { get; set; }
        public int addCustomerBonusDiscountCreditScore { get; set; }
        public int addCustomerBonusTransactionCount { get; set; }
        public int saleCustomerId { get; set; }
        public int saleHeaderId { get; set; }
        public int customerId { get; set; }
        public string invoiceZipcode { get; set; }
        public string invoiceCity { get; set; }
        public int invoiceAddressId { get; set; }
        public int invoiceContactId { get; set; }
        public int deliveryAddressId { get; set; }
        public int deliveryContactId { get; set; }
        public int invoiceDebitCustomerId { get; set; }
        public int invoiceCountryId { get; set; }
    }

}
