using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductSupplier // previously inherited from ProductSupplier, however all value types need to be nullable :-(
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierProductNumber { get; set; }
        public decimal? MinOrderQuantity { get; set; }
        public bool? PreferredDefaultSupplier { get; set; }
        public decimal? RecommendedSalesPriceInc { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? SupplierStock { get; set; }
        public DateTime? ExpectedArrivalDatetime { get; set; }
        public int? DeliveryDays { get; set; }
        public int? AvailabilityStatusId { get; set; }
        public string SupplierStock2 { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? AvailabilityLock { get; set; }
        public bool? UserAdded { get; set; }
        public bool? LockPreferredSupplier { get; set; }
        public bool Preferred { get; set; }

        public ProductPurchasePrice ProductPurchasePrice { get; set; }
        public ImportSupplier Supplier { get; set; }
        public OfficeMinimal  Office   { get; set; }
    }
}
