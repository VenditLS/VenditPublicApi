using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<RepairResults> FindRepair(RepairFilters filters, int officeId =0, CancellationToken cancel = default)
        {
            string url = "/VenditPublicApi/Repairs/Find";
            if (officeId != 0)
                url = string.Concat(url, "?officeId=", officeId);
            return FindSomething<RepairResults, RepairFilters>(filters, cancel, url);
        }

        public Task<RepairResults> FindRepair(RepairFields field, object value, FilterComparison filterComparison, int officeId = 0, CancellationToken cancel = default)
        {
            string url = "/VenditPublicApi/Repairs/Find";
            if (officeId != 0)
                url = string.Concat(url, "?officeId=", officeId);
            return FindSomething<RepairResults, RepairFilters>(new RepairFilters(new RepairFilter(field, value, filterComparison)), cancel, url);
        }

        public Task<Repair> GetRepair(int id, CancellationToken cancel = default)
        {
            return GetSomething<Repair>(id.ToString(), cancel, "/VenditPublicApi/Repairs/");
        }

        public Task<Repair[]> GetRepairs(params int[] ids)
        {
            return GetRepairs(CancellationToken.None, ids);
        }

        public Task<Repair[]> GetRepairs(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Repair, int>(ids, cancel, "/VenditPublicApi/Repairs");
        }

        public Task<int[]> GetRepairIdsForCustomer(int customerId, CancellationToken cancel = default)
        {
            return GetSomething<int[]>(customerId.ToString(), cancel, "/VenditPublicApi/Repairs/GetForCustomer");
        }

        public Task<Repair> GetRepairWithDetails(int id, CancellationToken cancel = default)
        {
            return GetSomething<Repair>(id.ToString(), cancel, "/VenditPublicApi/Repairs/GetWithDetails");
        }
    }
}
