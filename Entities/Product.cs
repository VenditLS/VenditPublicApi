using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class BaseProduct
    {
        public int ProductId { get; set; }
        public int GroupId { get; set; }
        public int BrandId { get; set; }
        public int BrancheId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductType { get; set; }
        public int ProductKindId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSubdescription { get; set; }
        public string AdditionalInfo { get; set; }
        public bool UseStock { get; set; }
        public int SalesVisibilityId { get; set; }
        public int AvailabilityStatusId { get; set; }
        public System.DateTime CreationDatetime { get; set; }
        public bool TradeIn { get; set; }
        public int ProductLabelLayoutId { get; set; }
        public int CabProfileCode { get; set; }
        public bool AllowInvoiceDiscount { get; set; }
        public System.DateTime LastModified { get; set; }
        public bool IsModified { get; set; }
        public string ProductGuid { get; set; }
        public string MemoCommon { get; set; }
        public string MemoEcommerce { get; set; }
        public bool IsDeleted { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }
        public bool UseGroupInvoiceDiscount { get; set; }
        public int SalesUnitId { get; set; }
        public decimal SalesUnitQuantity { get; set; }
        public string HintInfo { get; set; }
        public int ProductLabelSplitLayoutId { get; set; }
        public int ProductLabelShelfLayoutId { get; set; }
        public int EcommerceGroupId { get; set; }
        public string ProductSearchCode { get; set; }
        public int ProductLabelPricetagLayoutId { get; set; }
        public string ProductImageUrl { get; set; }
        public bool DisallowDiscount { get; set; }
        public int ProductLabelActionPriceLayoutId { get; set; }
        public int ProductLabelShelfActionPriceLayoutId { get; set; }
        public int ProductLabelPricetagActionPriceLayoutId { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsBaseProduct { get; set; }
        public bool IsFashioncheque { get; set; }
        public decimal FashionchequeValue { get; set; }
        public int DeliveryFromWarehouse { get; set; }
        public int ProductLabelSaleLayoutId { get; set; }
        public bool IsTcsGiftcard { get; set; }
        public decimal TcsGiftcardValue { get; set; }
        public int PurchaseFromWarehouse { get; set; }
        public int ViaCollectionWarehouse { get; set; }
        public int Bebat { get; set; }
        public int ExtraCostQuantity { get; set; }
        public bool IsScale { get; set; }
        public bool HasServiceProduct { get; set; }
        public bool IsServiceProduct { get; set; }
        public string MintatonPosDealId { get; set; }
        public string AssortmentCode { get; set; }
        public int Warranty { get; set; }
        public decimal ResaleBonus { get; set; }
        public System.DateTime? ResaleStart { get; set; }
        public System.DateTime? ResaleEnd { get; set; }
        public int LinkedProductId { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool CustomerRequired { get; set; }
        public int LinkedSplitProductId { get; set; }
        public int LinkedSplitProductAmount { get; set; }
        public string OriginCountryCode { get; set; }
        public string OriginCountry { get; set; }
        public bool WebshopEnabled { get; set; }
        public bool WebshopOrderable { get; set; }
    }

    [Serializable]
    public class Product : BaseProduct
    {
        public Results<ProductSupplier> Suppliers { get; set; }
        public Results<ProductSalesPrice> SalesPrices { get; set; }
        public Results<ProductVat> ProductVats { get; set; }
    }
}
