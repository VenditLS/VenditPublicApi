using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class StockJournal
    {
        public int Id { get; set; }
        public int Barcode { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public string OfficeId { get; set; }
        public string OfficeCode { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ProductNumber { get; set; }
        public string ProductDescription { get; set; }
        public string Reference { get; set; }
        public Guid ReferenceGuid { get; set; }
        public int ReferenceId { get; set; }
        public decimal PurchasePriceExTotal { get; set; }
        public decimal SalesPriceExTotal { get; set; }
        public decimal SalePriceEx { get; set; }
        public decimal PurchasePriceEx { get; set; }
        public DateTime ChangeDate { get; set; }
        public int JournalType { get; set; }
        public decimal StockDiff { get; set; }
    }
}
