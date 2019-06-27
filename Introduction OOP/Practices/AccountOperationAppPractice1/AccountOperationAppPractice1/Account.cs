using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public string accountnumber { set; get; }
        public string customername { set; get; }
       private int balance { set; get; }

        public bool Diposit(int amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool withdrow(int amount)
        {
            if (balance >= 0)

            {
                balance = balance - amount;
                return true;
            }

            else
            {
                return false;

            }
            
            
        }

        public string Getreport ()
        {
            return customername + "your account number:" + accountnumber + "your balance:" + balance;

        }
    }
}
