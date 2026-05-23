using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstebanCashierApplication
{
    internal class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public string Full_Name
        {
            get { return full_name; }
            set { this.full_name = value; }
        }
        public UserAccount(string name, string Uname, string password)
        {
            this.full_name = name;
            this.user_name = Uname;
            this.user_password = password;
        }
        public virtual bool validateLogin(string username, string password)
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

        public string getFullName()
        {
            return Full_Name;
        }
    }
}
