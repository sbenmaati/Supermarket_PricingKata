using System;
using System.Collections.Generic;
using System.Text;
using Supermarket.Basket;
using Supermarket.Models;

namespace Supermarket.PricingStrategy
{
    public class DefaultPricingStrategy : IPricingStrategy
    {
        public string Code { get => "DefaultPricingStrategy"; }

        public decimal GetPrice(Order order)
        {
            return order.GetProduct().GetUnitairyPrice() * order.GetQuantity();    
        }
    }
}
