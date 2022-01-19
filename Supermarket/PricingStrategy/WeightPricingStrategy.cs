using Supermarket.Basket;
using Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PricingStrategy
{
    public class WeightPricingStrategy : IPricingStrategy
    {
        

        public decimal GetPrice(OrderItem order)
        {
            return order.GetProduct().GetUnitairyPrice() * order.GetWeight();
        }
    }
}
