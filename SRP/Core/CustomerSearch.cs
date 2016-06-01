using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SRP.Models;

namespace SRP.Core
{
    /// <summary>
    /// search customers by criteria
    /// </summary>
    public class CustomerSearch
    {
        public  List<Customer> SearchByCountry(string country)
        {
            using (Northwind context=new Northwind())
            {
                return context.Customers.Where(c => c.Country.Contains(country)).ToList();
            }
        }

        public List<Customer> SearchByCompanyName(string companyName)
        {
            using (Northwind context=new Northwind())
            {
                return context.Customers.Where(c => c.CompanyName.Contains(companyName)).ToList();
            }
        }

        public List<Customer> SearchByContactName(string contactName)
        {
            using (Northwind context=new Northwind())
            {
                return context.Customers.Where(c => c.ContactName.Contains(contactName)).ToList();
            }
        } 
    }
}