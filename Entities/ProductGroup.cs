using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductGroup
    {
        public int groupId { get; set; }
        public int? groupNumber1 { get; set; }
        public int? groupNumber2 { get; set; }
        public int? groupNumber3 { get; set; }
        public int? groupNumber4 { get; set; }
        public int? groupNumber5 { get; set; }
        public string groupDescription1 { get; set; }
        public string groupDescription2 { get; set; }
        public string groupDescription3 { get; set; }
        public string groupDescription4 { get; set; }
        public string groupDescription5 { get; set; }
        public int? financialCodeId { get; set; }
        public string groupNumber { get; set; }
        public string groupDescription { get; set; }
        public string groupLinkCode { get; set; }
        public int? cabProfileCode { get; set; }
        public bool allowUserModify { get; set; }
        public bool allowInvoiceDiscount { get; set; }
        public int serviceLayoutId { get; set; }
        public int askIdNumber { get; set; }
        public int disposalFeeId { get; set; }
        public string groupGuid { get; set; }
        public string hintInfo { get; set; }
        public int ecommerceGroupId { get; set; }
        public decimal? bonusDiscountSavingsValue { get; set; }
        public int shippingCostsId { get; set; }
        public int deliveryFromWarehouse { get; set; }
        public decimal? defaultMargin { get; set; }
        public string groupCode { get; set; }
        public int purchaseFromWarehouse { get; set; }
        public int viaCollectionWarehouse { get; set; }
        public int bebat { get; set; }
        public bool isScale { get; set; }
        public string mintatonPosDealId { get; set; }
        public int? stockFinancialCodeId { get; set; }
        public int? costofsalesFinancialCodeId { get; set; }
    }
}
