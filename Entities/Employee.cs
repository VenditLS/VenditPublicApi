using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeKeynumber { get; set; }
        public string EmployeeEmailAddress { get; set; }
        public bool EmployeeActive { get; set; }
        public int EmployeeOfficeId { get; set; }
        public long EmployeeProfileCode { get; set; }
        public bool UseRepair { get; set; }
        public bool UseDelivery { get; set; }
        public bool UsePlanning { get; set; }
        public System.DateTime? MondayMorningStart { get; set; }
        public System.DateTime? MondayMorningEnd { get; set; }
        public System.DateTime? MondayAfternoonStart { get; set; }
        public System.DateTime? MondayAfternoonEnd { get; set; }
        public System.DateTime? TuesdayMorningStart { get; set; }
        public System.DateTime? TuesdayMorningEnd { get; set; }
        public System.DateTime? TuesdayAfternoonStart { get; set; }
        public System.DateTime? TuesdayAfternoonEnd { get; set; }
        public System.DateTime? WednesdayMorningStart { get; set; }
        public System.DateTime? WednesdayMorningEnd { get; set; }
        public System.DateTime? WednesdayAfternoonStart { get; set; }
        public System.DateTime? WednesdayAfternoonEnd { get; set; }
        public System.DateTime? ThursdayMorningStart { get; set; }
        public System.DateTime? ThursdayMorningEnd { get; set; }
        public System.DateTime? ThursdayAfternoonStart { get; set; }
        public System.DateTime? ThursdayAfternoonEnd { get; set; }
        public System.DateTime? FridayMorningStart { get; set; }
        public System.DateTime? FridayMorningEnd { get; set; }
        public System.DateTime? FridayAfternoonStart { get; set; }
        public System.DateTime? FridayAfternoonEnd { get; set; }
        public System.DateTime? SaterdayMorningStart { get; set; }
        public System.DateTime? SaterdayMorningEnd { get; set; }
        public System.DateTime? SaterdayAfternoonStart { get; set; }
        public System.DateTime? SaterdayAfternoonEnd { get; set; }
        public System.DateTime? SundayMorningStart { get; set; }
        public System.DateTime? SundayMorningEnd { get; set; }
        public System.DateTime? SundayAfternoonStart { get; set; }
        public System.DateTime? SundayAfternoonEnd { get; set; }
        public int RepairBranchesBitvalue { get; set; }
        public bool? Fixed { get; set; }
        public int PortalEmployeeId { get; set; }
        public string PortalEmployeeName { get; set; }
        public int PlanningOrder { get; set; }
        public bool AllowWeb { get; set; }
        public string WebPassword { get; set; }
        public System.DateTime? MondayEveningStart { get; set; }
        public System.DateTime? MondayEveningEnd { get; set; }
        public System.DateTime? TuesdayEveningStart { get; set; }
        public System.DateTime? TuesdayEveningEnd { get; set; }
        public System.DateTime? WednesdayEveningStart { get; set; }
        public System.DateTime? WednesdayEveningEnd { get; set; }
        public System.DateTime? ThursdayEveningStart { get; set; }
        public System.DateTime? ThursdayEveningEnd { get; set; }
        public System.DateTime? FridayEveningStart { get; set; }
        public System.DateTime? FridayEveningEnd { get; set; }
        public System.DateTime? SaterdayEveningStart { get; set; }
        public System.DateTime? SaterdayEveningEnd { get; set; }
        public System.DateTime? SundayEveningStart { get; set; }
        public System.DateTime? SundayEveningEnd { get; set; }
        public System.Guid OnlineId { get; set; }
        public bool? SmsPlanningReminderActive { get; set; }
        public bool? UseOnlinePlanning { get; set; }
    }
}
