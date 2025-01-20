using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductGroup
    {
        public int GroupId { get; set; }
        public int? GroupNumber1 { get; set; }
        public int? GroupNumber2 { get; set; }
        public int? GroupNumber3 { get; set; }
        public int? GroupNumber4 { get; set; }
        public int? GroupNumber5 { get; set; }
        public string GroupDescription1 { get; set; }
        public string GroupDescription2 { get; set; }
        public string GroupDescription3 { get; set; }
        public string GroupDescription4 { get; set; }
        public string GroupDescription5 { get; set; }
        public int? FinancialCodeId { get; set; }
        public string GroupNumber { get; set; }
        public string GroupDescription { get; set; }
        public string GroupLinkCode { get; set; }
        public int? CabProfileCode { get; set; }
        public bool AllowUserModify { get; set; }
        public bool AllowInvoiceDiscount { get; set; }
        public int ServiceLayoutId { get; set; }
        public int AskIdNumber { get; set; }
        public int DisposalFeeId { get; set; }
        public string GroupGuid { get; set; }
        public string HintInfo { get; set; }
        public int EcommerceGroupId { get; set; }
        public decimal? BonusDiscountSavingsValue { get; set; }
        public int ShippingCostsId { get; set; }
        public int DeliveryFromWarehouse { get; set; }
        public decimal? DefaultMargin { get; set; }
        public string GroupCode { get; set; }
        public int PurchaseFromWarehouse { get; set; }
        public int ViaCollectionWarehouse { get; set; }
        public int Bebat { get; set; }
        public bool IsScale { get; set; }
        public string MintatonPosDealId { get; set; }
        public int? StockFinancialCodeId { get; set; }
        public int? CostofsalesFinancialCodeId { get; set; }

        public override string ToString()
        {
            return GroupDescription;
        }
    }
}
