using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<TransactionResults> FindTransaction(TransactionFilters filters, CancellationToken cancel = default)
        {
            return FindSomething<TransactionResults, TransactionFilters>(filters, cancel, "/VenditPublicApi/Transactions/Find");
        }

        public Task<TransactionResults> FindTransaction(TransactionFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
        {
            return FindSomething<TransactionResults, TransactionFilters>(new TransactionFilters(new TransactionFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Transactions/Find");
        }

        public Task<Transaction> GetTransaction(int id, CancellationToken cancel = default)
        {
            return GetSomething<Transaction>(id.ToString(), cancel, "/VenditPublicApi/Transactions/");
        }

        public Task<Transaction[]> GetTransactions(params int[] ids)
        {
            return GetTransactions(CancellationToken.None, ids);
        }

        public Task<Transaction[]> GetTransactions(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Transaction, int>(ids, cancel, "/VenditPublicApi/Transactions");
        }

        public Task<long[]> GetTransactionIdsForCustomer(int customerId, CancellationToken cancel = default)
        {
            return GetSomething<long[]>(customerId.ToString(), cancel, "/VenditPublicApi/Transactions/GetForCustomer");
        }

        public Task<Transaction> GetTransactionWithDetails(int id, CancellationToken cancel = default)
        {
            return GetSomething<Transaction>(id.ToString(), cancel, "/VenditPublicApi/Transactions/GetWithDetails");
        }
    }
}
