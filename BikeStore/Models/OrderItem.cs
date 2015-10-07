using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
    public class OrderItem
    {
        public Inventory BicycleOrdered { get; set; }
        public decimal PriceSold { get; set; }
        public enum Flag
        {
            Online = 1,
            Store = 2
        };
        public Flag PurchaseType { get; set; }
    }
}