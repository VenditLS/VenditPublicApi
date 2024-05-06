using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class SupplierFilter : BaseFilter<SupplierFields>
    {
        public SupplierFilter(SupplierFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public SupplierFilter(SupplierFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class SupplierFilters : BaseFilters<SupplierFields, SupplierFilter>
    {
        public SupplierFilters(params SupplierFilter[] filters) : base(filters) { }
    }

    public class SupplierResults : BaseResultsReply<int>
    {
    }

    public class FindSuppliers : FindClientBase<int, SupplierFields>
    {

    }

    public enum SupplierFields
    {
        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        AddressTypeDescription = 105,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GenderDescription = 106,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ExtraInfo = 700,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        GlnNumber = 701,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        MobilePhoneNumber = 107,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PhoneNumber = 108,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BankAccount = 100,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierDebtNumber = 702,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Email = 104,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierName = 213,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierNumber = 703,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SupplierWebsite = 109,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        VatNumber = 212,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        FirstName = 110,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        IbanNumber = 114,

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
        TitleDescription = 113,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        AddressId = 705,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        City = 115,

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
