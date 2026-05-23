using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebanCashierApplication
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public double Item_discount
        {
            get { return item_discount; }
            set { item_discount = value; }
        }
        public double Discounted_price
        {
            get { return discounted_price; }
            set { discounted_price = value; }
        }
        public double Payment_pmount
        {
            get { return payment_amount; }
            set { payment_amount = value; }
        }
        public double Change
        {
            get { return change; }
            set { change = value; }
        }
        public override double getTotalPrice()
        {
            double convertedDiscount = item_discount / 100;
            discounted_price = item_price - (item_price * convertedDiscount);
            TotalPrice = discounted_price * item_quantity;
            return TotalPrice;
        }

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, 0)
        {
            item_price = price;
            item_discount = discount;
            item_name = name;
            item_quantity = quantity;
        }

        public override void setPayment(double amount)
        {
            Payment_pmount = amount;
        }

        public double getChange()
        {
            Change = Payment_pmount - TotalPrice;
            return Change;
        }
    }
}
