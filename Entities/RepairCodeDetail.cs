using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairCodeDetail : ICloneable
    {
        public int RepairCodeDetailId { get; set; }

        public Results<RepairCodeDetailProduct> Products { get; set; }

        public int RepairCodeHeaderId { get; set; }

        public string DetailGroupCode { get; set; }

        public string DetailGroupDescription { get; set; }

        public decimal DefaultTime { get; set; }

        public decimal FixedPrice { get; set; }

        public short VatUsage { get; set; }

        public bool CalcCosts { get; set; }

        public string Barcode { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }
        public RepairCodeDetail Clone()
        {
            RepairCodeDetail clone = new RepairCodeDetail
            {
                RepairCodeDetailId = RepairCodeDetailId,
                RepairCodeHeaderId = RepairCodeHeaderId,
                DetailGroupCode = DetailGroupCode,
                DetailGroupDescription = DetailGroupDescription,
                DefaultTime = DefaultTime,
                FixedPrice = FixedPrice,
                VatUsage = VatUsage,
                CalcCosts = CalcCosts,
                Barcode = Barcode,
            };

            if (Products != null)
            {
                clone.Products = new Results<RepairCodeDetailProduct>(Products.Items.Length);
                for (int t = Products.Items.Length - 1; t >= 0; t--)
                    clone.Products.Items[t] = Products.Items[t].Clone();
            }

            return clone;
        }

        public override string ToString()
        {
            return $"{DetailGroupCode}: {DetailGroupDescription}";
        }
    }
}