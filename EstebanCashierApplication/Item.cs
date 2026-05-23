using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebanCashierApplication
{
    internal class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;
        private double payment;

        public double Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        public double TotalPrice
        {
            get { return total_price; }
            set { total_price = value; }
        }
        public virtual double getTotalPrice()
        {
            return TotalPrice;
        }

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }
        public virtual void setPayment(double amount)
        {
            Payment = amount;
        }


    }
}
