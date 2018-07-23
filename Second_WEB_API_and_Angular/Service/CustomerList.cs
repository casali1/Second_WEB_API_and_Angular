using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Second_WEB_API_and_Angular.Models;

namespace Second_WEB_API_and_Angular.Service
{
    public class CustomerList
    {
        public List<Customer> GetCustomers(string name)
        {
            var list = new List<Customer>
            {
                new Customer
                {
                    ID = "Yo",
                    Name = "Bob",
                    Country = "USA"
                },
                new Customer
                {
                    ID = "AA",
                    Name = "Sam",
                    Country = "France"
                },
                new Customer
                {
                    ID = "BB",
                    Name = "Linda",
                    Country = "England"
                },
                new Customer
                {
                    ID = "CC",
                    Name = "Geo",
                    Country = "Italy"
                },
                new Customer
                {
                    ID = "DD",
                    Name = "Bob",
                    Country = "China"
                }
            };

            return list.Where(x => x.Name == name).ToList();
        }
    }
}