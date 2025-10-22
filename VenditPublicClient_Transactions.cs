using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Lookups;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public TransactionsSection Transactions;

        public class TransactionsSection
        {
            private VenditPublicClient _client;

            internal TransactionsSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<TransactionResults> FindTransaction(TransactionFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<TransactionResults, TransactionFilters>(filters, cancel, "/VenditPublicApi/Transactions/Find");
            }

            public Task<TransactionResults> FindTransaction(TransactionFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<TransactionResults, TransactionFilters>(new TransactionFilters(new TransactionFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Transactions/Find");
            }

            public Task<Transaction> GetTransaction(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Transaction>(id.ToString(), cancel, "/VenditPublicApi/Transactions/");
            }

            public Task<Transaction[]> GetTransactions(params int[] ids)
            {
                return GetTransactions(CancellationToken.None, ids);
            }

            public Task<Transaction[]> GetTransactions(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Transaction, int>(ids, cancel, "/VenditPublicApi/Transactions");
            }

            public Task<long[]> GetTransactionIdsForCustomer(int customerId, CancellationToken cancel = default)
            {
                return _client.GetSomething<long[]>(customerId.ToString(), cancel, "/VenditPublicApi/Transactions/GetForCustomer");
            }

            public Task<Transaction> GetTransactionWithDetails(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Transaction>(id.ToString(), cancel, "/VenditPublicApi/Transactions/GetWithDetails");
            }

            // ReturnReason

            public Task<ReturnReason> GetReturnReason(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ReturnReason>(id.ToString(), cancel, "/VenditPublicApi/Lookups/ReturnReasons/");
            }

            public Task<ReturnReason[]> GetReturnReasons(params int[] ids)
            {
                return GetReturnReasons(CancellationToken.None, ids);
            }

            public Task<ReturnReason[]> GetReturnReasons(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<ReturnReason, int>(ids, cancel, "/VenditPublicApi/Lookups/ReturnReasons/");
            }

            public Task<ReturnReason[]> GetAllReturnReasons(CancellationToken cancel = default)
            {
                return _client.GetAll<ReturnReason>(cancel, "/VenditPublicApi/Lookups/ReturnReasons/");
            }
        }
    }
}
