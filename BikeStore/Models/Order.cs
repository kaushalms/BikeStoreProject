using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
    public class Order
    {
        
        public Order()
        {
            ListOfOrderItems = new List<OrderItem>();
        }
        public enum MethodPayment
        {
            Cash,
            Cheque,
            CreditCard
        };
        public string CustName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PickupDate { get; set; }
        public List<OrderItem> ListOfOrderItems { get; set; }
        public decimal EmpBonusPayable { get; set; }
        public Store store { get; set; }
        public MethodPayment paymentMethod { get; set; }

        public void PlaceOrder(List<OrderItem> ListOfItems, string custName, Store store, MethodPayment paymentMethod)
        {
            this.ListOfOrderItems = ListOfItems;
            this.CustName = custName;
            this.OrderDate = DateTime.Today;
            this.store = store;
            //this.EmpBonusPayable = CalcEmpBonus();
            this.paymentMethod = paymentMethod;
            this.PickupDate = DateTime.Today.AddDays(7);
        }

    //    private decimal CalcEmpBonus()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
    }
