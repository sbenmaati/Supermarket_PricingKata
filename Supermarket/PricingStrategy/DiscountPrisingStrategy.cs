using Supermarket.Basket;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PricingStrategy
{
    public class DiscountPrisingStrategy : IPricingStrategy
    {
        private int package { get; set; }
        private int offeredQuantity { get; set; }
        public DiscountPrisingStrategy(int package ,int offeredQuantity)
        {
            this.package = package;
            this.offeredQuantity = offeredQuantity;
        }
        public decimal GetPrice(OrderItem order)
        {
            return order.GetProduct().GetUnitairyPrice() * (order.GetQuantity() - order.GetQuantity() * offeredQuantity / package);
            
        }
       
       
       
      
    }
}
