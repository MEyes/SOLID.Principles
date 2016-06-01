using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRP.Core;
using SRP.Models;

namespace SRP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string criteria,string searchBy)
        {
            var customers=GetCustomers(criteria, searchBy);
            ViewBag.Criteria = criteria;
            ViewBag.SearchBy = searchBy;
            return View(customers);
        }

        [HttpPost]
        public ActionResult Export(string criteria,string searchBy)
        {
            CustomerDataExporter exporter=new CustomerDataExporter();
            var customers = GetCustomers(criteria, searchBy);
            string exportData = exporter.ExportToCsv(customers);
            return File(System.Text.ASCIIEncoding.UTF8.GetBytes(exportData),
            "application/Excel");
        }

        private List<Customer> GetCustomers(string criteria,string searchBy )
        {
            List<Customer> customers=null;
            CustomerSearch customerSearch=new CustomerSearch();
            switch (searchBy)
            {
                case "country":
                    customers = customerSearch.SearchByCountry(criteria);
                    break;
                case "companyName":
                    customers = customerSearch.SearchByCompanyName(criteria);
                    break;
                case "contactName":
                    customers = customerSearch.SearchByContactName(criteria);
                    break;
            }
            return customers;
        } 
    }
}