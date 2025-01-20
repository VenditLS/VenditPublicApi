using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Transaction
    {
        public decimal TotalPriceExVatBeforeInvoiceDiscount { get; set; }
        public decimal TotalPriceIncVatBeforeInvoiceDiscount { get; set; }
        public int JournalType { get; set; }
        public Results<SalePayment> SalePayments { get; set; }
        public Results<ProductVat> SaleVats { get; set; }
        public Results<SaleCustomer> Customer { get; set; }
        public Results<SaleDetail> SaleDetails { get; set; }
        public int SaleHeaderId { get; set; }
        public decimal TotalPriceExVat { get; set; }
        public decimal TotalPriceIncVat { get; set; }
        public decimal TotalVat { get; set; }
        public string InvoiceNumber { get; set; }
        public string ReceiptNumber { get; set; }
        public System.DateTime TransactionDatetime { get; set; }
        public int EmployeeId { get; set; }
        public string WorkstationName { get; set; }
        public string WorkstationCode { get; set; }
        public int OfficeId { get; set; }
        public string OrderNumber { get; set; }
        public string PakbonNumber { get; set; }
        public bool? SaleExVat { get; set; }
        public int TurnoverEmployeeId { get; set; }
        public decimal InvoiceDiscountPercentage { get; set; }
        public decimal InvoiceDiscountAmount { get; set; }
        public bool DiscountIsPercentage { get; set; }
        public string BaselineReferenceNumber { get; set; }
        public bool IsPickinglistInvoice { get; set; }
        public string TelecomReferenceNumber { get; set; }
        public bool IsEcommerce { get; set; }
        public int CustomerGroupId { get; set; }
        public string BonusText { get; set; }
        public int? VatRegimeId { get; set; }
        public int? ReturnReasonId { get; set; }
        public string ReturnExtraInformation { get; set; }
        public int? TicketStamp { get; set; }
        public int? TicketStampPrevious { get; set; }
        public int? TicketRunningNumber { get; set; }
        public bool Loyalty4gProcessed { get; set; }
        public bool IsCustomerOrderInvoice { get; set; }
        public System.DateTime? PlanInfoPlanningDatetime { get; set; }
        public System.DateTime? PlanInfoDeliveryDatetime { get; set; }
        public int? PlanInfoEmployeeId { get; set; }
        public string Url { get; set; }
        public long? IntersolveLiabRefpos { get; set; }
        public string IntersolveLiabCardnumber { get; set; }
        public string PurchaseOrderNumber { get; set; }

        public override string ToString()
        {
            return $"[{ReceiptNumber}{InvoiceNumber}] {TransactionDatetime.ToShortDateString()}";
        }
    }
}
