using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductSizeColor
    {
        public int ProductSizeColorId { get; set; }
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public bool IsDeleted { get; set; }
        public int SizeGroupId { get; set; }
        public string SizeName { get; set; }
        public string SizeSubstitute { get; set; }
        public short SizeSortOrder { get; set; }
        public int ColorGroupId { get; set; }
        public string ColorName { get; set; }
        public string ColorSubstitute { get; set; }
        public string ColorCode { get; set; }

        public override string ToString()
        {
            return $"{SizeName} - {ColorName}";
        }
    }
}
