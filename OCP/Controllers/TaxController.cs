using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OCP.Core;
using OCP.Models;

namespace OCP.Controllers
{
    public class TaxController : Controller
    {
        // GET: Tax
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IncomeDetails income)
        {
            CountryTaxCalculator t = null;
            switch (income.Country)
            {
                case "USA":
                    t = new TaxCalculatorForUS();
                    break;
                case "UK":
                    t = new TaxCalculatorForUK();
                    break;
                case "IN":
                    t = new TaxCalculatorForIndia();
                    break;
            }

            t.TotalIncome = income.TotalIncome;
            t.TotalDeduction = income.TotalDeduction;
            TaxCalculator cal = new TaxCalculator();
            ViewBag.TotalTax = cal.Calculate(t);
            return View("Index", income);
        }
    }
}