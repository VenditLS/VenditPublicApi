﻿using System;
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

        // -- Stock

        public Task<ProductStock[]> GetProductStock(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
        {
            return GetMultiple<ProductStock>(cancel, string.Concat("/VenditPublicApi/ProductStock/", productId, "/", sizeColorId, "/", officeId));
        }

        public Task<ProductSizeColorStock[]> GetChangedStockFromDate(DateTime from, CancellationToken cancel = default)
        {
            long unixMillisec = new DateTimeOffset(from).ToUnixTimeMilliseconds();
            return GetMultiple<ProductSizeColorStock>(cancel, string.Concat("/VenditPublicApi/ProductStock/GetChangedStockFromDate/", unixMillisec));
        }

        public Task<ProductStockDetail[]> GetProductStockDetails(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
        {
            return GetMultiple<ProductStockDetail>(cancel, string.Concat("/VenditPublicApi/ProductStock/Details/", productId, "/", sizeColorId, "/", officeId));
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

        /// <summary>
        /// Get all possible attributes that can belong to a product
        /// </summary>
        /// <param name="cancel">Cancellation token</param>
        /// <returns>Collection of AttributeDefinitions</returns>
        public Task<AttributeDefinition[]> GetAllAttributeDefinitions(CancellationToken cancel = default)
        {
            return GetMultiple<AttributeDefinition>(cancel, string.Concat("/VenditPublicApi/Products/GetAllAttributeDefinitions"));
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
        public async Task<ProductBarcode[]> GetBarcodes(int productId, int sizeColorId = 0, CancellationToken cancel = default)
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

        /// <summary>
        /// Returns purchase prices of the specified product
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <param name="sizeColorId">(optional) Size-Color Id, if left 0 prices for multiple size-color's will be returned where deviating prices are defined.</param>
        /// <param name="officeId">(optional) Office ID, if 0 (default) then the office assigned to the API-key will be used, if -1 prices for all offices will be returned.</param>
        /// <param name="cancel">Cancellation token</param>
        /// <returns>List of purchase-prices</returns>
        public async Task<ProductPurchasePrice[]> GetPurchasePrices(int productId, int sizeColorId = 0, int officeId = 0, CancellationToken cancel = default)
        {
            Results<ProductPurchasePrice> items = await GetSomething<Results<ProductPurchasePrice>>(cancel, string.Concat("/VenditPublicApi/Products/", productId, "/GetPurchasePrices/", sizeColorId, "/", officeId));
            return items.Items;
        }

        // --- AvailabilityStatuses

        public Task<AvailabilityStatus> GetAvailabilityStatus(int statusId, CancellationToken cancel = default)
        {
            return GetSomething<AvailabilityStatus>(statusId.ToString(), cancel, "/VenditPublicApi/Lookups/AvailabilityStatuses/");
        }

        public Task<AvailabilityStatus[]> GetAvailabilityStatuses(params int[] ids)
        {
            return GetAvailabilityStatuses(CancellationToken.None, ids);
        }

        public Task<AvailabilityStatus[]> GetAvailabilityStatuses(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<AvailabilityStatus, int>(ids, cancel, "/VenditPublicApi/Lookups/AvailabilityStatuses/");
        }

        public Task<AvailabilityStatus[]> GetAllAvailabilityStatuses(CancellationToken cancel = default)
        {
            return GetAll<AvailabilityStatus>(cancel, "/VenditPublicApi/Lookups/AvailabilityStatuses/");
        }

        // --- Action prices

        public Task<ProductActionPrice> GetProductActionPrice(int actionPriceId, CancellationToken cancel = default)
        {
            return GetSomething<ProductActionPrice>(actionPriceId.ToString(), cancel, "/VenditPublicApi/Lookups/ProductActionPrices/");
        }

        public Task<ProductActionPrice[]> GetProductActionPrices(params int[] ids)
        {
            return GetProductActionPrices(CancellationToken.None, ids);
        }

        public Task<ProductActionPrice[]> GetProductActionPrices(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<ProductActionPrice, int>(ids, cancel, "/VenditPublicApi/Lookups/ProductActionPrices/");
        }

        public Task<ProductActionPrice[]> GetAllProductActionPrices(CancellationToken cancel = default)
        {
            return GetAll<ProductActionPrice>(cancel, "/VenditPublicApi/Lookups/ProductActionPrices/");
        }

        public Task<ProductActionPrice[]> GetActionDiscountsForProduct(int productId, CancellationToken cancel = default)
        {
            return GetMultiple<ProductActionPrice>(cancel, "/VenditPublicApi/Lookups/ProductActionPrices/GetActionDiscountsForProduct/" + productId);
        }

        public Task<ProductActionPrice> GetBestActiveDiscountForProduct(int productId, int sizeColorId, CancellationToken cancel = default)
        {
            return GetSomething<ProductActionPrice>(cancel, string.Concat("/VenditPublicApi/Lookups/ProductActionPrices/GetBestActiveDiscountForProduct/", productId, "/", sizeColorId));
        }

        // --- Product Kind

        public Task<ProductKind> GetProductKind(int kindId, CancellationToken cancel = default)
        {
            return GetSomething<ProductKind>(kindId.ToString(), cancel, "/VenditPublicApi/Lookups/ProductKinds/");
        }

        public Task<ProductKind[]> GetProductKinds(params int[] ids)
        {
            return GetProductKinds(CancellationToken.None, ids);
        }

        public Task<ProductKind[]> GetProductKinds(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<ProductKind, int>(ids, cancel, "/VenditPublicApi/Lookups/ProductKinds/");
        }

        public Task<ProductKind[]> GetAllProductKinds(CancellationToken cancel = default)
        {
            return GetAll<ProductKind>(cancel, "/VenditPublicApi/Lookups/ProductKinds/");
        }

        // --- Sales Unit

        public Task<SalesUnit> GetSalesUnit(int unitId, CancellationToken cancel = default)
        {
            return GetSomething<SalesUnit>(unitId.ToString(), cancel, "/VenditPublicApi/Lookups/SalesUnits/");
        }

        public Task<SalesUnit[]> GetSalesUnits(params int[] ids)
        {
            return GetSalesUnits(CancellationToken.None, ids);
        }

        public Task<SalesUnit[]> GetSalesUnits(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<SalesUnit, int>(ids, cancel, "/VenditPublicApi/Lookups/SalesUnits/");
        }

        public Task<SalesUnit[]> GetAllSalesUnits(CancellationToken cancel = default)
        {
            return GetAll<SalesUnit>(cancel, "/VenditPublicApi/Lookups/SalesUnits/");
        }

        // --- Branche

        public Task<Branche> GetBranche(int brancheId, CancellationToken cancel = default)
        {
            return GetSomething<Branche>(brancheId.ToString(), cancel, "/VenditPublicApi/Lookups/Branches/");
        }

        public Task<Branche[]> GetBranches(params int[] ids)
        {
            return GetBranches(CancellationToken.None, ids);
        }

        public Task<Branche[]> GetBranches(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Branche, int>(ids, cancel, "/VenditPublicApi/Lookups/Branches/");
        }

        public Task<Branche[]> GetAllBranches(CancellationToken cancel = default)
        {
            return GetAll<Branche>(cancel, "/VenditPublicApi/Lookups/Branches/");
        }

        // --- Import

        public async Task<int> ImportProducts(CancellationToken cancel = default, params ImportProduct[] import)
        {
            if (import is null || import.Length < 1)
                return 0;

            string reply = await Post(cancel, "/VenditPublicApi/Products/Import", new Results<ImportProduct>(import));
            int    ret   = 0;
            if (int.TryParse(reply, out ret))
                return ret;

            return -1;
        }

    }
}
