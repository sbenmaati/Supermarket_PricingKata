using System;
using System.Collections.Generic;
using System.Linq;
using Supermarket.Models;
using Supermarket.PricingStrategy;

namespace Supermarket.Basket
{
   
    public class OrderItem : IOrderItem
    {
        //Initialise Class Properties
        public OrderItem( Product product ,IPricingStrategy pricingStategy)
        {
            PricingStrategy = pricingStategy;
            Product =product;
        }

        private Product Product { get; set; }
        public readonly IPricingStrategy PricingStrategy;
        private int Quantity { get; set; }

        

        private decimal Weight { get; set; }
        public int GetQuantity()
        {
            return Quantity;
        }
      
        public decimal GetWeight()
        {
            return Weight;
        }
       
        public Product GetProduct()
        {
            return Product;
        }
        public void SetQuantity(int quantity)
        {
             Quantity= quantity;
        }
       
        public void SetWeight(decimal weight)
        {
             Weight= weight;
        }
        

        //Return The price of an order item
        public  decimal GetOrderPrice()
        {
            return PricingStrategy.GetPrice(this);
        }
    }
}

