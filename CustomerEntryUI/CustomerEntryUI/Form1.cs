using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerEntryUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerAndAccountlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistration custandaccntformObj = new CustomerRegistration();
            custandaccntformObj.Show();
        }

        private void transactionlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionForm transactionFormObj = new TransactionForm();
            transactionFormObj.Show();
        }

        private void searchCustAndAccntLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchCustomerAndAccountInfoForm scustandaccountObj = new SearchCustomerAndAccountInfoForm();
            scustandaccountObj.Show();
        }
    }
}
