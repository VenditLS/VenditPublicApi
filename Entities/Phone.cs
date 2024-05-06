using System;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class Phone
    {
        public int    phoneId      { get; set; }
        public string phoneNumber  { get; set; }
        public int    phoneTypeId  { get; set; }
        public bool   defaultPhone { get; set; }
        public string dialingCode  { get; set; }
    }
}
