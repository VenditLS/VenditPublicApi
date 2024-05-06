using System.ComponentModel;
using VenditPublicSdk.Find.Base;

namespace VenditPublicSdk.Find
{
    public class OrderFilter : BaseFilter<OrderFields>
    {
        public OrderFilter(OrderFields field, object value, FilterComparison filterComparison) : base(field, value, filterComparison) { }

        public OrderFilter(OrderFields field, object value, object value2, FilterComparison filterComparison) : base(field, value, value2, filterComparison) { }
    }

    public class OrderFilters : BaseFilters<OrderFields, OrderFilter>
    {
        public OrderFilters(params OrderFilter[] filters) : base(filters) { }
    }

    public class OrderResults : BaseResultsReply<int>
    {
    }

    public class FindOrders : FindClientBase<int, OrderFields>
    {

    }

    public enum OrderFields
    {
        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        ActivationDate = 400,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        Barcode = 201,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        BrandName = 208,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        DeliveryDate = 401,

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
        KBCDossierNumber = 150,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        OrderDate = 402,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderNumber = 154,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        OrderStatusDate = 403,

        /// <summary>
        /// Type = System.DateTime
        /// </summary>
        [Description("Type = DateTime")]
        LastModified = 524,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderTypeDescription = 404,

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
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        StockStatus = 405,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        OrderStatusDescription = 151,

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
        Website = 109,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CustomerNumber = 103,

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
        TitleDescription = 113,

        /// <summary>
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        MobilePhoneNumber = 107,

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
        /// Type = System.String
        /// </summary>
        [Description("Type = String")]
        CompanyName = 101,


        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        EmployeeId = 155,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OrderStatusEnumValue = 407,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OrderStatusId = 408,

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
        OrderDetailId = 705,

        /// <summary>
        /// Type = System.Int32
        /// </summary>
        [Description("Type = Int32")]
        OrderTypeId = 416,

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
