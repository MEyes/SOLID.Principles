using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Core
{
    public class CashOnDeliveryOrderProcessor:IOrderProcessor
    {
       

        public bool ValidateShippingAddress(Address obj)
        {
            //validate shipping destination
            return true;
        }

        public void ProcessOrder(Order order)
        {
            //do something with order
        }

    }

//    public class CashOnDeliveryOrderProcessor : IOrderProcessor
//    {
//        public bool ValidateCardInfo(CardInfo obj)
//        {
//            throw new NotImplementedException();
//        }
//
//        public bool ValidateShippingAddress(Address obj)
//        {
//            //validate shipping destination
//        }
//
//        public void ProcessOrder(Order order)
//        {
//            //do something with order
//        }
//    }
}
