using System;
using System.Collections.Generic;
using System.Text;
using Supermarket.Basket;
using Supermarket.Models;

namespace Supermarket.PricingStrategy
{
    public interface IPricingStrategy
    {
        string Code { get; }

       
        decimal GetPrice(Order order);
    }
}
