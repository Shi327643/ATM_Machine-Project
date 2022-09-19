using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMDemo
{
    public partial class TransactionModeForm : Form
    {
        public TransactionModeForm()
        {
            InitializeComponent();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            BalanceEnquiryForm balanceEnquiryForm = new BalanceEnquiryForm();
            balanceEnquiryForm.Show();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            PreviousHistoryForm previousHistoryForm = new PreviousHistoryForm();
            previousHistoryForm.Show();
        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            WithdrawMoneyForm withdrawMoneyForm = new WithdrawMoneyForm();
            withdrawMoneyForm.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.Show();
        }
    }
}