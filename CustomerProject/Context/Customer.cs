using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProject.Context
{
    public class Customer
    {
        public int CUstomer_Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }

    public class Address
    {
        public int Address_Id { get; set; }
        public string Customer_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

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
