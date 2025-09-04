using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class StockOfficeTransferOrder
    {
        public long StockOfficeTransferOrderId { get; set; }
        public int OfficeIdFrom { get; set; }
        public int OfficeIdTo { get; set; }
        public DateTime OrderDatetime { get; set; }
        public int OrderEmployeeId { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
        public decimal ProductQuantity { get; set; }
        public string PicklistNumber { get; set; }
        public DateTime? PicklistDatetime { get; set; }
        public int PicklistEmployeeId { get; set; }
        public decimal PicklistQuantity { get; set; }
        public string ProductExtraInfo { get; set; }

        public override string ToString()
        {
            return $"{ProductId} x {ProductQuantity} {ProductExtraInfo}";
        }
    }

    [Serializable]
    public class StockOfficeTransfer
    {
        public long StockOfficeTransferHeaderId { get; set; }
        public int OfficeIdFrom { get; set; }
        public int OfficeIdTo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TransferDatetime { get; set; }
        public string TransferNumber { get; set; }
        public string ExtraInfo { get; set; }
        public bool? OrderAssemblyInWarehouse { get; set; }
        public long? CustomerOrderHeaderId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }

        public Results<StockOfficeTransferDetail> Details { get; set; }

        public override string ToString()
        {
            return $"{TransferNumber} {ExtraInfo}";
        }
    }

    [Serializable]
    public class StockOfficeTransferDetail
    {
        public long StockOfficeTransferDetailId { get; set; }
        public long StockOfficeTransferHeaderId { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
        public decimal ProductPurchasePriceEx { get; set; }
        public decimal ProductAvgPurchasePriceEx { get; set; }
        public decimal ProductSalesPriceEx { get; set; }
        public decimal ProductQuantity { get; set; }
        public string FrameNumber { get; set; }
        public string LockNumber { get; set; }
        public string KeyNumber { get; set; }
        public string DataTagNumber { get; set; }
        public string MotorNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public string LicensePlateMeldcode { get; set; }
        public string SerialNumber { get; set; }
        public string ImeiNumber { get; set; }
        public string IdNumberBarcode { get; set; }
        public string BatteryNumber { get; set; }
        public string DisplayNumber { get; set; }
        public int? TradeInId { get; set; }
        public int? StockLocationIdFrom { get; set; }
        public string ProductExtraInfo { get; set; }
        public string KeyNumber2 { get; set; }
        public string BikeImeiNumber { get; set; }
        public string VinNumber { get; set; }
        public string VelopassNumber { get; set; }
        public string CertificateNumber { get; set; }
        public long? CustomerOrderDetailId { get; set; }
        public string Remark { get; set; }

        public override string ToString()
        {
            return $"{ProductId} x {ProductQuantity} {Remark}";
        }
    }

    [Serializable]
    public class StockOfficeTransferHistory
    {
        public long StockOfficeTransferHeaderId { get; set; }
        public int OfficeIdFrom { get; set; }
        public int OfficeIdTo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TransferDatetime { get; set; }
        public string TransferNumber { get; set; }
        public DateTime ProcessDatetime { get; set; }
        public int ProcessEmployeeId { get; set; }
        public int TransferStatusEnum { get; set; }
        public string ExtraInfo { get; set; }
        public bool HideForReport { get; set; }
        public int SaleHeaderId { get; set; }
        public long CustomerPickinglistHeaderId { get; set; }
        public bool? OrderAssemblyInWarehouse { get; set; }
        public string CustomerOrderNumber { get; set; }

        public override string ToString()
        {
            return $"{TransferNumber} {ExtraInfo}";
        }

        public Results<StockOfficeTransferDetailHistory> Details { get; set; }
    }

    [Serializable]
    public class StockOfficeTransferDetailHistory
    {
        public long StockOfficeTransferDetailId { get; set; }
        public long StockOfficeTransferHeaderId { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
        public decimal ProductPurchasePriceEx { get; set; }
        public decimal ProductAvgPurchasePriceEx { get; set; }
        public decimal ProductSalesPriceEx { get; set; }
        public decimal ProductQuantitySend { get; set; }
        public decimal ProductQuantityReceived { get; set; }
        public string IdNumber { get; set; }
        public int TransferStatusEnum { get; set; }
        public int SaleDetailId { get; set; }
        public bool HideForReport { get; set; }
        public long CustomerPickinglistDetailId { get; set; }
        public int? TradeInId { get; set; }
        public decimal? ProductSalesPriceInc { get; set; }
        public string ProductExtraInfo { get; set; }
        public int? StockLocationIdFrom { get; set; }
        public int? StockLocationIdTo { get; set; }
        public long? CustomerOrderDetailId { get; set; }
        public string Remark { get; set; }

        public override string ToString()
        {
            return $"{ProductId} x {ProductQuantityReceived}/{ProductQuantitySend} {Remark}";
        }
    }
}
