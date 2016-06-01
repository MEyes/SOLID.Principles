using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Core
{
//    public interface IOrderProcessor
//    {
//        bool ValidateCardInfo(CardInfo obj);
//        bool ValidateShippingAddress(Address obj);
//        void ProcessOrder(Order obj);
//    }



    public interface IOrderProcessor
    {
        bool ValidateShippingAddress(Address obj);
        void ProcessOrder(Order obj);
    }

    public interface IOnlineOrderProcessor
    {
        bool ValidateCardInfo(CardInfo obj);
    }

}
