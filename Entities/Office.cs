using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class OfficeMinimal
    {
        public int OfficeId { get; set; }
        public short OfficeNumber { get; set; }
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; }
        public string GlnNumber { get; set; }

        public override string ToString()
        {
            return OfficeName;
        }
    }

    [Serializable]
    public class Office : OfficeMinimal
    {
        public int CountryId { get; set; }
        public string SenderEmail { get; set; }
        public bool MainOffice { get; set; }
        public string DefaultLanguageCode { get; set; }
        public int MaxWorkstation { get; set; }
        public string LicenseNumber { get; set; }
        public int MaxConcurrentUsers { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public int? AddressId { get; set; }
        public string DateFormat { get; set; }
        public int? InvoiceAddressId { get; set; }
        public int? DeliveryAddressId { get; set; }
        public int? PhoneId { get; set; }
        public int? FaxId { get; set; }
        public int? InvoicePhoneId { get; set; }
        public int? InvoiceFaxId { get; set; }
        public int? DeliveryPhoneId { get; set; }
        public int? DeliveryFaxId { get; set; }
        public string SenderEmailName { get; set; }
        public bool WarehouseOffice { get; set; }
        public int CustomerId { get; set; }
        public bool DeliveryFromWarehouseOnly { get; set; }
        public bool UseCollectionWarehouse { get; set; }
        public System.DateTime? MondayOpen { get; set; }
        public System.DateTime? MondayClosed { get; set; }
        public System.DateTime? TuesdayOpen { get; set; }
        public System.DateTime? TuesdayClosed { get; set; }
        public System.DateTime? WednesdayOpen { get; set; }
        public System.DateTime? WednesdayClosed { get; set; }
        public System.DateTime? ThursdayOpen { get; set; }
        public System.DateTime? ThursdayClosed { get; set; }
        public System.DateTime? FridayOpen { get; set; }
        public System.DateTime? FridayClosed { get; set; }
        public System.DateTime? SaterdayOpen { get; set; }
        public System.DateTime? SaterdayClosed { get; set; }
        public System.DateTime? SundayOpen { get; set; }
        public System.DateTime? SundayClosed { get; set; }
        public string DeliveryGlnNumber { get; set; }
        public string ExternalCustomerNumber1 { get; set; }
        public string ExternalCustomerNumber2 { get; set; }
    }
}
