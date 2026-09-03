using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class OrderProduct
    {
        public Guid EcommerceProductGuid { get; set; }

        public string ProductId { get; set; }

        public string EAN { get; set; }

        public string ProductNumber { get; set; }

        public decimal ProductSalesPriceEx { get; set; }

        public decimal ProductSalesPriceInc { get; set; }

        public decimal Quantity { get; set; }

        public string Remarks { get; set; }

        /// <remarks>
        /// Transmitted as [OfficeId]; the import does not recognize [StockOfficeId].
        /// </remarks>
        [XmlElement("OfficeId")]
        [JsonProperty("OfficeId")]
        public string StockOfficeId { get; set; }

        public bool ReserveStock { get; set; }

        /// <remarks>
        /// Transmitted as [Description]; the import does not recognize [ProductDescription].
        /// </remarks>
        [XmlElement("Description")]
        [JsonProperty("Description")]
        public string ProductDescription { get; set; }

        /// <remarks>
        /// Transmitted as [IsDropshipment] (lowercase s); the import is case sensitive on Xml.
        /// </remarks>
        [XmlElement("IsDropshipment")]
        [JsonProperty("IsDropshipment")]
        public bool? IsDropShipment { get; set; }
    }
}
