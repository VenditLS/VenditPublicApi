using System;

namespace VenditPublicSdk.Entities.Lookups
{
    [Serializable]
    public class ContactFunction
    {
        public int FunctionId { get; set; }
        public string FunctionDescription { get; set; }

        public override string ToString()
        {
            return FunctionDescription;
        }
    }
}
