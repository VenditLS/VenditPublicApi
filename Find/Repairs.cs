using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class RepairFilter : BaseFilter<RepairFields>
    {
        public RepairFilter(RepairFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public RepairFilter(RepairFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class RepairFilters : BaseFilters<RepairFields, RepairFilter>
    {
        public RepairFilters(params RepairFilter[] filters) : base(filters) { }
    }

    public class RepairResults : BaseResultsReply<int>
    {
    }

    public class FindRepairs : FindClientBase<int, RepairFields>
    {

    }

    public enum RepairFields
    {
        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Brand = 208,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        FrameNumber = 202,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        IdNumber = 600,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ImeiNumber = 203,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LeaseBrand = 601,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PassportNumber = 209,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductDescription = 204,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductKind = 210,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductNumber = 205,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductSubDescription = 206,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductType = 211,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        RepairCreationDate = 200,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        RepairNumber = 602,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        RepairPickUpDate = 603,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        RepairPlanningDate = 604,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        RepairPurchaseDate = 605,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        RepairStatusDate = 606,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SerialNumber = 207,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StatusDescription = 151,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        EmployeeName = 152,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        RepairEmployeeName = 607,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StatusEmployeeName = 608,

        /// <summary>
        /// Type = System.Int32
        /// Nieuw = 0
        /// Geaccepteerd = 2
        /// Geweigerd = 3
        /// In behandeling = 4
        /// Verlopen = 9
        /// Verwijderd = 10
        /// Gefactureerd = 11
        /// </summary>
        [Description(@"Type = Int32
Nieuw = 0
Geaccepteerd = 2
Geweigerd = 3
In behandeling = 4
Verlopen = 9
Verwijderd = 10
Gefactureerd = 11")]
        StatusEnumValue = 609,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CustomerNumber = 103,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Website = 109,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Email = 104,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        FirstName = 110,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GenderDescription = 106,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        IbanNumber = 114,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LandlinePhoneNumber = 108,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        LastName = 111,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        MiddleName = 112,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        MobilePhoneNumber = 107,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        TitleDescription = 113,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        AddressTypeDescription = 105,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        City = 115,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CompanyName = 101,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CountryCode = 116,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CountryName = 117,

        /// <summary>
        /// Type = System.Boolean
        /// </summary>
        [Description("Type = Boolean")]
        DefaultAddress = 118,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        HouseNumber = 119,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        HouseNumberSuffix = 120,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        StreetName = 121,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Zipcode = 122,
    }
}
