using System;
using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Import;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Entities.Lookups;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public ProductsSection Products;

        public class ProductsSection
        {
            private VenditPublicClient _client;

            internal ProductsSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<ProductResults> FindProduct(ProductFilters filters, int officeId = 0, CancellationToken cancel = default)
            {
                string url = "/VenditPublicApi/Products/Find";
                if (officeId != 0)
                    url = $"{url}?officeId={officeId}";
                return _client.FindSomething<ProductResults, ProductFilters>(filters, cancel, url);
            }

            public Task<ProductResults> FindProduct(ProductFields field, object value, FilterComparison filterComparison, int officeId = 0, CancellationToken cancel = default)
            {
                string url = "/VenditPublicApi/Products/Find";
                if (officeId != 0)
                    url = $"{url}?officeId={officeId}";
                return _client.FindSomething<ProductResults, ProductFilters>(new ProductFilters(new ProductFilter(field, value, filterComparison)), cancel, url);
            }

            public Task<Product> GetProduct(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Product>(id.ToString(), cancel, "/VenditPublicApi/Products/");
            }

            public Task<Product[]> GetProducts(params int[] ids)
            {
                return GetProducts(CancellationToken.None, ids);
            }

            public Task<Product[]> GetProducts(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Product, int>(ids, cancel, "/VenditPublicApi/Products");
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
                return _client.GetMultiple<ProductAttribute>(cancel, $"/VenditPublicApi/Products/{productId}/GetAttributes");
            }

            /// <summary>
            /// Get all possible attributes that can belong to a product
            /// </summary>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>Collection of AttributeDefinitions</returns>
            public Task<AttributeDefinition[]> GetAllAttributeDefinitions(CancellationToken cancel = default)
            {
                return _client.GetMultiple<AttributeDefinition>(cancel, string.Concat("/VenditPublicApi/Products/GetAllAttributeDefinitions"));
            }

            // --- ProductGroups

            public Task<ProductGroup> GetProductGroup(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductGroup>(id.ToString(), cancel, "/VenditPublicApi/ProductGroups/");
            }

            public Task<ProductGroup[]> GetProductGroups(params int[] ids)
            {
                return GetProductGroups(CancellationToken.None, ids);
            }

            public Task<ProductGroup[]> GetProductGroups(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<ProductGroup, int>(ids, cancel, "/VenditPublicApi/ProductGroups");
            }

            // --- ProductSizeColors


            public Task<ProductSizeColor[]> GetSizeColorsForProduct(int productId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<ProductSizeColor>(cancel, $"/VenditPublicApi/ProductSizeColors/GetProductSizeColors/{productId}");
            }

            public Task<ProductSizeColor> GetProductSizeColor(int sizeColorId, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductSizeColor>(sizeColorId.ToString(), cancel, "/VenditPublicApi/ProductSizeColors/");
            }

            public Task<ProductSizeColor[]> GetProductSizeColors(params int[] sizeColorIds)
            {
                return GetProductSizeColors(CancellationToken.None, sizeColorIds);
            }

            public Task<ProductSizeColor[]> GetProductSizeColors(CancellationToken cancel, params int[] sizeColorIds)
            {
                return _client.GetMultiple<ProductSizeColor, int>(sizeColorIds, cancel, "/VenditPublicApi/ProductSizeColors");
            }

            /// <summary>
            /// Get Barcodes belonging to a product
            /// </summary>
            /// <param name="productId">Product ID</param>
            /// <param name="sizeColorId">Size-Color Id </param>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>Collection of barcodes</returns>
            public async Task<ProductBarcode[]> GetBarcodes(int productId, int sizeColorId = 0, CancellationToken cancel = default)
            {
                Results<ProductBarcode> items = await _client.GetSomething<Results<ProductBarcode>>(cancel, $"/VenditPublicApi/Products/{productId}/GetBarcodes/{sizeColorId}");
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
                Results<ProductSalesPrice> items = await _client.GetSomething<Results<ProductSalesPrice>>(cancel, $"/VenditPublicApi/Products/{productId}/GetPrices/{sizeColorId}/{officeId}");
                return items.Items;
            }

            /// <summary>
            /// Returns purchase prices of the specified product, note that GetSuppliers includes this info together with the supplier order numbers
            /// </summary>
            /// <param name="productId">Product ID</param>
            /// <param name="sizeColorId">(optional) Size-Color Id, if left 0 prices for multiple size-color's will be returned where deviating prices are defined.</param>
            /// <param name="officeId">(optional) Office ID, if 0 (default) then the office assigned to the API-key will be used, if -1 prices for all offices will be returned.</param>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>List of purchase-prices</returns>
            public async Task<ProductPurchasePrice[]> GetPurchasePrices(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
            {
                Results<ProductPurchasePrice> items = await _client.GetSomething<Results<ProductPurchasePrice>>(cancel, $"/VenditPublicApi/Products/{productId}/GetPurchasePrices/{sizeColorId}/{officeId}");
                return items.Items;
            }

            /// <summary>
            /// Returns suppliers of the specified product
            /// </summary>
            /// <param name="productId">Product ID</param>
            /// <param name="sizeColorId">(optional) Size-Color Id, if left 0 prices for multiple size-color's will be returned where deviating prices are defined.</param>
            /// <param name="officeId">(optional) Office ID, if 0 (default) then the office assigned to the API-key will be used, if -1 prices for all offices will be returned.</param>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>List of suppliers and the supplier product numbers, including purchase price (if user has sufficient rights)</returns>
            public async Task<ProductSupplier[]> GetSuppliers(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
            {
                Results<ProductSupplier> items = await _client.GetSomething<Results<ProductSupplier>>(cancel, $"/VenditPublicApi/Products/{productId}/GetSuppliers/{sizeColorId}/{officeId}");
                return items.Items;
            }

            // --- AvailabilityStatuses

            public Task<AvailabilityStatus> GetAvailabilityStatus(int statusId, CancellationToken cancel = default)
            {
                return _client.GetSomething<AvailabilityStatus>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/AvailabilityStatuses/");
            }

            public Task<AvailabilityStatus[]> GetAvailabilityStatuses(params int[] ids)
            {
                return GetAvailabilityStatuses(CancellationToken.None, ids);
            }

            public Task<AvailabilityStatus[]> GetAvailabilityStatuses(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<AvailabilityStatus, int>(ids, cancel, "/VenditPublicApi/Lookups/AvailabilityStatuses/");
            }

            public Task<AvailabilityStatus[]> GetAllAvailabilityStatuses(CancellationToken cancel = default)
            {
                return _client.GetAll<AvailabilityStatus>(cancel, "/VenditPublicApi/Lookups/AvailabilityStatuses/");
            }

            public Task UpdateAvailabilityStatus(int productId, int newAvailabilityStatusId, CancellationToken cancel = default)
            {
                return _client.Put(cancel, $"/VenditPublicApi/Products/UpdateAvailabilityStatus/{productId}/{newAvailabilityStatusId}");
            }

            // --- Action prices

            public Task<ProductActionPrice> GetProductActionPrice(int actionPriceId, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductActionPrice>(actionPriceId.ToString(), cancel, "/VenditPublicApi/Lookups/ProductActionPrices/");
            }

            public Task<ProductActionPrice[]> GetProductActionPrices(params int[] ids)
            {
                return GetProductActionPrices(CancellationToken.None, ids);
            }

            public Task<ProductActionPrice[]> GetProductActionPrices(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<ProductActionPrice, int>(ids, cancel, "/VenditPublicApi/Lookups/ProductActionPrices/");
            }

            public Task<ProductActionPrice[]> GetAllProductActionPrices(CancellationToken cancel = default)
            {
                return _client.GetAll<ProductActionPrice>(cancel, "/VenditPublicApi/Lookups/ProductActionPrices/");
            }

            public Task<ProductActionPrice[]> GetActionDiscountsForProduct(int productId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<ProductActionPrice>(cancel, $"/VenditPublicApi/Lookups/ProductActionPrices/GetActionDiscountsForProduct/{productId}");
            }

            public Task<ProductActionPrice> GetBestActiveDiscountForProduct(int productId, int sizeColorId, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductActionPrice>(cancel, $"/VenditPublicApi/Lookups/ProductActionPrices/GetBestActiveDiscountForProduct/{productId}/{sizeColorId}");
            }

            // --- Product Kind

            public Task<ProductKind> GetProductKind(int kindId, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductKind>(kindId.ToString(), cancel, "/VenditPublicApi/Lookups/ProductKinds/");
            }

            public Task<ProductKind[]> GetProductKinds(params int[] ids)
            {
                return GetProductKinds(CancellationToken.None, ids);
            }

            public Task<ProductKind[]> GetProductKinds(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<ProductKind, int>(ids, cancel, "/VenditPublicApi/Lookups/ProductKinds/");
            }

            public Task<ProductKind[]> GetAllProductKinds(CancellationToken cancel = default)
            {
                return _client.GetAll<ProductKind>(cancel, "/VenditPublicApi/Lookups/ProductKinds/");
            }

            // --- Sales Unit

            public Task<SalesUnit> GetSalesUnit(int unitId, CancellationToken cancel = default)
            {
                return _client.GetSomething<SalesUnit>(unitId.ToString(), cancel, "/VenditPublicApi/Lookups/SalesUnits/");
            }

            public Task<SalesUnit[]> GetSalesUnits(params int[] ids)
            {
                return GetSalesUnits(CancellationToken.None, ids);
            }

            public Task<SalesUnit[]> GetSalesUnits(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<SalesUnit, int>(ids, cancel, "/VenditPublicApi/Lookups/SalesUnits/");
            }

            public Task<SalesUnit[]> GetAllSalesUnits(CancellationToken cancel = default)
            {
                return _client.GetAll<SalesUnit>(cancel, "/VenditPublicApi/Lookups/SalesUnits/");
            }

            // --- Branche

            public Task<Branche> GetBranche(int brancheId, CancellationToken cancel = default)
            {
                return _client.GetSomething<Branche>(brancheId.ToString(), cancel, "/VenditPublicApi/Lookups/Branches/");
            }

            public Task<Branche[]> GetBranches(params int[] ids)
            {
                return GetBranches(CancellationToken.None, ids);
            }

            public Task<Branche[]> GetBranches(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Branche, int>(ids, cancel, "/VenditPublicApi/Lookups/Branches/");
            }

            public Task<Branche[]> GetAllBranches(CancellationToken cancel = default)
            {
                return _client.GetAll<Branche>(cancel, "/VenditPublicApi/Lookups/Branches/");
            }

            // --- Vat

            public Task<ProductVat[]> GetVat(int productId, int officeId, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductVat[]>(cancel, $"/VenditPublicApi/Products/{productId}/GetVat/{officeId}");
            }

            public Task<ProductVat[]> GetVat(int productId, CancellationToken cancel = default)
            {
                return _client.GetSomething<ProductVat[]>(cancel, $"/VenditPublicApi/Products/{productId}/GetVat");
            }

            public Task<Vat> GetVatDefinition(int VatId, CancellationToken cancel = default)
            {
                return _client.GetSomething<Vat>(VatId.ToString(), cancel, "/VenditPublicApi/Lookups/VatDefinitions/");
            }

            public Task<Vat[]> GetVatDefinitions(params int[] ids)
            {
                return GetVatDefinitions(CancellationToken.None, ids);
            }

            public Task<Vat[]> GetVatDefinitions(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Vat, int>(ids, cancel, "/VenditPublicApi/Lookups/VatDefinitions/");
            }

            public Task<Vat[]> GetAllVatDefinitions(CancellationToken cancel = default)
            {
                return _client.GetAll<Vat>(cancel, "/VenditPublicApi/Lookups/VatDefinitions/");
            }

            // --- Import

            public async Task<int> ImportProducts(CancellationToken cancel = default, params ImportProduct[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/Products/Import", new Results<ImportProduct>(import));
                int    ret   = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }

            // --- Images

            /* Not yet supported on server side

            /// <summary>
            /// Get a list of images 
            /// </summary>
            /// <param name="productId">Product ID</param>
            /// <param name="sizeColorId">Size-Color Id </param>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>List of image info (most important the Image ID and sort order)</returns>
            public async Task<ProductImageInfo[]> GetProductImageList(int productId, int sizeColorId = 0, CancellationToken cancel = default)
            {
                return await _client.GetMultiple<ProductImageInfo>(cancel, $"/VenditPublicApi/Products/GetProductImageList/{productId}/{sizeColorId}");
            }

            /// <summary>
            /// Get product Image by the ImageId
            /// </summary>
            /// <param name="imageId">Image ID</param>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>Image</returns>
            public async Task<Stream> GetProductImage(int imageId, CancellationToken cancel = default)
            {
                HttpResponseMessage response= await _client.GetRaw(cancel, $"/VenditPublicApi/Products/GetProductImage/{imageId}");
                    return await response.Content.ReadAsStreamAsync();
            }

            /// <summary>
            /// Get the main image of a product (the image with the smallest sort order)
            /// </summary>
            /// <param name="productId">Product ID</param>
            /// <param name="sizeColorId">Size-Color Id </param>
            /// <param name="cancel">Cancellation token</param>
            /// <returns>Image</returns>
            public async Task<Stream> GetMainProductImage(int productId, int sizeColorId = 0, CancellationToken cancel = default)
            {
                HttpResponseMessage response = await _client.GetRaw(cancel, $"/VenditPublicApi/Products/GetMainProductImage/{productId}/{sizeColorId}");
                return await response.Content.ReadAsStreamAsync();
            }

            */
        }
    }
}
