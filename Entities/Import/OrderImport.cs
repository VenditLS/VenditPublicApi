using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    [XmlRoot("OrderImport")]
    public class OrderImport
    {
        [XmlElement("ImportInfo")]
        public Info ImportInfo { get; set; }

        [XmlArray("Orders")]
        [XmlArrayItem("Order")]
        public List<ImportOrder> Orders { get; set; }
    }
}