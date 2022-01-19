using Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Basket
{
    public interface IOrderItem
    {
        int GetQuantity();

       

        decimal GetWeight();

       
        Product GetProduct();

        void SetQuantity(int quantity);

      
        void SetWeight(decimal weight);

       

        decimal GetOrderPrice();
       
    }
}
