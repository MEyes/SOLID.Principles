using System;

namespace OCP.Core
{
    public class TaxCalculatorForUS : CountryTaxCalculator
    {
        public override decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 20 / 100;
        }
    }
}