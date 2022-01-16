using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Supermarket.Basket;
using Supermarket.PricingStrategy;

namespace Supermarket.Services
{
    public class PricingServices : IPricingServices
    {
        

        public decimal GetTotalPrice(IList<Order> orderList)
        {
            decimal totalPrice = 0;
            foreach(Order order in orderList)
            {
                totalPrice += order.GetOrderPrice();
            }

            return totalPrice;
        }
    }
}
