# Frequently Asked Questions

## Why can't we have `GetMultiple___WithDetails()`.

There is an architectural reason for that: The Database is the least scalable component in a chain of services. A query with many joins is prone to take allot more time than one with few joins. A long running complex query can cause problems for other queries that may be more important (registering a sale or an order is generally considered more important than collecting search results). At Vendit we have no control over how 3rd parties are going to call our API's. So for the public API's we have a best effort policy to prevent heavy load on the database in a single transaction.

It is true that multiple `Get___WithDetails()` calls have a greater overhead than one call for multiple results would have, however most of that overhead is on the scalable part of our system (the services queueing queries) rather than the database itself. Even when a multitude of small queries are called multi-threaded, the important jobs can be done in-between because the smaller ones do not form one behemoth transaction. When a timeouts occur it is a double loss because all the work the database already had done is also lost and will likely have to be done over.

## Why is the API so slow?

If the API is only processing a few requests per minute then the most probable cause is that it is getting a new token for each API call. There is a rate limiter on `GetToken()` that will slow things down considerably. Please re-use tokens for at least a day or until they expire.

This behavior undermines the purpose of using tokens in the first place. Tokens are used in order to reduce the number of times credentials need to be exchanged.

Older tokens will expire as soon as new ones are requested with a small margin in order to facilitate load balancing (each node can get their own token). If you have multiple processes using the API, it may be a great idea to use new public API-keys for each process so that they do not invalidate each other's tokens. Linking different users to each API-key may also help determine which process was involved in audit logs.
