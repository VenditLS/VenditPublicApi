using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Contact
    {
        public Results<Phone> phones { get; set; }
        public int contactId { get; set; }
        public int? titleId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public int? middleNameId { get; set; }
        public int sexId { get; set; }
        public DateTime? birthDate { get; set; }
        public string additionalInfo { get; set; }
        public int contactType { get; set; }
        public string emailAddress { get; set; }
        public int? functionId { get; set; }
        public bool defaultContact { get; set; }
        public string driverLicenseNr { get; set; }
        public string bankAccount { get; set; }
        public string department { get; set; }
        public string ibanNumber { get; set; }
        public Guid? externalId { get; set; }
        public bool optIn { get; set; }
        public DateTime? optInDatetime { get; set; }
    }
}
