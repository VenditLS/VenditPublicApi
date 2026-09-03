using System;

namespace VenditPublicSdk.Entities.Import
{
    public class EcommerceSettings
    {
        /// <summary>
        /// EcommerceSettingsGuid
        /// </summary>
        public Guid Id { get;         set; }
        public string Name     { get; set; }
        public bool   Isactive { get; set; }
        public int    OfficeId { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Name}";
        }
    }
}
