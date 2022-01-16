using System;
using System.Collections.Generic;
using System.Linq;
using Supermarket.Models;
using Supermarket.PricingStrategy;

namespace Supermarket.Basket
{
   
    public class Order : IOrder
    {
        
        public Order( Product product )
        {
           
            Product =product;
        }

        private Product Product { get; set; }
            
        private int Quantity { get; set; }

        private int Package { get; set; }    
        private int OfferedQuantity { get; set; }    

        private decimal Weight { get; set; }
        public int GetQuantity()
        {
            return Quantity;
        }
        public int GetPackage()
        {
            return Package;
        }
        public decimal GetWeight()
        {
            return Weight;
        }
        public int GetOfferedQuantity()
        {
            return OfferedQuantity;
        }
        public Product GetProduct()
        {
            return Product;
        }
        public void SetQuantity(int quantity)
        {
             Quantity= quantity;
        }
        public void SetPackage(int package)
        {
             Package=package;
        }
        public void SetWeight(decimal weight)
        {
             Weight= weight;
        }
        public void SetOfferedQuantity(int offeredQuantity)
        {
             OfferedQuantity = offeredQuantity;
        }
        public  decimal GetOrderPrice()
        {
            return Product.PricingStrategy.GetPrice(this);
        }
    }
}

