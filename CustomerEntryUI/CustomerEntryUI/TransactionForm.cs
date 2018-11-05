using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerEntryUI.Models;
using CustomerEntryUI.BLL;
using System.Data.SqlClient;

namespace CustomerEntryUI
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            TransactionInfo dipositObj = new TransactionInfo();
            if (transactionAccnNoTextBox.Text == "" || transactionAmountTextBox.Text == "")
            {
                MessageBox.Show("No empty value accepted");
                return;
            }


            dipositObj.TranAccNo = transactionAccnNoTextBox.Text;
            try
            {
                dipositObj.TransAmmount = Convert.ToDouble(transactionAmountTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Amount must be number !");
                return;
            }


            if (dipositObj.TransAmmount <= 0)
            {
                MessageBox.Show("Ammount should be positive and greater than 0");
                return;
            }


            try
            {
                DipositManager dipoMngObj = new DipositManager();
                bool sameInfo = dipoMngObj.CheckInfo(dipositObj);
                if (sameInfo == false)
                {
                    MessageBox.Show("Account not found !\n Please create account first.");
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            try
            {
                DipositManager dipoMangObj = new DipositManager();
                bool dipositInfo = dipoMangObj.DipositInfo(dipositObj);
                if (dipositInfo == true)
                {
                    MessageBox.Show("Taka " + dipositObj.TransAmmount + " Diposited Successfully !");

                }
                else
                {
                    MessageBox.Show("Diposit Failed!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            TransactionInfo withdrawObj = new TransactionInfo();
            if (transactionAccnNoTextBox.Text == "" || transactionAmountTextBox.Text == "")
            {
                MessageBox.Show("No empty value accepted");
                return;
            }


            withdrawObj.TranAccNo = transactionAccnNoTextBox.Text;
            try
            {
                withdrawObj.TransAmmount = Convert.ToDouble(transactionAmountTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Amount must be in number !");
                return;
            }


            if (withdrawObj.TransAmmount <= 0)
            {
                MessageBox.Show("Ammount should be positive and greater than 0");
                return;
            }


            try
            {
                WithdrawManager withMangObj=new WithdrawManager();
                string withdrawInfo = withMangObj.WithdrawInfo(withdrawObj);

                MessageBox.Show(withdrawInfo);
                return;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            //try
            //{
            //    DipositManager dipoMangObj = new DipositManager();
            //    bool dipositInfo = dipoMangObj.DipositInfo(dipositObj);
            //    if (dipositInfo == true)
            //    {
            //        MessageBox.Show("Taka " + dipositObj.TransAmmount + " Diposited Successfully !");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Diposit Failed!");
            //    }
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
        }

       
    }


}

