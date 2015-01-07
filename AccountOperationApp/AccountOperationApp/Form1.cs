using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class accountOperationUIForm : Form
    {
        public accountOperationUIForm()
        {
            InitializeComponent();
        }
        Customer aCustomer = new Customer();
        public double deposit;
        public double withdraw;

        private void crteateButton_Click(object sender, EventArgs e)
        {
            
            aCustomer.name = customerNameTextBox.Text;
            aCustomer.accountNo = accountNumberTextBox.Text;
            aCustomer.balance = Convert.ToDouble(balanceInputTextBox.Text);
            MessageBox.Show("Account Created");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
             deposit = double.Parse(amountTextBox.Text);
            aCustomer.Deposit(deposit);
            MessageBox.Show("Deposited");

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
             withdraw  = double.Parse(amountTextBox.Text);
                aCustomer.Withdraw(withdraw);
                MessageBox.Show("Withdrawn");

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aCustomer.GetReport());
        }
    }
}
