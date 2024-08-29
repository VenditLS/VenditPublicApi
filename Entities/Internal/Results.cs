using Newtonsoft.Json;
using System.Xml.Serialization;

namespace VenditPublicSdk.Entities.Internal
{
    /// <summary>
    /// Container holding a list of entities
    /// </summary>
    public class Results<TEntity>
    {
        /// <summary>
        /// List of entities
        /// </summary>
        [XmlElement("Items")]
        [JsonProperty("items")]
        public TEntity[] Items { get; set; }

        public Results()
        {
        }

        public Results(params TEntity[] items)
        {
            Items= items;
        }

        public static implicit operator TEntity[](Results<TEntity> results)
        {
            return results.Items;
        }

        public static implicit operator Results<TEntity>(TEntity[] items)
        {
            return new Results<TEntity>() { Items = items };
        }
    }
}
