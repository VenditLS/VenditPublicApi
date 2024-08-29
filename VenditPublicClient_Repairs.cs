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

        // RepairStatus

        public Task<RepairStatus> GetRepairStatus(int statusId, CancellationToken cancel = default)
        {
            return GetSomething<RepairStatus>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/RepairStatuses/");
        }

        public Task<RepairStatus[]> GetRepairStatuses(params int[] ids)
        {
            return GetRepairStatuses(CancellationToken.None, ids);
        }

        public Task<RepairStatus[]> GetRepairStatuses(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<RepairStatus, int>(ids, cancel, "/VenditPublicApi/Lookups/RepairStatuses/");
        }

        public Task<RepairStatus[]> GetAllRepairStatuses(CancellationToken cancel = default)
        {
            return GetAll<RepairStatus>(cancel, "/VenditPublicApi/Lookups/RepairStatuses/");
        }
    }
}
