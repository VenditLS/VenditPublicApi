namespace VenditPublicSdk.Entities
{
    public class ExtraProductCosts
    {
        public int ExtraProductCostsId { get; set; }

        public decimal PurchasePriceEx { get; set; }

        public int? ProductId { get; set; }

        public int? CountryId { get; set; }

        public bool ExtraProductCostsRecharge { get; set; }

        public int? ExtraProductCostsTypeId { get; set; }

        public string ExtraProductCostsTypeDescription { get; set; }

        public bool ExtraProductCostsIsReadonly { get; set; }

        public int? LinkedProductId { get; set; }

        public int? LinkedGroupId { get; set; }
    }
}
