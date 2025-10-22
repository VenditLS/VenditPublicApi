namespace VenditPublicSdk.Entities.Reports
{
    public class StockWriteOffLogReport
    {
        public string OfficeName { get; set; }
        public string OfficeCode { get; set; }
        public string WorkstationName { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string LocationName { get; set; }
        public int? LogStockId { get; set; }
        public int? ProductId { get; set; }
        public int? SizeColorId { get; set; }
        public int? StockLocationId { get; set; }
        public decimal? OldStock { get; set; }
        public decimal? CurrentStock { get; set; }
        public int? OfficeId { get; set; }
        public int? WorkstationId { get; set; }
        public int? EmployeeId { get; set; }
        public string LogDatetime { get; set; }
        public string WriteoffInformation { get; set; }
        public decimal? StockWriteoff { get; set; }
        public decimal? PurchasePriceEx { get; set; }
        public decimal? SalesPriceInc { get; set; }
        public decimal? SalesPriceEx { get; set; }
        public decimal? PurchasePriceExTotal { get; set; }
        public decimal? SalesPriceExTotal { get; set; }
        public string GroupDescription { get; set; }
        public int? StockWriteoffId { get; set; }
        public string StockWriteoffDescription { get; set; }
        public string Barcode { get; set; }
        public string ProductNumber { get; set; }
        public string ProductDescription { get; set; }
        public string ColorName { get; set; }
        public string SizeName { get; set; }
        public int? StockOfficeId { get; set; }
        public string StockOfficeName { get; set; }
        public string StockOfficeCode { get; set; }
    }
}
