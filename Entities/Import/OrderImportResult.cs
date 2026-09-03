using System;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class OrderImportResult
    {
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Unexpected tags (that do not cause a crash, but may be helpful to debug unexpected behaviour)
        /// </summary>
        public string WarningMessage { get; set; }

        [XmlArray("SuccessfullyImported")]
        [XmlArrayItem("OrderNumber")]
        public string[] SuccessfullyImportedOrderNumbers { get; set; }

        /// <summary>
        /// See logs for details
        /// </summary>
        [XmlArray("FailedToImport")]
        [XmlArrayItem("OrderNumber")]
        public string[] FailedToImportOrderNumbers { get; set; }

        public override string ToString()
        {
            return $"{ErrorMessage}\r\n\r\nSuccess ({SuccessfullyImportedOrderNumbers.Length}):\r\n  {string.Join("\r\n  ", SuccessfullyImportedOrderNumbers)}\r\n\r\nFailures ({FailedToImportOrderNumbers.Length}):\r\n  {string.Join("\r\n  ", FailedToImportOrderNumbers)}";
        }
    }
}
