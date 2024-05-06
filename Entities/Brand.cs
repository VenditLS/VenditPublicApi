using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandCode { get; set; }
    }
}
