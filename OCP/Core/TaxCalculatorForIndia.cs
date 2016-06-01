using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCP.Core
{
    public class TaxCalculatorForIndia: CountryTaxCalculator
    {
        public override decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 40 / 100;
        }
    }
}