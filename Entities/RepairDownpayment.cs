using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairDownpayment
    {
        public int RepairDownPaymentId { get; set; }
        public int RepairHeaderId { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal RestAmount { get; set; }
        public int PaymentCodeId { get; set; }
        public int PaymentTypeId { get; set; }

        public override string ToString()
        {
            return $"{PaymentDate.ToShortDateString()} : {PaymentAmount:N2}";
        }
    }
}
