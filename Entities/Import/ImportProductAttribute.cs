using System;

namespace VenditPublicSdk.Entities.Import
{
    [Serializable]
    public class ImportProductAttribute: ProductAttribute
    {
        public AttributeDefinition Attribute { get; set; }
    }
}
