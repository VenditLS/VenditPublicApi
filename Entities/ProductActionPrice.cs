using System;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(BrandName))
                sb.Append(BrandName).Append(" ");
            sb.Append(ActionPriceGroupName).Append(" ");
            if (SalesPriceExVat > 0)
                sb.Append(SalesPriceExVat.ToString("N2"));
            if(DiscountPercentage > 0)
                sb.Append(DiscountPercentage.ToString("N2")).Append('%');

            return sb.ToString();
        }
    }
}
