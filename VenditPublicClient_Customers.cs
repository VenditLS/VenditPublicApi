using System.Threading;
using System.Threading.Tasks;
using VenditPublicSdk.Base;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Find;

namespace VenditPublicSdk
{
    public partial class VenditPublicClient : VenditPublicClientBase
    {
        public Task<CustomerResults> FindCustomer(CustomerFilters filters, CancellationToken cancel = default)
        {
            return FindSomething<CustomerResults, CustomerFilters>(filters, cancel, "/VenditPublicApi/Customers/Find");
        }

        public Task<CustomerResults> FindCustomer(CustomerFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
        {
            return FindSomething<CustomerResults, CustomerFilters>(new CustomerFilters(new CustomerFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Customers/Find");
        }

        public Task<Customer> GetCustomer(int id, CancellationToken cancel = default)
        {
            return GetSomething<Customer>(id.ToString(), cancel, "/VenditPublicApi/Customers/");
        }

        public Task<Customer[]> GetCustomers(params int[] ids)
        {
            return GetCustomers(CancellationToken.None, ids);
        }

        public Task<Customer[]> GetCustomers(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Customer, int>(ids, cancel, "/VenditPublicApi/Customers");
        }

        public Task<Address[]> GetCustomerAddresses(int customerId, CancellationToken cancel = default)
        {
            return GetMultiple<Address>(cancel, string.Concat("/VenditPublicApi/Customers/GetAddresses/", customerId));
        }

        // Address has GetContacts

        //public Task<Contact[]> GetCustomerContacts(int customerId, CancellationToken cancel = default)
        //{
        //    return GetMultiple<Contact>(cancel, string.Concat("/VenditPublicApi/Customers/GetContacts/", customerId));
        //}

        // --- Addresses

        public Task<Address> GetAddress(int id, CancellationToken cancel = default)
        {
            return GetSomething<Address>(id.ToString(), cancel, "/VenditPublicApi/Addresses/");
        }

        public Task<Address[]> GetAddresses(params int[] ids)
        {
            return GetAddresses(CancellationToken.None, ids);
        }

        public Task<Address[]> GetAddresses(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Address, int>(ids, cancel, "/VenditPublicApi/Addresses");
        }

        public Task<Contact[]> GetAddressContacts(int addressId, CancellationToken cancel = default)
        {
            return GetMultiple<Contact>(cancel, string.Concat("/VenditPublicApi/Addresses/GetContacts/", addressId));
        }

        // --- Contacts

        public Task<Contact> GetContact(int id, CancellationToken cancel = default)
        {
            return GetSomething<Contact>(id.ToString(), cancel, "/VenditPublicApi/Contacts/");
        }

        public Task<Contact[]> GetContacts(params int[] ids)
        {
            return GetContacts(CancellationToken.None, ids);
        }

        public Task<Contact[]> GetContacts(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Contact, int>(ids, cancel, "/VenditPublicApi/Contacts");
        }
        
        // --- Phones

        public Task<Phone> GetPhone(int id, CancellationToken cancel = default)
        {
            return GetSomething<Phone>(id.ToString(), cancel, "/VenditPublicApi/Phones/");
        }

        public Task<Phone[]> GetPhones(params int[] ids)
        {
            return GetPhones(CancellationToken.None, ids);
        }

        public Task<Phone[]> GetPhones(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Phone, int>(ids, cancel, "/VenditPublicApi/Phones");
        }
    }
}
