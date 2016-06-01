using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Core
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
        public CardInfo CardInfo { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
