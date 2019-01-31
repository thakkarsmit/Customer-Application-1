using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApplication.Context
{
    public class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }

    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int AddressId { get; set; }

        public Address Address { get; set; }

    }
}
