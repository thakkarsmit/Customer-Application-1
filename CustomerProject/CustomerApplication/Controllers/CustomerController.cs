using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerApplication.Context;
using CustomerApplication.Interface;
using CustomerApplication.Services;

namespace CustomerApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        /// <summary>
        /// Method to retrieve the list of Customers along with their corresponding addresses
        /// </summary>
        /// <returns>A Json object containing Customers and their addresses</returns>
        public JsonResult GetCustomer()
        {
            var customers = _service.GetCustomers();

            var addresses = _service.GetAddresses();

            dynamic result = new List<dynamic>();

            foreach (var customer in customers)
            {
                foreach (var address in addresses)
                {
                    if (customer.Id == address.Customer.Id)
                    {
                        result.Add(new
                        {
                            customer.Id,
                            customer.Code,
                            customer.Description,
                            address.Address_1,
                            address.City,
                            address.State,
                            address.ZipCode
                        });
                    }

                }
            }
            return Json(result);
        }
    }
}