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
        public CustomersSection Customers;

        public class CustomersSection
        {
            private VenditPublicClient _client;

            internal CustomersSection(VenditPublicClient client)
            {
                _client = client;
            }

            public Task<CustomerResults> FindCustomer(CustomerFilters filters, CancellationToken cancel = default)
            {
                return _client.FindSomething<CustomerResults, CustomerFilters>(filters, cancel, "/VenditPublicApi/Customers/Find");
            }

            public Task<CustomerResults> FindCustomer(CustomerFields field, object value, FilterComparison filterComparison, CancellationToken cancel = default)
            {
                return _client.FindSomething<CustomerResults, CustomerFilters>(new CustomerFilters(new CustomerFilter(field, value, filterComparison)), cancel, "/VenditPublicApi/Customers/Find");
            }

            public Task<Customer> GetCustomer(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Customer>(id.ToString(), cancel, "/VenditPublicApi/Customers/");
            }

            public Task<Customer[]> GetCustomers(params int[] ids)
            {
                return GetCustomers(CancellationToken.None, ids);
            }

            public Task<Customer[]> GetCustomers(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Customer, int>(ids, cancel, "/VenditPublicApi/Customers");
            }

            public Task<Address[]> GetCustomerAddresses(int customerId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<Address>(cancel, $"/VenditPublicApi/Customers/GetAddresses/{customerId}");
            }

            // Address has GetContacts

            //public Task<Contact[]> GetCustomerContacts(int customerId, CancellationToken cancel = default)
            //{
            //    return _client.GetMultiple<Contact>(cancel, string.Concat("/VenditPublicApi/Customers/GetContacts/", customerId));
            //}

            // --- Addresses

            public Task<Address> GetAddress(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Address>(id.ToString(), cancel, "/VenditPublicApi/Addresses/");
            }

            public Task<Address[]> GetAddresses(params int[] ids)
            {
                return GetAddresses(CancellationToken.None, ids);
            }

            public Task<Address[]> GetAddresses(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Address, int>(ids, cancel, "/VenditPublicApi/Addresses");
            }

            public Task<Contact[]> GetAddressContacts(int addressId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<Contact>(cancel, $"/VenditPublicApi/Addresses/GetContacts/{addressId}");
            }

            public Task<Phone[]> GetAddressPhones(int addressId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<Phone>(cancel, $"/VenditPublicApi/Addresses/GetPhones/{addressId}");
            }

            // --- Contacts

            public Task<Contact> GetContact(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Contact>(id.ToString(), cancel, "/VenditPublicApi/Contacts/");
            }

            public Task<Contact[]> GetContacts(params int[] ids)
            {
                return GetContacts(CancellationToken.None, ids);
            }

            public Task<Contact[]> GetContacts(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Contact, int>(ids, cancel, "/VenditPublicApi/Contacts");
            }

            public Task<Phone[]> GetContactPhones(int contactId, CancellationToken cancel = default)
            {
                return _client.GetMultiple<Phone>(cancel, $"/VenditPublicApi/Contacts/GetPhones/{contactId}");
            }

            // --- Phones

            public Task<Phone> GetPhone(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Phone>(id.ToString(), cancel, "/VenditPublicApi/Phones/");
            }

            public Task<Phone[]> GetPhones(params int[] ids)
            {
                return GetPhones(CancellationToken.None, ids);
            }

            public Task<Phone[]> GetPhones(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Phone, int>(ids, cancel, "/VenditPublicApi/Phones");
            }

            // Address Types

            public Task<AddressType> GetAddressType(int typeId, CancellationToken cancel = default)
            {
                return _client.GetSomething<AddressType>(typeId.ToString(), cancel, "/VenditPublicApi/Lookups/AddressTypes/");
            }

            public Task<AddressType[]> GetAddressTypes(params int[] ids)
            {
                return GetAddressTypes(CancellationToken.None, ids);
            }

            public Task<AddressType[]> GetAddressTypes(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<AddressType, int>(ids, cancel, "/VenditPublicApi/Lookups/AddressTypes/");
            }

            public Task<AddressType[]> GetAllAddressTypes(CancellationToken cancel = default)
            {
                return _client.GetAll<AddressType>(cancel, "/VenditPublicApi/Lookups/AddressTypes/");
            }

            // Countries

            public Task<Country> GetCountry(int countryId, CancellationToken cancel = default)
            {
                return _client.GetSomething<Country>(countryId.ToString(), cancel, "/VenditPublicApi/Lookups/Countries/");
            }

            public Task<Country[]> GetCountries(params int[] ids)
            {
                return GetCountries(CancellationToken.None, ids);
            }

            public Task<Country[]> GetCountries(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Country, int>(ids, cancel, "/VenditPublicApi/Lookups/Countries/");
            }

            public Task<Country[]> GetAllCountries(CancellationToken cancel = default)
            {
                return _client.GetAll<Country>(cancel, "/VenditPublicApi/Lookups/Countries/");
            }

            // MiddleName

            public Task<MiddleName> GetMiddleName(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<MiddleName>(id.ToString(), cancel, "/VenditPublicApi/Lookups/MiddleNames/");
            }

            public Task<MiddleName[]> GetMiddleNames(params int[] ids)
            {
                return GetMiddleNames(CancellationToken.None, ids);
            }

            public Task<MiddleName[]> GetMiddleNames(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<MiddleName, int>(ids, cancel, "/VenditPublicApi/Lookups/MiddleNames/");
            }

            public Task<MiddleName[]> GetAllMiddleNames(CancellationToken cancel = default)
            {
                return _client.GetAll<MiddleName>(cancel, "/VenditPublicApi/Lookups/MiddleNames/");
            }

            // Title

            public Task<Title> GetTitle(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Title>(id.ToString(), cancel, "/VenditPublicApi/Lookups/Titles/");
            }

            public Task<Title[]> GetTitles(params int[] ids)
            {
                return GetTitles(CancellationToken.None, ids);
            }

            public Task<Title[]> GetTitles(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Title, int>(ids, cancel, "/VenditPublicApi/Lookups/Titles/");
            }

            public Task<Title[]> GetAllTitles(CancellationToken cancel = default)
            {
                return _client.GetAll<Title>(cancel, "/VenditPublicApi/Lookups/Titles/");
            }

            // Gender

            public Task<Gender> GetGender(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<Gender>(id.ToString(), cancel, "/VenditPublicApi/Lookups/Genders/");
            }

            public Task<Gender[]> GetGenders(params int[] ids)
            {
                return GetGenders(CancellationToken.None, ids);
            }

            public Task<Gender[]> GetGenders(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<Gender, int>(ids, cancel, "/VenditPublicApi/Lookups/Genders/");
            }

            public Task<Gender[]> GetAllGenders(CancellationToken cancel = default)
            {
                return _client.GetAll<Gender>(cancel, "/VenditPublicApi/Lookups/Genders/");
            }

            // ContactFunction

            public Task<ContactFunction> GetContactFunction(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<ContactFunction>(id.ToString(), cancel, "/VenditPublicApi/Lookups/ContactFunctions/");
            }

            public Task<ContactFunction[]> GetContactFunctions(params int[] ids)
            {
                return GetContactFunctions(CancellationToken.None, ids);
            }

            public Task<ContactFunction[]> GetContactFunctions(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<ContactFunction, int>(ids, cancel, "/VenditPublicApi/Lookups/ContactFunctions/");
            }

            public Task<ContactFunction[]> GetAllContactFunctions(CancellationToken cancel = default)
            {
                return _client.GetAll<ContactFunction>(cancel, "/VenditPublicApi/Lookups/ContactFunctions/");
            }

            // PhoneType

            public Task<PhoneType> GetPhoneType(int id, CancellationToken cancel = default)
            {
                return _client.GetSomething<PhoneType>(id.ToString(), cancel, "/VenditPublicApi/Lookups/PhoneTypes/");
            }

            public Task<PhoneType[]> GetPhoneTypes(params int[] ids)
            {
                return GetPhoneTypes(CancellationToken.None, ids);
            }

            public Task<PhoneType[]> GetPhoneTypes(CancellationToken cancel, params int[] ids)
            {
                return _client.GetMultiple<PhoneType, int>(ids, cancel, "/VenditPublicApi/Lookups/PhoneTypes/");
            }

            public Task<PhoneType[]> GetAllPhoneTypes(CancellationToken cancel = default)
            {
                return _client.GetAll<PhoneType>(cancel, "/VenditPublicApi/Lookups/PhoneTypes/");
            }

            // --- Import

            public async Task<int> ImportCustomers(CancellationToken cancel = default, params ImportCustomer[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/Customers/Import", new Results<ImportCustomer>(import));
                int ret = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }

            public async Task<int> ImportAddressesForCustomer(int customerId, CancellationToken cancel = default, params ImportAddress[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/Addresses/ImportForCustomer/" + customerId, new Results<ImportAddress>(import));
                int ret = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }

            public async Task<int> ImportContact(int addressId, CancellationToken cancel = default, params ImportContact[] import)
            {
                if (import is null || import.Length < 1)
                    return 0;

                string reply = await _client.Put(cancel, "/VenditPublicApi/Contacts/Import/" + addressId, new Results<ImportContact>(import));
                int    ret   = 0;
                if (int.TryParse(reply, out ret))
                    return ret;

                return -1;
            }

        }
    }
}
