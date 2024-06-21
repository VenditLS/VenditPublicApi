using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductStockDetail
    {
        public int ProductStockDetailId { get; set; }
        public int ProductStockId { get; set; }
        public string FrameNumber { get; set; }
        public string LockNumber { get; set; }
        public string KeyNumber { get; set; }
        public string DataTagNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ImeiNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public string LicensePlateMeldcode { get; set; }
        public string MotorNumber { get; set; }
        public string Remark { get; set; }
        public string PassportNumber { get; set; }
        public string DisplayNumber { get; set; }
        public string BatteryNumber { get; set; }
        public string KeyNumber2 { get; set; }
        public string BikeImeiNumber { get; set; }
        public string VinNumber { get; set; }
        public string VelopassNumber { get; set; }
        public int OfficeId { get; set; }
        public int ProductId { get; set; }
        public int SizeColorId { get; set; }
    }
}
