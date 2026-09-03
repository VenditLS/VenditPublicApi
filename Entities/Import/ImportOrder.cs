using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportOrder
    {
        public ImportOrder()
        {
            Products = new List<OrderProduct>();
        }

        [XmlArray("Products")]
        [XmlArrayItem("Product")]
        public List<OrderProduct> Products { get; set; }

        public string OrderNumber { get; set; } // E + ordernumber
        
        public string OrderDate { get; set; }

        
        public string DeliveryDate { get; set; }

        public decimal TotalOrderAmount { get; set; }

        public string PaymentMethod { get; set; }

        public decimal Paid { get; set; }

        public decimal PaymentCosts { get; set; }

        public string ShippingMethod { get; set; }

        public decimal ShippingCost { get; set; }

        public string InvoiceDiscountName { get; set; }

        public decimal InvoiceDiscountAmount { get; set; }

        public string OrderRemark { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string InvoiceFirstName { get; set; }

        public string MiddleName { get; set; }

        public string Sex { get; set; }

        public string InvoiceMiddleName { get; set; }

        public string LastName { get; set; }
        
        public string InvoiceLastName { get; set; }

        public string EmailAddress { get; set; }

        public string InvoiceEmailAddress { get; set; }

        public string Phone { get; set; }

        public string InvoicePhone { get; set; }

        public string PhoneMobile { get; set; }

        public DateTime? Birthdate { get; set; }

        public bool Gift { get; set; }

        public string GiftMessage { get; set; }
        
        public string OrderMessage { get; set; }

        public string InvoiceAddress { get; set; }

        public string InvoiceHousenumber { get; set; }

        public string InvoiceHousenumberExtension { get; set; }

        public string InvoiceZipcode { get; set; }

        public string InvoiceCity { get; set; }

        public string InvoiceCountry { get; set; }

        public string InvoiceCountryCode { get; set; }

        public string CompanyName        { get; set; }
        public string InvoiceCompanyName { get; set; }

        public string IBANNumber { get; set; }

        public string BankAccount { get; set; }

        public string VatNumber { get; set; }

        public int? OrderStatusId { get; set; }

        public int? OrderPriorityId { get; set; }

        public int? OfficeId { get; set; }

        public int? EmployeeId { get; set; }

        public string CustomerGroup { get; set; }

        public string DeliveryFirstName { get; set; }

        public string DeliveryTitle { get; set; }

        public string DeliveryMiddleName { get; set; }

        public string DeliveryLastName { get; set; }

        public string DeliveryAddress { get; set; }

        public string DeliveryHousenumberExtension { get; set; }

        public string DeliveryHousenumber { get; set; }

        public string DeliveryZipcode { get; set; }

        public string DeliveryCity { get; set; }

        public string DeliveryCountry { get; set; }

        public string DeliveryCountryCode { get; set; }

        public string DeliveryCompanyName { get; set; }

        public bool DefaultAddress { get; set; }

        public bool? InvoiceExVat { get; set; }

        public bool OptIn { get; set; }

        public DateTime OptInDate { get; set; }

        public int DropshipmentType { get; set; }

        public string OrderType { get; set; }

        public string OrderStatus { get; set; }

        public string CustomerNumber { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string Url { get; set; }

        public string StoreNumber { get; set; }

        public string Source { get; set; } //For EP, source would be "OneTrail"

        public string OrderOrigin { get; set; }

        /// <summary>
        /// Not used so far
        /// </summary>
        public string OrderMessages { get; set; }
    }
}