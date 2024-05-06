using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductVat
    {
        public int ProductVatId { get; set; }

        public int ProductId { get; set; }

        public int OfficeId { get; set; }

        public int VatId { get; set; }

    }
}
