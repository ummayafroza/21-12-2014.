using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Customer
    {
        public string name;
        public string accountNo;
        public double  balance;

        public double Deposit(double deposit)
        {
            balance += deposit;
            return balance;

        }

        public double Withdraw(double withdraw)
        {
            balance -= withdraw;
            return balance;
        }

        public string GetReport()
        {
            return name + ", your account no is" +accountNo+ " and its balance : " +balance;
        }
    }
}
