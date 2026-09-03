using System;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class Info
    {
        [XmlElement("ExportDateTime")]
        public DateTime ExportDateTime { get; set; }
    }
}