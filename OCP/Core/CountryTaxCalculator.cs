using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCP.Core
{
    public abstract class  CountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public abstract decimal CalculateTaxAmount();
        
    }
}