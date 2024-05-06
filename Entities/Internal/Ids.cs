using Newtonsoft.Json;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities.Internal
{
    /// <summary>
    /// Container holding a list of IDs (primary keys)
    /// </summary>
    public class Ids<TPrimaryKey>
    {
        public Ids()
        {
        }

        public Ids(TPrimaryKey[] primaryKeys)
        {
            PrimaryKeys = primaryKeys;
        }

        /// <summary>
        /// List of primary keys
        /// </summary>
        [XmlElement("primaryKeys")]
        [JsonProperty("primaryKeys")]
        public TPrimaryKey[] PrimaryKeys { get; set; }
    }


}
