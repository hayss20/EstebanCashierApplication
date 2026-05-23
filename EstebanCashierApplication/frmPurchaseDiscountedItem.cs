using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstebanCashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }
        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void Computebtn_Click(object sender, EventArgs e)
        {
            String name = Itemtb.Text;
            Double price = Convert.ToDouble(Pricetb.Text);
            int quantity = Convert.ToInt32(Quantitytb.Text);
            double discount = Convert.ToDouble(Discounttb.Text);
            DiscountedItem discountedItem = new DiscountedItem(name, price, quantity, discount);
            TotalAmount.Text = discountedItem.getTotalPrice().ToString();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            String name = Itemtb.Text;
            Double price = Convert.ToDouble(Pricetb.Text);
            int quantity = Convert.ToInt32(Quantitytb.Text);
            double discount = Convert.ToDouble(Discounttb.Text);
            DiscountedItem discountedItem = new DiscountedItem(name, price, quantity, discount);
            TotalAmount.Text =  discountedItem.getTotalPrice().ToString();
            discountedItem.setPayment(Convert.ToDouble(Paymenttb.Text));
            Change.Text = discountedItem.getChange().ToString();
        }
    }
}
