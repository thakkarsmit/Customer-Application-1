using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApplication.Context;
using CustomerApplication.Interface;

namespace CustomerApplication.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerDBContext _customerDBContext;

        public CustomerService(CustomerDBContext ctx)
        {
            _customerDBContext = ctx;
        }

        /// <summary>
        /// Method to retreive customers from database.
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Customer> GetCustomers()
        {
            var customers = from u in _customerDBContext.Customers select u;

            List<Customer> result = new List<Customer>();
            result.AddRange(customers);

            return result;
        }

        /// <summary>
        /// Method to retrieve addresses from databse
        /// </summary>
        /// <returns>List of addresses</returns>
        public List<Address> GetAddresses()
        {
            var addresses = from u in _customerDBContext.Addresses select u;

            List<Address> result = new List<Address>();
            result.AddRange(addresses);

            return result;
        }
    }
}
