using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple details in one call)
    /// </summary>
    [Serializable]
    [Flags]
    public enum IncludeContactDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,

        /// <summary>
        /// Include the phone numbers belonging to the contact person.
        /// </summary>
        [Description("Phone numbers")]
        Phones = 1,

        /// <summary>
        /// Include the title (salutation) of the contact person.
        /// </summary>
        [Description("Title")]
        Title = 2,

        /// <summary>
        /// Include the middle name (tussenvoegsel) of the contact person.
        /// </summary>
        [Description("Middle name")]
        MiddleName = 4,

        /// <summary>
        /// Include the gender of the contact person.
        /// </summary>
        [Description("Gender")]
        Gender = 8,

        /// <summary>
        /// Include the function the contact person has within the organisation.
        /// </summary>
        [Description("Contact function")]
        ContactFunction = 16
    }
}
