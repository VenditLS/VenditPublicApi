using System;
using System.ComponentModel;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Repair
    {
        public int RepairHeaderId { get; set; }

        public Results<RepairDetail> Details { get; set; }

        public System.DateTime CreationDatetime { get; set; }

        public int OfficeId { get; set; }

        public int EmployeeId { get; set; }

        public int CustomerId { get; set; }

        public int InvoiceAddressId { get; set; }

        public int InvoiceContactId { get; set; }

        public int DeliveryAddressId { get; set; }

        public int DeliveryContactId { get; set; }

        public string RepairNumber { get; set; }

        public int? BrancheId { get; set; }

        public string BrandName { get; set; }

        public string ProductKind { get; set; }

        public string ProductType { get; set; }

        public string IdNumber { get; set; }

        public System.DateTime? PurchaseDate { get; set; }

        public string PurchaseDateFormat { get; set; }

        public bool Warranty { get; set; }

        public string CertificateNumber { get; set; }

        public bool InformCustomerPrice { get; set; }

        public decimal MinInformAmount { get; set; }

        public decimal? InformedAmount { get; set; }

        public string ConditionDescription { get; set; }

        public string RepairDescription { get; set; }

        public bool? Recurring { get; set; }

        public int RepairStatusId { get; set; }

        public string RepairLabelNumber { get; set; }

        public string CustomerAgreement { get; set; }

        public string Mileage { get; set; }

        public string AdditionalInfo { get; set; }

        public decimal ResearchCost { get; set; }

        public decimal MaterialCost { get; set; }

        public decimal TotalCost { get; set; }

        public int StockStatusEnum { get; set; }

        public System.DateTime StatusDatetime { get; set; }

        public string InformedDescription { get; set; }

        public long PlanningId { get; set; }

        public int RepairEmployeeId { get; set; }

        public int? SaleHeaderId { get; set; }

        public System.DateTime? PlanningDatetime { get; set; }

        public string PlanningDatetimeFormat { get; set; }

        public string PlanningTimeFormat { get; set; }

        public decimal? InvoiceDiscountPercentage { get; set; }

        public decimal? InvoiceDiscountAmount { get; set; }

        public bool? DiscountIsPercentage { get; set; }

        public int? SaleDetailId { get; set; }

        public bool? PlanningMorning { get; set; }

        public DeliveryCommunicationType? CommunicationType { get; set; }

        public string ProblemDescription { get; set; }

        public string PassportNumber { get; set; }

        public int InvoiceDebitCustomerId { get; set; }

        public int? DaypartsubId { get; set; }

        public int? WarrantyMonth { get; set; }

        public int? StatusEmployeeId { get; set; }

        public System.Guid? Unitid { get; set; }

        public System.DateTime? Pickupdatetime { get; set; }

        public string PickupdateFormat { get; set; }

        public string Servicetypedescription { get; set; }

        public string Relatedproducttext { get; set; }

        public string LeaseContractNumber { get; set; }

        public string LeaseVehicleNumber { get; set; }

        public int? LeaseFirmEnum { get; set; }

        public string LeaseOrderReference { get; set; }

        public int? LeaseStatusEnum { get; set; }

        public System.DateTime? LeaseStatusDate { get; set; }

        public string LeaseContractServiceOwner { get; set; }

        public string LeaseBrand { get; set; }

        public bool? SmsPlanningReminder { get; set; }

        public System.DateTime? SmsPlanningReminderSend { get; set; }

        public System.DateTime? LeaseContractEnddate { get; set; }

        public decimal? LeaseMaxBudget { get; set; }

        public decimal? LeaseRemainingBudget { get; set; }

        public bool? LeaseCustomerPaymentAgreed { get; set; }

        public string InvoiceInstruction { get; set; }

        public bool? LoanBike { get; set; }

        public bool? LoanElectricBike { get; set; }

        public bool? ServiceTransfer { get; set; }

        public string LeasePriceCategory { get; set; }

        public Results<RepairReplacement> RepairReplacement { get; set; }

        public Results<RepairDownpayment> DownPayments { get; set; }

        public Results<RepairCustomerAccessoire> RepairCustomerAccessoires { get; set; }

    }

    [Serializable]
    public class RepairStatus
    {
        public int RepairStatusId { get; set; }
        public string StatusDescription { get; set; }
        public RepairStatusEnum EnumValue { get; set; }
        public bool Fixed { get; set; }
        public short SortOrder { get; set; }
        public int? StatusColor { get;     set; }
        public int? FontColor       { get; set; }
        public bool ProcessPreorder { get; set; }
        public bool UnitVisible     { get; set; }
    }

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
