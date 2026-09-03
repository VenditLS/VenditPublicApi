using System;
using System.ComponentModel;

namespace VenditPublicSdk.Entities.GetWithDetails
{
    /// <summary>
    /// Flags (use the sum of wanted details to get multiple related entities in one call)
    /// </summary>
    [Flags]
    [Serializable]
    public enum IncludeOrderDetails
    {
        /// <summary>
        /// No additional details are included.
        /// </summary>
        [Description("No details")]
        None = 0,
        /// <summary>
        /// Include the order details (products).
        /// </summary>
        [Description("OrderDetails")]
        OrderDetails = 1,
        /// <summary>
        /// Include the down payments.
        /// </summary>
        [Description("DownPayments")]
        DownPayments = 2,
        /// <summary>
        /// Include the customer.
        /// </summary>
        [Description("Customer")]
        Customer = 4,
        /// <summary>
        /// Include the office.
        /// </summary>
        [Description("Office")]
        Office = 8,
        /// <summary>
        /// Include the employee.
        /// </summary>
        [Description("Employee")]
        Employee = 16,
        /// <summary>
        /// Include the order type.
        /// </summary>
        [Description("OrderType")]
        OrderType = 32,
        /// <summary>
        /// Include the order priority.
        /// </summary>
        [Description("OrderPriority")]
        OrderPriority = 64,
        /// <summary>
        /// Include the order status.
        /// </summary>
        [Description("OrderStatus")]
        OrderStatus = 128,
        /// <summary>
        /// Include the invoice address.
        /// </summary>
        [Description("InvoiceAddress")]
        InvoiceAddress = 256,
        /// <summary>
        /// Include the invoice contact.
        /// </summary>
        [Description("InvoiceContact")]
        InvoiceContact = 512,
        /// <summary>
        /// Include the delivery address.
        /// </summary>
        [Description("DeliveryAddress")]
        DeliveryAddress = 1024,
        /// <summary>
        /// Include the delivery contact.
        /// </summary>
        [Description("DeliveryContact")]
        DeliveryContact = 2048,
        /// <summary>
        /// Include the journal.
        /// </summary>
        [Description("Journal")]
        Journal = 4096,
        /// <summary>
        /// Include the turnover employee.
        /// </summary>
        [Description("TurnoverEmployee")]
        TurnoverEmployee = 8192,
        /// <summary>
        /// Include the invoice debit customer.
        /// </summary>
        [Description("InvoiceDebitCustomer")]
        InvoiceDebitCustomer = 16384,

        /*
        /// <summary>
        /// Include the original workstation.
        /// </summary>
        [Description("OriginalWorkstation")]
        OriginalWorkstation = 32768,
        /// <summary>
        /// Include the original drawer.
        /// </summary>
        [Description("OriginalDrawer")]
        OriginalDrawer = 65536,
        */

        /// <summary>
        /// Include the status employee.
        /// </summary>
        [Description("StatusEmployee")]
        StatusEmployee = 131072,
        /// <summary>
        /// Include the size-color on the order details.
        /// </summary>
        [Description("ProductSizeColor (on Details)")]
        ProductSizeColor = 262144,
        /// <summary>
        /// Include the brand on the order details.
        /// </summary>
        [Description("Brand (on Details)")]
        Brand = 524288,
        /// <summary>
        /// Include the VAT on the order details.
        /// </summary>
        [Description("Vat (on Details)")]
        Vat = 1048576,
        /// <summary>
        /// Include the stock office on the order details.
        /// </summary>
        [Description("StockOffice (on Details)")]
        StockOffice = 2097152,
        /// <summary>
        /// Include the extra product costs on the order details.
        /// </summary>
        [Description("ExtraProductCosts (on Details)")]
        ExtraProductCosts = 4194304,
    }
}
