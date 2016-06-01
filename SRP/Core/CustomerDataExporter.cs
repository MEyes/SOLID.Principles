using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using SRP.Models;

namespace SRP.Core
{
    public class CustomerDataExporter
    {
        /// <summary>
        /// export to csv 
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public string ExportToCsv(List<Customer> customers )
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in customers)
            {
                sb.AppendFormat("{0},{1},{2},{3}",
                item.CustomerID,
                item.CompanyName,
                item.ContactName,
                item.Country);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public string ExportToXml()
        {
            return "";
        }

        public string ExportToPdf()
        {
            return "";
        }
    }
}