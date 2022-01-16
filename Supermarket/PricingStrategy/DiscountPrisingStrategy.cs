using Supermarket.Basket;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PricingStrategy
{
    public class DiscountPrisingStrategy : IPricingStrategy
    {
        public string Code { get => "DiscountPricingStrategy"; }

        public decimal GetPrice(Order order)
        {
            return order.GetProduct().GetUnitairyPrice() * (order.GetQuantity() - order.GetQuantity() * order.GetOfferedQuantity() / order.GetPackage());
            
        }
    }
}
