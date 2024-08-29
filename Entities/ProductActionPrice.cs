using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductActionPrice
    {
        public int ActionPriceId { get; set; }
        public int? ProductId { get; set; }
        public int? GroupId { get; set; }
        public string BrandName { get; set; }
        public DateTime ActionStartDatetime { get; set; }
        public DateTime ActionEndDatetime { get; set; }
        public decimal SalesPriceExVat { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string HqGuid { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public bool IsHqImported { get; set; }
        public int ProductSizeColorId { get; set; }
        public string ActionPriceGroupName { get; set; }
        public string ReferenceNumber { get; set; }
        public int? Warranty { get; set; }
        public DateTime? CreationDatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDatetime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? BatchDate { get; set; }
    }
}
