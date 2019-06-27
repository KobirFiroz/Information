using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
          
        }
        Account accountobj = new Account();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            accountobj.customername = customerNameTextBox.Text;
           accountobj.accountnumber = accountNoTextBox.Text;
           
           MessageBox.Show("Successfull");

        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountTextBox.Text);
            bool isDeposit =   accountobj.Diposit(amount);
            
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(amountTextBox.Text);
           bool isWithdrawn = accountobj.withdrow(amount);
 
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accountobj.Getreport());
        }
    }
}
