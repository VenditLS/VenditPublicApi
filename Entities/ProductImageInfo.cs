using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductImageInfo
    {
        public int ProductImageId { get; set; }

        public int? ProductSizeColorId { get; set; }

        public string ImageName { get; set; }

        public int? SortOrder { get; set; }

        public override string ToString()
        {
            return $"[{ProductImageId}] {ImageName} <{SortOrder}> {ProductSizeColorId}";
        }
    }
}
