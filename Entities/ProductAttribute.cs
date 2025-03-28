﻿using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public int AttributeId { get; set; }
        public string ProductAttributeValue { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeRegexp { get; set; }
        public bool AttributeRequired { get; set; }
        public string AttributeDescription { get; set; }
        public int SortOrder { get; set; }

        public override string ToString()
        {
            return $"[{AttributeCode}] {AttributeDescription} = {ProductAttributeValue}";
        }
    }

    public class AttributeDefinition
    {
        public int AttributeId { get; set; }
        public int BrancheId { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeRegexp { get; set; }
        public bool AttributeRequired { get; set; }
        public string AttributeDescription { get; set; }
        public int SortOrder { get; set; }

        public override string ToString()
        {
            return AttributeDescription;
        }
    }
}
