using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class AccountOp
    {
        public string accountNumber;
        public string customerName;
        private double balance = 0;

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            balance = balance - amount;
            return true;
        }

        public string Report()
        {
            var report = customerName + "," + " your account number: " + accountNumber + " and its balance: " + balance + " taka";
            return report;
        }
    }
}
