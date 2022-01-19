using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Basket
{
    public interface IOrder
    {
        decimal GetTotalPrice();
    }
}
