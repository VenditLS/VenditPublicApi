using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class CustomerFilter : BaseFilter<CustomerFields>
    {
        public CustomerFilter(CustomerFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public CustomerFilter(CustomerFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class CustomerFilters : BaseFilters<CustomerFields, CustomerFilter>
    {
        public CustomerFilters(params CustomerFilter[] filters) : base(filters) { }
    }

    public class CustomerResults : BaseResultsReply<int>
    {
    }

    public class FindCustomers:FindClientBase<int, CustomerFields>
    {
        
    }

    /// <summary>
    /// Fields available for filtering or searching for Customers
    /// </summary>
    public enum CustomerFields
    {
        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        AdditionalInfo = 900,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BankAccount = 100,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CompanyName = 101,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        CreationDate = 200,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        LastModified = 524,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CustomerBonusDiscountDescription = 901,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        CustomerBonusDiscountScore = 902,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CustomerGroups = 903,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CustomerNumber = 103,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        DueAmount = 904,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Email = 104,

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
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        LastTransactionDate = 905,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        MaxCreditLimit = 906,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        MobilePhoneNumber = 107,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PaymentTermDescription = 907,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PhoneNumber = 108,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Website = 109,

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



        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        CustomerBonusDiscountId = 908,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PaymentTermId = 909,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        ContactId = 410,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        AddressId = 1028,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        AddressTypeId = 910,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        CountryId = 411,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        PhoneNumberId = 911,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        MobilePhoneNumberId = 912,
    }
}
