using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Color
    {
        public int ColorId { get; set; }
        public int ColorGroupId { get; set; }
        public string ColorName { get; set; }
        public string ColorSubstitute { get; set; }
        public string ColorCode { get; set; }

        public override string ToString()
        {
            return ColorName;
        }
    }
}
