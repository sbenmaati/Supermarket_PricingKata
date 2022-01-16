using System;
using System.Collections.Generic;
using System.Text;
using Supermarket.Basket;
using Supermarket.PricingStrategy;
using Supermarket.Models;
using NSubstitute;
using Xunit;
using Supermarket.Services;

namespace SupermarketTest
{
    public class OrderTest
    {

        
        private IPricingStrategy _pricingStrategy;

        private IPricingServices _pricingServices;

        public OrderTest()
        {
            _pricingStrategy = Substitute.For<IPricingStrategy>();
            _pricingServices = Substitute.For<IPricingServices>();



        }



        [Fact]
        public void Order_with_defaultPricingStrategy()
        {
            //Arrange

            var defautPricingStrategy = new DefaultPricingStrategy();
            var product = new Product(1, "Coke", 15, defautPricingStrategy);

            var order = new Order(product);
            order.SetQuantity(3);


            //Act
           

            decimal? expectedTotalPrice = 45;


            //Assert
            Assert.Equal(expectedTotalPrice, order.GetOrderPrice());
        }


        [Fact]
        public void Order_with_DiscountPricingStrategy()
        {
            //Arrange

            var discountPricingStrategy = new DiscountPrisingStrategy();
            var product = new Product(1, "Coke", 15, discountPricingStrategy);

            var order = new Order(product) ;
            order.SetQuantity(3);
            order.SetOfferedQuantity(1);
            order.SetPackage(3);
            //Act


            decimal? expectedTotalPrice = 30;


            //Assert
            Assert.Equal(expectedTotalPrice, order.GetOrderPrice());
        }


        [Fact]
        public void Order_with_WeightPricingStrategy()
        {
            //Arrange

            var weightPricingStrategy = new WeightPricingStrategy();
            var product = new Product(1, "Apple", 5, weightPricingStrategy);

            var order = new Order(product) ;
            order.SetWeight(3);

            //Act


            decimal? expectedTotalPrice = 15;


            //Assert
            Assert.Equal(expectedTotalPrice, order.GetOrderPrice());
        }



        [Fact]
        public void OrderList_with_MultiplePricingStrategy()
        {
            //Arrange
            var pricingService = new PricingServices();
            var orderList = new List<Order>();
            var weightPricingStrategy = new WeightPricingStrategy();
            var product = new Product(1, "Apple", 5, weightPricingStrategy);
            var order = new Order(product);
             order.SetWeight(3);
            orderList.Add(order);
            var discountPricingStrategy = new DiscountPrisingStrategy();
            var product_2 = new Product(1, "Coke", 15, discountPricingStrategy);
            
            var order_2 = new Order(product_2) ;
            order_2.SetQuantity(3);
            order_2.SetOfferedQuantity(1);
            order_2.SetPackage(3);
            orderList.Add(order_2);
            var defautPricingStrategy = new DefaultPricingStrategy();
            var product_3 = new Product(1, "Coke", 15, defautPricingStrategy);

            var order_3 = new Order(product_3);
            order_3.SetQuantity(3); ;
            orderList.Add(order_3);
            //Act


            decimal? expectedTotalPrice = 90;


            //Assert
            Assert.Equal(expectedTotalPrice, pricingService.GetTotalPrice(orderList));
        }








    }

}
