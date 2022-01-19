using System;
using System.Collections.Generic;
using System.Text;
using Supermarket.Basket;
using Supermarket.Models;

namespace Supermarket.PricingStrategy
{
    public class DefaultPricingStrategy : IPricingStrategy
    {
       

        public decimal GetPrice(OrderItem order)
        {
            return order.GetProduct().GetUnitairyPrice() * order.GetQuantity();    
        }
    }
}
