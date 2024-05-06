using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductSupplier
    {
        public int ProductSupplierId { get; set; }

        public int ProductId { get; set; }

        public int SupplierId { get; set; }

        public string SupplierProductNumber { get; set; }

        public decimal MinOrderQuantity { get; set; }

        public bool PreferredDefaultSupplier { get; set; }

        public decimal RecommendedSalesPriceInc { get; set; }

        public bool IsDeleted { get; set; }

        public decimal SupplierStock { get; set; }

        public System.DateTime? ExpectedArrivalDatetime { get; set; }

        public int? DeliveryDays { get; set; }

        public int AvailabilityStatusId { get; set; }

        public string SupplierStock2 { get; set; }

        public System.DateTime? LastModified { get; set; }

        public bool? AvailabilityLock { get; set; }

        public bool? UserAdded { get; set; }

        public bool LockPreferredSupplier { get; set; }

        public Office Office { get; set; }

        public bool Preferred { get; set; }

        public ProductPurchasePrice ProductPurchasePrice { get; set; }

        public Results<SupplierOrder> ProductPurchaseHistory { get; set; }

        public Supplier Supplier { get; set; }

    }
}
