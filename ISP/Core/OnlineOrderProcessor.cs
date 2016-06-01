using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Core
{
    public class OnlineOrderProcessor:IOrderProcessor,IOnlineOrderProcessor
    {
        public bool ValidateCardInfo(CardInfo obj)
        {
            //validate credit card information
            return true;
        }

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
//    public class OnlineOrderProcessor : IOrderProcessor
//    {
//        public bool ValidateCardInfo(CardInfo obj)
//        {
//            //validate credit card infomation
//        }
//
//        public bool ValidateShippingAddress(Address obj)
//        {
//            //validate shipping destination
//        }
//
//        public void ProcessOrder(Order obj)
//        {
//           //do something with order
//        }
//    }
}
