# Finding entities
All key entities have a Find function for querying the database on certain criteria.

This is an example for Orders:

```C#
Task<OrderResults> FindOrder(OrderFilters filters, CancellationToken cancel = default)
```

Most entities will have a shorthand overload for the most common case where only one filter (criteria statement) is applied:

```C#
Task<OrderResults> FindOrder(OrderFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
```

## Criteria
Criteria is put in a collection, in this case of the type `OrderFilters`. For example when today's orders for a specific brand "Contoso" are required, the Criteria collection would be built like this:

```C#
OrderFilters filters = new OrderFilters(
    new OrderFilter(OrderFields.OrderDate, DateTime.Today, FilterComparison.GreaterOrEqual),
    new OrderFilter(OrderFields.BrandName, "Contoso", FilterComparison.Contains)
);

orderIds = await client.Orders.FindOrder(filters);
```

By default all criteria will intersect each other's results (the `AND` operation is applied between all criteria). This can be changed by setting the Operator to `OR`, for example when looking for orders containing items with the brands "Contoso" or "Northwind":

```C#
OrderFilters filters = new OrderFilters(
    new OrderFilter(OrderFields.BrandName, "Contoso", FilterComparison.Contains),
    new OrderFilter(OrderFields.BrandName, "Northwind", FilterComparison.Contains)
){
    Operator = FilterOperator.Or
};

orderIds = await client.Orders.FindOrder(filters);
```

At this time it is not possible to create complex descision trees with one branch of criteria having an `AND` operator and another branch having an `OR` operator.

## Results
Results are a list of ID's returned in pages of 100 at a time. The total number of results is stated in the result with the property `PaginationRowCount`. 

### Pagination
In order to get the next 100 results the identical request should be done again but with an extra parameter `PaginationOffset`:

```C#
OrderFilters filters = new OrderFilters(
    new OrderFilter(OrderFields.BrandName, "Contoso", FilterComparison.Contains),
    new OrderFilter(OrderFields.BrandName, "Northwind", FilterComparison.Contains)
){
    Operator = FilterOperator.Or,
    PaginationOffset = 100
};

nextOrderIds = await client.Orders.FindOrder(filters);
```

The result will also echo the requested `PaginationOffset` in the result.

### Getting full results
In order to get the entities new calls will be needed using the ID's returned from `Find`. The calls prefixed with `Get___()` and `Get___s()` (multiple at once) will return the Entity "trunk" without "detail branches". `Get___WithDetails()` will also get details such as Order rows and downpayments.

See also [Faq: Why can't we have `GetMultiple___WithDetails()`](Faq.md).