using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class TransactionFilter : BaseFilter<TransactionFields>
    {
        public TransactionFilter(TransactionFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public TransactionFilter(TransactionFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class TransactionFilters : BaseFilters<TransactionFields, TransactionFilter>
    {
        public TransactionFilters(params TransactionFilter[] filters) : base(filters) { }
    }

    public class TransactionResults : BaseResultsReply<int>
    {
    }

    public class FindTransactions : FindClientBase<int, TransactionFields>
    {

    }

    public enum TransactionFields
    {
        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductDescription = 204,

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
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailBatteryNumber = 214,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrandName = 208,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailDisplayNumber = 215,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailFrameNumber = 202,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailImeiNumber = 203,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailKeyNumber = 216,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailLicensePlateNumber = 217,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailLockNumber = 218,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailPassportNumber = 209,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        SaleDetailSerialNumber = 207,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        InvoiceNumber = 800,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        InvoiceZipcode = 803,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OfficeId = 804,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderNumber = 154,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PakbonNumber = 805,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductGroupDescription = 219,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ProductGroupNumber = 220,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        PurchaseOrderNumber = 806,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ReceiptNumber = 801,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        TransactionDateTime = 802,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Color = 221,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Size = 222,

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
