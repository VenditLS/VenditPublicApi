using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<ProductResults> FindProduct(ProductFilters filters, int officeId = 0, CancellationToken cancel = default)
        {
            string url = "/VenditPublicApi/Products/Find";
            if (officeId != 0)
                url = string.Concat(url, "?officeId=", officeId);
            return FindSomething<ProductResults, ProductFilters>(filters, cancel, url);
        }

        public Task<ProductResults> FindProduct(ProductFields field, object value, FilterComparison filterComparison, int officeId = 0, CancellationToken cancel = default)
        {
            string url = "/VenditPublicApi/Products/Find";
            if (officeId != 0)
                url = string.Concat(url, "?officeId=", officeId);
            return FindSomething<ProductResults, ProductFilters>(new ProductFilters(new ProductFilter(field, value, filterComparison)), cancel, url);
        }

        public Task<Product> GetProduct(int id, CancellationToken cancel = default)
        {
            return GetSomething<Product>(id.ToString(), cancel, "/VenditPublicApi/Products/");
        }

        public Task<Product[]> GetProducts(params int[] ids)
        {
            return GetProducts(CancellationToken.None, ids);
        }

        public Task<Product[]> GetProducts(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Product, int>(ids, cancel, "/VenditPublicApi/Products");
        }

        public Task<ProductStock[]> GetProductStock(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
        {
            return GetMultiple<ProductStock>(cancel, string.Concat("/VenditPublicApi/ProductStock/", productId, "/", sizeColorId, "/", officeId));
        }

        // --- Attributes

        /// <summary>
        /// Gets all attributes belonging to the product
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <param name="cancel">Cancellation token</param>
        /// <returns>Collection of Attributes</returns>
        public Task<ProductAttribute[]> GetProductAttributes(int productId, CancellationToken cancel = default)
        {
            return GetMultiple<ProductAttribute>(cancel, string.Concat("/VenditPublicApi/Products/", productId.ToString(), "/GetAttributes"));
        }
        
        // --- ProductGroups

        public Task<ProductGroup> GetProductGroup(int id, CancellationToken cancel = default)
        {
            return GetSomething<ProductGroup>(id.ToString(), cancel, "/VenditPublicApi/ProductGroups/");
        }

        public Task<ProductGroup[]> GetProductGroups(params int[] ids)
        {
            return GetProductGroups(CancellationToken.None, ids);
        }

        public Task<ProductGroup[]> GetProductGroups(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<ProductGroup, int>(ids, cancel, "/VenditPublicApi/ProductGroups");
        }

        // --- ProductSizeColors


        public Task<ProductSizeColor[]> GetSizeColorsForProduct(int productId, CancellationToken cancel = default)
        {
            return GetMultiple<ProductSizeColor>(cancel, "/VenditPublicApi/ProductSizeColors/GetProductSizeColors/" + productId);
        }

        public Task<ProductSizeColor> GetProductSizeColor(int sizeColorId, CancellationToken cancel = default)
        {
            return GetSomething<ProductSizeColor>(sizeColorId.ToString(), cancel, "/VenditPublicApi/ProductSizeColors/");
        }

        public Task<ProductSizeColor[]> GetProductSizeColors(params int[] sizeColorIds)
        {
            return GetProductSizeColors(CancellationToken.None, sizeColorIds);
        }

        public Task<ProductSizeColor[]> GetProductSizeColors(CancellationToken cancel, params int[] sizeColorIds)
        {
            return GetMultiple<ProductSizeColor, int>(sizeColorIds, cancel, "/VenditPublicApi/ProductSizeColors");
        }

        /// <summary>
        /// Get Barcodes belonging to a product
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <param name="sizeColorId">Size-Color Id </param>
        /// <param name="cancel">Cancellation token</param>
        /// <returns>Collection of barcodes</returns>
        public async Task<ProductBarcode[]> GetBarcodes(int productId, int sizeColorId=0, CancellationToken cancel=default)
        {
            Results<ProductBarcode> items = await GetSomething<Results<ProductBarcode>>(cancel, string.Concat("/VenditPublicApi/Products/", productId, "/GetBarcodes/", sizeColorId));
            return items.Items;
        }

        /// <summary>
        /// Returns sales prices of the specified product
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <param name="sizeColorId">(optional) Size-Color Id, if left 0 prices for multiple size-color's will be returned where deviating prices are defined.</param>
        /// <param name="officeId">(optional) Office ID, if 0 (default) then the office assigned to the API-key will be used, if -1 prices for all offices will be returned.</param>
        /// <param name="cancel">Cancellation token</param>
        /// <returns>List of sales-prices</returns>
        public async Task<ProductSalesPrice[]> GetPrices(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
        {
            Results<ProductSalesPrice> items = await GetSomething<Results<ProductSalesPrice>>(cancel, string.Concat("/VenditPublicApi/Products/", productId, "/GetPrices/", sizeColorId, "/", officeId));
            return items.Items;
        }
    }
}
