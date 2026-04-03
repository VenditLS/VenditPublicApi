using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Insurance
    {
        public int InsuranceId { get; set; }
        public int BaseInsuranceSettingId { get; set; }
        public DateTime CreationDatetime { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ActivationDate { get; set; }
        public int Duration { get; set; }
        public int BatchNumber { get; set; }
        public DateTime? BatchDatetime { get; set; }
        public int Region { get; set; }
        public int InsuranceGroupId { get; set; }
        public string InsuranceGroupCode { get; set; }
        public string InsuranceGroupDescription { get; set; }
        public int CoverCodeId { get; set; }
        public string CoverCode { get; set; }
        public string CoverDescription { get; set; }
        public string CoverType { get; set; }
        public bool AutomaticTransmission { get; set; }
        public bool Atb { get; set; }
        public bool UsedProduct { get; set; }
        public int LockCodeId { get; set; }
        public string LockCode { get; set; }
        public string LockCodeDescription { get; set; }
        public int DamageCount { get; set; }
        public bool PassengerInsurance { get; set; }
        public bool LegalAssistance { get; set; }
        public int SaleDetailId { get; set; }
        public int? CustomerOfferDetailId { get; set; }
        public int? CustomerOrderDetailId { get; set; }
        public decimal Cost { get; set; }
        public decimal ExtraCost { get; set; }
        public decimal Premium { get; set; }
        public int BuildYear { get; set; }
        public int BuildMonth { get; set; }
        public int SendStatus { get; set; }
        public int SendCount { get; set; }
        public string SendErrorMessage { get; set; }
        public string ReferenceNumber { get; set; }
        public string PolisNumber { get; set; }
        public int RepairDetailId { get; set; }
        public bool CompanyBike { get; set; }
        public bool PaymentViaInvoice { get; set; }
        public decimal SalesPriceInc { get; set; }
        public int? CustomerPickinglistDetailId { get; set; }
        public int OnholdDetailId { get; set; }
        public string DurationText { get; set; }
        public string InvoicePeriod { get; set; }
        public decimal? InvoicePeriodAmount { get; set; }
        public decimal? OwnRiskDamage { get; set; }
        public decimal? OwnRiskTheft { get; set; }
        public bool? IncludeAccessoires { get; set; }
        public bool? IncludePhoneAbuse { get; set; }
        public bool? IncludeLoanPhone { get; set; }
        public bool? IncludeTheft { get; set; }
        public bool? IncludeDamage { get; set; }
        public bool? IncludeElectricalDamage { get; set; }
        public bool? IncludeManufacturingErrors { get; set; }
        public string PrepaymentText { get; set; }
        public decimal? PrepaymentAmount { get; set; }
        public bool? RegularDriver { get; set; }
        public bool? AcceptanceCriteria { get; set; }
        public string PremiumOptionCode { get; set; }
        public string PremiumOptionDescription { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IncludeYoungDrivers { get; set; }
        public bool? IncludeRoadsideAssistance { get; set; }
        public bool? PriceValueInsured { get; set; }
        public bool? BuyOffOwnRisk { get; set; }
        public string ExtraOwnRisk { get; set; }
        public bool? ValidTrackTraceSystem { get; set; }
        public string FuelType { get; set; }
        public bool? LegalQuestion1 { get; set; }
        public bool? LegalQuestion2 { get; set; }
        public bool? LegalQuestion3 { get; set; }
        public bool? LegalQuestion4 { get; set; }
        public bool? LegalQuestion5 { get; set; }
        public string LegalQuestionExtraInfo { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverMiddleName { get; set; }
        public string DriverLastName { get; set; }
        public bool? DriverSex { get; set; }
        public DateTime? DriverBirthdate { get; set; }
        public int? DriverCountry { get; set; }
        public string DriverZipcode { get; set; }
        public string DriverHousenumber { get; set; }
        public string DriverHousenumberSuffix { get; set; }
        public string DriverStreet { get; set; }
        public string DriverCity { get; set; }
        public int? IsAnwbLid { get; set; }
        public string AnwbLidnummer { get; set; }
        public bool PolisViaEmail { get; set; }
        public bool IsEBike { get; set; }
        public int? InsuranceBrandId { get; set; }
        public string AccessoiresText { get; set; }
        public decimal? AccessoiresSalesPriceInc { get; set; }
        public string LegitimationType { get; set; }
        public string LegitimationNumber { get; set; }
        public DateTime? LegitimationValidUntil { get; set; }
        public bool? IsConsumer { get; set; }
        public int CreditSaleDetailId { get; set; }
        public int CreditSendStatus { get; set; }
        public int AdditionalSendStatus { get; set; }
        public string ReferenceNumberOptional1 { get; set; }
        public string ReferenceNumberOptional2 { get; set; }
        public bool? IsAnwbLidWorden { get; set; }
        public string TrackTraceBarcode { get; set; }
        public string ProductColor { get; set; }
        public int? BikeFrameType { get; set; }
        public bool? LegalQuestion6 { get; set; }
        public bool? LicensePlateNameRegistered { get; set; }
        public int? ActiveStatus { get; set; }
        public string ExtraRemark { get; set; }
        public int? MinLinkCount { get; set; }
        public int? MaxLinkCount { get; set; }
        public int? LinkedId { get; set; }

        public override string ToString()
        {
            return $"{PolisNumber} {CoverDescription} - {InsuranceGroupDescription}";
        }
    }
}
