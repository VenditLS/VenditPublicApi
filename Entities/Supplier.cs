using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Supplier
    {
        public Address[] Addresses { get; set; }

        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string SupplierEmail { get; set; }

        public string SupplierWebsite { get; set; }

        public string SupplierBankAccount { get; set; }

        public string SupplierInfo { get; set; }

        public string SupplierNumber { get; set; }

        public string SupplierDebtNumber { get; set; }

        public int OrderSettingEnum { get; set; }

        public int? OrderCommunicationServiceId { get; set; }

        public int? OrderLayoutId { get; set; }

        public string OrderEmailAttachmentFilename { get; set; }

        public string OrderEmailTo { get; set; }

        public string OrderEmailToCc { get; set; }

        public int? StockinfoCommunicationServiceId { get; set; }

        public string StockinfoUrl { get; set; }

        public int? DeliveryCommunicationServiceId { get; set; }

        public decimal? MinOrderAmount { get; set; }

        public int? StockLookupTypeEnum { get; set; }

        public int? SupplierGroupBitvalue { get; set; }

        public bool PurchaseInvoiceAllSuppliers { get; set; }

        public string ExtraInfo { get; set; }

        public int? OrderCommunicationServiceLayoutId { get; set; }

        public string OrderFtpServer { get; set; }

        public int? OrderFtpPort { get; set; }

        public string OrderFtpPath { get; set; }

        public string OrderFtpFilename { get; set; }

        public bool? OrderFtpPassiveMode { get; set; }

        public bool? OrderFtpSftp { get; set; }

        public string OrderEmailSubject { get; set; }

        public bool? OrderEmailAsAttachment { get; set; }

        public string OrderLocalFilePath { get; set; }

        public string OrderLocalFileFilename { get; set; }

        public string GlnNumber { get; set; }

        public string SupplierImageUrl { get; set; }

        public int? MinimumOrderAmount { get; set; }

        public decimal? ExtraCosts { get; set; }

        public int? ProductPriceCommunicationServiceId { get; set; }

        public bool? DeliveryAutoAddProductSupplier { get; set; }

        public bool IsDosImport { get; set; }

        public string IbanNumber { get; set; }

        public string BicNumber { get; set; }

        public string SwiftNumber { get; set; }

        public string VatNumber { get; set; }

        public int? DeliveryDays { get; set; }

        public bool DisableAutoPurchasePriceUpdate { get; set; }

        public System.Guid SupplierGuid { get; set; }

        public int? PurchaseInvoiceSupplierId { get; set; }

        public bool? IsNotRemovable { get; set; }

        public string OrderConfirmationEmailTo { get; set; }

        public int? OrderFtpType { get; set; }

        public int? OrderFtpTimeout { get; set; }

        public bool AllowDropshipment { get; set; }

        public int? DropshipmentLayoutid { get; set; }

        public bool? DropshipmentEmailasattachment { get; set; }

        public string DropshipmentEmailattachmentfilename { get; set; }

        public string DropshipmentEmailto { get; set; }

        public string DropshipmentEmailtoCc { get; set; }

        public string DropshipmentEmailtosubject { get; set; }

        public bool OrderFtpUseAscii { get; set; }

        public string BicAndSwift { get; set; }

        public string BanknummerAndIBAN { get; set; }

    }
}
