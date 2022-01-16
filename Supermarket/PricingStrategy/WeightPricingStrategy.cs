using Supermarket.Basket;
using Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PricingStrategy
{
    public class WeightPricingStrategy : IPricingStrategy
    {
        public string Code { get => "WeightPricingStrategy"; }

        public decimal GetPrice(Order order)
        {
            return order.GetProduct().GetUnitairyPrice() * order.GetWeight();
        }
    }
}
