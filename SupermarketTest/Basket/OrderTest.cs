using System;
using System.Collections.Generic;
using System.Text;
using Supermarket.Basket;
using Supermarket.PricingStrategy;
using Supermarket.Models;
using NSubstitute;
using Xunit;


namespace SupermarketTest
{
    public class OrderTest
    {

        
        private IPricingStrategy _pricingStrategy;

        

        public OrderTest()
        {
            _pricingStrategy = Substitute.For<IPricingStrategy>();
           



        }



        [Fact]
        public void Order_with_defaultPricingStrategy()
        {
            //Arrange

            var defautPricingStrategy = new DefaultPricingStrategy();
            var product = new Product(1, "Coke", 15);

            var orderItem = new OrderItem(product, defautPricingStrategy);
            orderItem.SetQuantity(3);


            //Act
           

            decimal? expectedTotalPrice = 45;


            //Assert
            Assert.Equal(expectedTotalPrice, orderItem.GetOrderPrice());
        }

        [Fact]
        public void Order_2_with_defaultPricingStrategy()
        {
            //Arrange

            var defautPricingStrategy = new DefaultPricingStrategy();
            var product = new Product(1, "A", 10);

            var orderItem = new OrderItem(product, defautPricingStrategy);
            orderItem.SetQuantity(10);


            //Act


            decimal? expectedTotalPrice = 100;


            //Assert
            Assert.Equal(expectedTotalPrice, orderItem.GetOrderPrice());
        }

        [Fact]
        public void Order_with_DiscountPricingStrategy()
        {
            //Arrange

            var discountPricingStrategy = new DiscountPrisingStrategy(3,1);
            var product = new Product(1, "Coke", 15);

            var orderItem = new OrderItem(product, discountPricingStrategy) ;
            orderItem.SetQuantity(3);
            
            //Act


            decimal? expectedTotalPrice = 30;


            //Assert
            Assert.Equal(expectedTotalPrice, orderItem.GetOrderPrice());
        }
        [Fact]
        public void Order_2_with_DiscountPricingStrategy()
        {
            //Arrange

            var discountPricingStrategy = new DiscountPrisingStrategy(5, 2);
            var product = new Product(1, "B", 15);

            var orderItem = new OrderItem(product, discountPricingStrategy);
            orderItem.SetQuantity(5);

            //Act


            decimal? expectedTotalPrice = 45;


            //Assert
            Assert.Equal(expectedTotalPrice, orderItem.GetOrderPrice());
        }





        [Fact]
        public void Order_with_WeightPricingStrategy()
        {
            //Arrange

            var weightPricingStrategy = new WeightPricingStrategy();
            var product = new Product(1, "Apple", 5);

            var orderItem = new OrderItem(product, weightPricingStrategy) ;
            orderItem.SetWeight(3);

            //Act


            decimal? expectedTotalPrice = 15;


            //Assert
            Assert.Equal(expectedTotalPrice, orderItem.GetOrderPrice());
        }

        [Fact]
        public void Order_2_with_WeightPricingStrategy()
        {
            //Arrange

            var weightPricingStrategy = new WeightPricingStrategy();
            var product = new Product(1, "Apple", 5.5m);

            var orderItem = new OrderItem(product, weightPricingStrategy);
            orderItem.SetWeight(5);

            //Act


            decimal? expectedTotalPrice = 27.5m;


            //Assert
            Assert.Equal(expectedTotalPrice, orderItem.GetOrderPrice());
        }


        [Fact]
        public void OrderList_with_MultiplePricingStrategy()
        {
            //Arrange
            
            var order = new Order();
            var weightPricingStrategy = new WeightPricingStrategy();
            var product = new Product(1, "Apple", 5);

            var orderItem = new OrderItem(product, weightPricingStrategy);
            orderItem.SetWeight(3);
            order.OrderItems.Add(orderItem);
            var discountPricingStrategy = new DiscountPrisingStrategy(3,1);
            var product_2 = new Product(1, "Coke", 15);
        
            var orderItem_2 = new OrderItem(product_2, discountPricingStrategy) ;
            orderItem_2.SetQuantity(3);
           
            order.OrderItems.Add(orderItem_2);
            var defautPricingStrategy = new DefaultPricingStrategy();
            var product_3 = new Product(1, "Coke", 15);

            var orderItem_3 = new OrderItem(product_3, defautPricingStrategy);
            orderItem_3.SetQuantity(3); ;
            order.OrderItems.Add(orderItem_3);
            
            var product_4 = new Product(1, "C", 2);

            var orderItem_4 = new OrderItem(product_4, defautPricingStrategy);
            orderItem_4.SetQuantity(5); ;
            order.OrderItems.Add(orderItem_4);
            //Act


            decimal? expectedTotalPrice = 100;


            //Assert
            Assert.Equal(expectedTotalPrice, order.GetTotalPrice());
        }








    }

}
