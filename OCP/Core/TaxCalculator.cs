using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCP.Core
{
    public class TaxCalculator
    {
        //       note: current design violates OCP
        //        public decimal Calculate(decimal income, decimal deduction, string country)
        //        {
        //            decimal taxAmount = 0;
        //            decimal taxableIncome = income - deduction;
        //            switch (country)
        //            {
        //                case "India":
        //                    //Todo calculation
        //                    break;
        //                case "USA":
        //                    //Todo calculation 
        //                    break;
        //                case "UK":
        //                    //Todocalculation
        //                    break;
        //            }
        //            return taxAmount;
        //        }

        //add some logic here
        public decimal Calculate(CountryTaxCalculator obj)
        {
            decimal taxAmount = 0;
            taxAmount = obj.CalculateTaxAmount();
            return taxAmount;
        }
    }
}