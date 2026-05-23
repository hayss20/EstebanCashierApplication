using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstebanCashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public Cashier(string name, string department, string username, string password) : base(name, username, password)
        {
            Full_Name = name;
            this.department = department;
            this.user_name = username;
            this.user_password = password;
        }

        public override bool validateLogin(string username, string password)
        {

            if (string.Equals(username, user_name) && string.Equals(password, user_password))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username or Passwords does not match");
                return false;
            }
        }
    }
}
