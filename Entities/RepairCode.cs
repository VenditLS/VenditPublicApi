using System;
using VenditPublicSdk.Entities.Internal;

namespace VenditPublicSdk.Entities
{
    [Serializable]
    public class RepairCode : ICloneable
    {
        public int RepairCodeHeaderId { get; set; }

        public Results<RepairCodeDetail> Details { get; set; }

        public int? BrancheId { get; set; }
        public string HeaderGroupCode { get; set; }
        public string HeaderGroupDescription { get; set; }
        public string ServiceTypeDescription { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public RepairCode Clone()
        {
            var ret = new RepairCode
            {
                RepairCodeHeaderId = RepairCodeHeaderId,
                BrancheId = BrancheId,
                HeaderGroupCode = HeaderGroupCode,
                HeaderGroupDescription = HeaderGroupDescription,
                ServiceTypeDescription = ServiceTypeDescription
            };

            if (Details != null)
            {
                ret.Details = new Results<RepairCodeDetail>(Details.Items.Length);
                for (int t = Details.Items.Length - 1; t >= 0; t--)
                    ret.Details.Items[t] = Details.Items[t].Clone();
            }

            return ret;
        }

        public override string ToString()
        {
            return $"{HeaderGroupCode} {HeaderGroupDescription} {ServiceTypeDescription}";
        }
    }
}