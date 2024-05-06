using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class OfferFilter : BaseFilter<OfferFields>
    {
        public OfferFilter(OfferFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public OfferFilter(OfferFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class OfferFilters : BaseFilters<OfferFields, OfferFilter>
    {
        public OfferFilters(params OfferFilter[] filters) : base(filters) { }
    }

    public class OfferResults : BaseResultsReply<int>
    {
    }

    public class FindOffers : FindClientBase<int, OfferFields>
    {

    }

    /// <summary>
    /// Fields available for filtering or searching for Offers
    /// </summary>
    public enum OfferFields
    {
        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        CreationDate = 200,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        DiscountAmount = 300,

        /// <summary>
        /// Type = System.Decimal
        /// </summary>
        [Description("Type = Decimal")]
        DiscountPercentage = 301,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Barcode = 201,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        FrameNumber = 202,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        ImeiNumber = 203,

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
        SerialNumber = 207,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        KBCDossierNumber = 150,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OfferNumber = 302,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OfferStatusDescription = 151,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        ValidToDate = 303,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        EmployeeName = 152,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        TurnoverEmployeeName = 153,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrandName = 208,

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


        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        EmployeeId = 155,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        BarcodeId = 560,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        CustomerId = 409,

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
        CountryId = 411,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        DeliveryAddressId = 412,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        DeliveryContactId = 413,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        InvoiceAddressId = 414,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        InvoiceContactId = 415,

        /// <summary>
        /// Type = System.Int64
        /// </summary>
        [Description("Type = Int64")]
        OfferDetailId = 1032,

        /// <summary>
        /// Type = System.Guid
        /// </summary>
        [Description("Type = Guid")]
        KbcLeaseInfoId = 417,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        TurnoverEmployeeId = 418,
    }
}
