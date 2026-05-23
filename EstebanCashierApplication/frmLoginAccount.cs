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
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }
        Cashier cashier = new Cashier("Charls Aldrin Esteban", "Cashier", "Charls", "12345678");

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cashier.validateLogin(Usernametb.Text, Passwordtb.Text) == true)
            {
                MessageBox.Show("Welcome " + cashier.Full_Name);
                frmPurchaseDiscountedItem form = new frmPurchaseDiscountedItem();
                form.Visible = true;
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
