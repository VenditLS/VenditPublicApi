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

By default all criteria will intersect each other's results (the `AND` operation is allpied between all criteria). This can bechanged by setting the Operator to `OR`, for example when looking for orders containing items with the brands "Contoso" or "Northwind":

```C#
OrderFilters filters = new OrderFilters(
    new OrderFilter(OrderFields.BrandName, "Contoso", FilterComparison.Contains),
    new OrderFilter(OrderFields.BrandName, "Northwind", FilterComparison.Contains)
){
    Operator = FilterOperator.Or
};

orderIds = await client.Orders.FindOrder(filters);
```

At this time it is not possible to create complex descision trees with one branch of criteria having an `AND` operator and another branche having an `OR` operator.

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

A frequently asked question is:
> Why can't we have `GetMultiple___WithDetails()`.

There is an architectual reason for that: The Database is the least scalable component in a chain of services. A query with many joins is prone to take allot more time than one with few joins. A long running complex query can cause problems for other queries that may be more important (registering a sale or an order is generally considered more important than collecting search results). At Vendit we have no control over how 3rd parties are going to call our API's. So for the public API's we have a best effort ploicy to prevent heavy load on the database in a single transaction.

It is true that multiple `Get___WithDetails()` calls have a greater overhead than one call for multiple results would have, however most of that overhead is on the scalable part of our system (the services queueing queries) rather than the database itself. Even when a multitude of small queries are called multi-threaded, the important jobs can be done in-between because the smaller ones do not form one behometh transaction. When a timeouts occur it is a double loss because all the work the database already had done is also lost and will likely have to be done over.
