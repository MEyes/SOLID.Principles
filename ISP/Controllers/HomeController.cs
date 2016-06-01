using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISP.Core;

namespace ISP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessOrder(string paymentmode)
        {
            Customer customer = new Customer();
            Address address = new Address();
            CardInfo cardinfo = null;

            Order order = new Order();
            order.OrderID = new Random().Next(1000, 9000);
            order.Customer = customer;
            order.ShippingAddress = address;
            order.CardInfo = cardinfo;

            if (paymentmode == "card")
            {
                OnlineOrderProcessor oop = new OnlineOrderProcessor();
                cardinfo = new CardInfo();
                cardinfo.CardNo = "5555555555554444";
                cardinfo.ExpiryMonth = 12;
                cardinfo.ExpiryYear = 2015;
                order.CardInfo = cardinfo;

                oop.ValidateCardInfo(cardinfo);
                oop.ValidateShippingAddress(address);
                oop.ProcessOrder(order);
            }
            else
            {
                CashOnDeliveryOrderProcessor codop = new CashOnDeliveryOrderProcessor();
                codop.ValidateShippingAddress(address);
                codop.ProcessOrder(order);
            }

            return View("Success", order);
        }
    }
}