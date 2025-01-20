using System;

namespace VenditPublicSdk.Entities
{
    public class TradeIn
    {
        public int TradeInId { get; set; }
        public int PurchaseDetailId { get; set; }
        public int? SaleDetailId { get; set; }
        public int? OrderDetailId { get; set; }
        public int? CustomerPickListDetailId { get; set; }
        public int? BrancheId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string SizeName { get; set; }
        public string Description { get; set; }
        public string Subdescription { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string SerialNumber { get; set; }
        public string FrameNumber { get; set; }
        public string LockNumber { get; set; }
        public string KeyNumber { get; set; }
        public string DataTagNumber { get; set; }
        public string ImeiNumber { get; set; }
        public byte[] Photo { get; set; }
        public string MotorNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public string LicensePlateMeldcode { get; set; }
        public int? RepairDetailId { get; set; }
        public int? GroupId { get; set; }
        public string IdNumber { get; set; }
        public bool? ReadyForSale { get; set; }
        public int? TradeInOfficeId { get; set; }
        public int? OfferDetailId { get; set; }
        public string Memo { get; set; }
        public DateTime? TradeInDatetime { get; set; }
        public string Barcode { get; set; }
        public DateTime? LastExportDatetime { get; set; }
        public bool EcommerceExport { get; set; }
        public int TradeInWijkTypeId { get; set; }
        public int TradeInWijkId { get; set; }
        public string ProductType { get; set; }
        public int? TradeInKindId { get; set; }
        public string TradeInKindName { get; set; }
        public string PassportNumber { get; set; }
        public string ExtraInfo1 { get; set; }
        public string ExtraInfo2 { get; set; }
        public string ExtraInfo3 { get; set; }
        public string ExtraInfo4 { get; set; }
        public string ExtraInfo5 { get; set; }
        public string BatteryNumber { get; set; }
        public string DisplayNumber { get; set; }
        public int? StockOfficeTransferDetailId { get; set; }
        public int? DorId { get; set; }
        public int? DorSendError { get; set; }
        public string PurchasefromIdentificationNumber { get; set; }
        public int? PurchasefromDorIdentificationId { get; set; }
        public int? PurchasefromDorCountryId { get; set; }
        public string SelltoIdentificationNumber { get; set; }
        public int? SelltoDorIdentificationId { get; set; }
        public int? SelltoDorCountryId { get; set; }
        public bool TradeInVatProduct { get; set; }
        public string Mileage { get; set; }
        public TradeInVatTypeEnum TradeInVatType { get; set; }
        public string ShStatusMessage { get; set; }
        public int? ModelYear { get; set; }
        public int? DorProductGoroupId { get; set; }
        public string LeaseContractNumber { get; set; }
        public string LeaseVehicleNumber { get; set; }
        public int? PurchaseOrderDetailId { get; set; }
        public int? PurchasePicklistDetailId { get; set; }
        public int? DorExcludeEmployee { get; set; }
        public string DorExcludeReason { get; set; }
        public int? PurchaseContactId { get; set; }
        public bool InStock { get; set; }
        public string KeyNumber2 { get; set; }
        public string BikeImeiNumber { get; set; }
        public string VinNumber { get; set; }
        public string VelopassNumber { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
