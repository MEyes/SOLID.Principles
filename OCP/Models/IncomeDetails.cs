using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OCP.Models
{
    public class IncomeDetails
    {
        [DataType(DataType.Currency)]
        [Display(Name = "Total Income")]
        public decimal TotalIncome { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Total Deduction")]
        public decimal TotalDeduction { get; set; }
        public string Country { get; set; }
    }
}