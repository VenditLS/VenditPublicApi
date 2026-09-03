using System;

namespace VenditPublicSdk.Entities
{
    public class Journal
    {
        public int JournalId { get; set; }

        public DateTime ActivityDate { get; set; }

        public int DrawerId { get; set; }

        public int WorkstationId { get; set; }

        public int EmployeeId { get; set; }

        public string JournalDescription { get; set; }

        public int? SaleHeaderId { get; set; }

        public short JournalType { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountDifference { get; set; }

        public int? FinancialCodeId { get; set; }

        public int OfficeId { get; set; }

        public int? LookupSaleHeaderId { get; set; }
    }
}
