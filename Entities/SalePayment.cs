using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class SalePayment
    {
        public int SalePaymentId { get; set; }
        public int SaleHeaderId { get; set; }
        public int? PaymentTypeId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDownpayment { get; set; }
        public bool? IsChange { get; set; }
        public bool ChangeLink { get; set; }
        public int? JournalId { get; set; }
        public int? LookupSaleHeaderId { get; set; }
        public int? BaseCurrencyId { get; set; }
        public decimal? CurrencyExchangeRate { get; set; }
        public decimal? TotalCurrencyAmount { get; set; }
        public bool? ViaBank { get; set; }
        public long? IntersolveLiabRefpos { get; set; }

        public override string ToString()
        {
            return TotalAmount.ToString("N2");
        }
    }
}
