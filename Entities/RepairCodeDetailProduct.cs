using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairCodeDetailProduct : ICloneable
    {
        public int RepairCodeDetailProductId { get; set; }

        public int RepairCodeDetailId { get; set; }

        public int ProductId { get; set; }

        public decimal ProductQuantity { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }
        public RepairCodeDetailProduct Clone()
        {
            return new RepairCodeDetailProduct
            {
                RepairCodeDetailProductId = RepairCodeDetailProductId,
                RepairCodeDetailId = RepairCodeDetailId,
                ProductId = ProductId,
                ProductQuantity = ProductQuantity
            };
        }
    }
}