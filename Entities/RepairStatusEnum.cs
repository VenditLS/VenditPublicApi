using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public enum RepairStatusEnum
    {
        /// <summary>
        /// Nieuw
        /// </summary>
        [Description("Nieuw")]
        New = 0,

        /// <summary>
        /// Geaccepteerd
        /// </summary>
        [Description("Geaccepteerd")]
        Accepted = 2,

        /// <summary>
        /// Geweigerd
        /// </summary>
        [Description("Geweigerd")]
        Rejected = 3,

        /// <summary>
        /// In behandeling
        /// </summary>
        [Description("In behandeling")]
        Planned = 4,

        /// <summary>
        /// Verlopen
        /// </summary>
        [Description("Verlopen")]
        Expired = 9,

        /// <summary>
        /// Verwijderd
        /// </summary>
        [Description("Verwijderd")]
        Deleted = 10,

        /// <summary>
        /// Gefactureerd
        /// </summary>
        [Description("Gefactureerd")]
        Invoiced = 11
    }
}