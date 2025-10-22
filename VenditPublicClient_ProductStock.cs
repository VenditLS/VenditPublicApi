using System;
using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Reports;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public ProductStockSection ProductStocks;

        public class ProductStockSection
        {
            private VenditPublicClient _client;
            internal ProductStockSection(VenditPublicClient client)
            {
                _client = client;
            }

            // -- Stock

            public Task<ProductStock[]> GetProductStock(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
            {
                return _client.GetMultiple<ProductStock>(cancel, $"/VenditPublicApi/ProductStock/{productId}/{sizeColorId}/{officeId}");
            }

            public Task<ProductSizeColorStock[]> GetChangedStockFromDate(DateTime from, CancellationToken cancel = default)
            {
                long unixMillisec = new DateTimeOffset(from).ToUnixTimeMilliseconds();
                return _client.GetMultiple<ProductSizeColorStock>(cancel, $"/VenditPublicApi/ProductStock/GetChangedStockFromDate/{unixMillisec}");
            }

            public Task<ProductStockDetail[]> GetProductStockDetails(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
            {
                return _client.GetMultiple<ProductStockDetail>(cancel, $"/VenditPublicApi/ProductStock/Details/{productId}/{sizeColorId}/{officeId}");
            }

            public Task<StockWriteOffLogReport[]> GetStockWriteOffLogReportByTimeStamp(long fromUnixMillisec, long toUnixMillisec, int officeId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<StockWriteOffLogReport>(cancel,
                    $"/VenditPublicApi/ProductStock/GetStockWriteOffLogReportByTimeStamp/{fromUnixMillisec}/{toUnixMillisec}/{officeId}");
            }
        }
    }
}
