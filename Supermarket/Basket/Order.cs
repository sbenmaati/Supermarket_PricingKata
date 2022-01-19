using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Supermarket.Basket
{
    public class Order:IOrder


    {

       public IList<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        //return the total price of a list of order items
        public decimal GetTotalPrice()
        {
            //decimal totalPrice = 0;
            //foreach (OrderItem order in orderList)
            //{

            //    totalPrice += order.GetOrderPrice();
            //}
           return OrderItems.Sum(o => o.GetOrderPrice());
            
        }
    }
}
