using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApplication.Context;

namespace CustomerApplication.Interface
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        List<Address> GetAddresses();
    }
}
