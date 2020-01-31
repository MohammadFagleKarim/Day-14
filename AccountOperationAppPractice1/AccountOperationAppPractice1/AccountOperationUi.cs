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
        AccountOp accountOp = new AccountOp();

        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //validation check

            if (String.IsNullOrEmpty(accountNoTextBox.Text))
            {
                MessageBox.Show("Account Number cannot be empty");
                return;
            }

            if (String.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Customer Name cannot be empty");
                return;
            }

            accountOp.accountNumber = accountNoTextBox.Text;
            accountOp.customerName = customerNameTextBox.Text;
            //accountOp.balance = 0;
            
            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            //validation check

            if (String.IsNullOrEmpty(amountTextBox.Text))
            {
                MessageBox.Show("Amount cannot be empty");
                return;
            }

            double amount = Convert.ToDouble(amountTextBox.Text);

           bool isDeposited = accountOp.Deposit(amount);

           if (isDeposited)
           {
               amountTextBox.Text = "";
           }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            //validation check

            if (String.IsNullOrEmpty(amountTextBox.Text))
            {
                MessageBox.Show("Amount cannot be empty");
                return;
            }

            double amount = Convert.ToDouble(amountTextBox.Text);

            bool isWithdrawn = accountOp.Withdraw(amount);

            if (isWithdrawn)
            {
                amountTextBox.Text = "";
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            //string a = accountOp.Report(accountOp);
            MessageBox.Show(accountOp.Report());
        }
    }
}
