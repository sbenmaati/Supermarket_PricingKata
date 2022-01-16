using Supermarket.Basket;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public interface IPricingServices
    {
        public decimal GetTotalPrice(IList<Order> OrderList);
    }
}
