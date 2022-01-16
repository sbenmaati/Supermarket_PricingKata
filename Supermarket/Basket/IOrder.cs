using Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Basket
{
    public interface IOrder
    {
        int GetQuantity();

        int GetPackage();

        decimal GetWeight();

        int GetOfferedQuantity();

        Product GetProduct();

        void SetQuantity(int quantity);

        void SetPackage(int package);

        void SetWeight(decimal weight);

        void SetOfferedQuantity(int offeredQuantity);

        decimal GetOrderPrice();
       
    }
}
