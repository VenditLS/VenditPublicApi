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

        // Address Types

        public Task<AddressType> GetAddressType(int typeId, CancellationToken cancel = default)
        {
            return GetSomething<AddressType>(typeId.ToString(), cancel, "/VenditPublicApi/Lookups/AddressTypes/");
        }

        public Task<AddressType[]> GetAddressTypes(params int[] ids)
        {
            return GetAddressTypes(CancellationToken.None, ids);
        }

        public Task<AddressType[]> GetAddressTypes(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<AddressType, int>(ids, cancel, "/VenditPublicApi/Lookups/AddressTypes/");
        }

        public Task<AddressType[]> GetAllAddressTypes(CancellationToken cancel = default)
        {
            return GetAll<AddressType>(cancel, "/VenditPublicApi/Lookups/AddressTypes/");
        }

        // Countries

        public Task<Country> GetCountry(int countryId, CancellationToken cancel = default)
        {
            return GetSomething<Country>(countryId.ToString(), cancel, "/VenditPublicApi/Lookups/Countries/");
        }

        public Task<Country[]> GetCountries(params int[] ids)
        {
            return GetCountries(CancellationToken.None, ids);
        }

        public Task<Country[]> GetCountries(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Country, int>(ids, cancel, "/VenditPublicApi/Lookups/Countries/");
        }

        public Task<Country[]> GetAllCountries(CancellationToken cancel = default)
        {
            return GetAll<Country>(cancel, "/VenditPublicApi/Lookups/Countries/");
        }

        // MiddleName

        public Task<MiddleName> GetMiddleName(int id, CancellationToken cancel = default)
        {
            return GetSomething<MiddleName>(id.ToString(), cancel, "/VenditPublicApi/Lookups/MiddleNames/");
        }

        public Task<MiddleName[]> GetMiddleNames(params int[] ids)
        {
            return GetMiddleNames(CancellationToken.None, ids);
        }

        public Task<MiddleName[]> GetMiddleNames(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<MiddleName, int>(ids, cancel, "/VenditPublicApi/Lookups/MiddleNames/");
        }

        public Task<MiddleName[]> GetAllMiddleNames(CancellationToken cancel = default)
        {
            return GetAll<MiddleName>(cancel, "/VenditPublicApi/Lookups/MiddleNames/");
        }

        // Title

        public Task<Title> GetTitle(int id, CancellationToken cancel = default)
        {
            return GetSomething<Title>(id.ToString(), cancel, "/VenditPublicApi/Lookups/Titles/");
        }

        public Task<Title[]> GetTitles(params int[] ids)
        {
            return GetTitles(CancellationToken.None, ids);
        }

        public Task<Title[]> GetTitles(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Title, int>(ids, cancel, "/VenditPublicApi/Lookups/Titles/");
        }

        public Task<Title[]> GetAllTitles(CancellationToken cancel = default)
        {
            return GetAll<Title>(cancel, "/VenditPublicApi/Lookups/Titles/");
        }

        // Gender

        public Task<Gender> GetGender(int id, CancellationToken cancel = default)
        {
            return GetSomething<Gender>(id.ToString(), cancel, "/VenditPublicApi/Lookups/Genders/");
        }

        public Task<Gender[]> GetGenders(params int[] ids)
        {
            return GetGenders(CancellationToken.None, ids);
        }

        public Task<Gender[]> GetGenders(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<Gender, int>(ids, cancel, "/VenditPublicApi/Lookups/Genders/");
        }

        public Task<Gender[]> GetAllGenders(CancellationToken cancel = default)
        {
            return GetAll<Gender>(cancel, "/VenditPublicApi/Lookups/Genders/");
        }

        // ContactFunction

        public Task<ContactFunction> GetContactFunction(int id, CancellationToken cancel = default)
        {
            return GetSomething<ContactFunction>(id.ToString(), cancel, "/VenditPublicApi/Lookups/ContactFunctions/");
        }

        public Task<ContactFunction[]> GetContactFunctions(params int[] ids)
        {
            return GetContactFunctions(CancellationToken.None, ids);
        }

        public Task<ContactFunction[]> GetContactFunctions(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<ContactFunction, int>(ids, cancel, "/VenditPublicApi/Lookups/ContactFunctions/");
        }

        public Task<ContactFunction[]> GetAllContactFunctions(CancellationToken cancel = default)
        {
            return GetAll<ContactFunction>(cancel, "/VenditPublicApi/Lookups/ContactFunctions/");
        }

        // PhoneType

        public Task<PhoneType> GetPhoneType(int id, CancellationToken cancel = default)
        {
            return GetSomething<PhoneType>(id.ToString(), cancel, "/VenditPublicApi/Lookups/PhoneTypes/");
        }

        public Task<PhoneType[]> GetPhoneTypes(params int[] ids)
        {
            return GetPhoneTypes(CancellationToken.None, ids);
        }

        public Task<PhoneType[]> GetPhoneTypes(CancellationToken cancel, params int[] ids)
        {
            return GetMultiple<PhoneType, int>(ids, cancel, "/VenditPublicApi/Lookups/PhoneTypes/");
        }

        public Task<PhoneType[]> GetAllPhoneTypes(CancellationToken cancel = default)
        {
            return GetAll<PhoneType>(cancel, "/VenditPublicApi/Lookups/PhoneTypes/");
        }

        // --- Import

        public async Task<int> ImportCustomers(CancellationToken cancel = default, params ImportCustomer[] import)
        {
            if (import is null || import.Length < 1)
                return 0;

            string reply = await Post(cancel, "/VenditPublicApi/Customers/Import", new Results<ImportCustomer>(import));
            int    ret   = 0;
            if (int.TryParse(reply, out ret))
                return ret;

            return -1;
        }
    }
}
