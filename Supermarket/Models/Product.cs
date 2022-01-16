using Supermarket.PricingStrategy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket.Models
{
   
   public class Product 
    {
        public readonly IPricingStrategy PricingStrategy;

        private int Id { get; set; }
        private string Name { get; set; }
        private decimal UnitairyPrice { get; set; }

        public string PricingStategyTypeCode { get; set; }
        public Product(int id, string name, decimal unitairyPrice,IPricingStrategy pricingStategy) 
        {
            if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException(nameof(name)); }
            if (unitairyPrice < 0) { throw new ArgumentOutOfRangeException(nameof(unitairyPrice)); }

            Name = name;
            UnitairyPrice = unitairyPrice;
            PricingStrategy = pricingStategy;
        }
        public string GetName()
        {
            return Name;
        }
        public decimal GetUnitairyPrice()
        {
            return UnitairyPrice;
        }
       

        //   public enum UnitType { get; set; }


    }
}


