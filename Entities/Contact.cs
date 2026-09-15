using System;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Entities.Lookups;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Contact
    {
        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeContactDetails.Phones"/> was requested
        /// </summary>
        public Results<Phone> Phones { get; set; }
        public int ContactId { get; set; }
        public int? TitleId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? MiddleNameId { get; set; }
        public int SexId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string AdditionalInfo { get; set; }
        public int ContactType { get; set; }
        public string EmailAddress { get; set; }
        public int? FunctionId { get; set; }
        public bool DefaultContact { get; set; }
        public string DriverLicenseNr { get; set; }
        public string BankAccount { get; set; }
        public string Department { get; set; }
        public string IbanNumber { get; set; }
        public Guid? ExternalId { get; set; }
        public bool OptIn { get; set; }
        public DateTime? OptInDatetime { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeContactDetails.Title"/> was requested
        /// </summary>
        public Title Title { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeContactDetails.MiddleName"/> was requested
        /// </summary>
        public MiddleName MiddleName { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeContactDetails.Gender"/> was requested
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Only populated when <see cref="GetWithDetails.IncludeContactDetails.ContactFunction"/> was requested
        /// </summary>
        public ContactFunction ContactFunction { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
