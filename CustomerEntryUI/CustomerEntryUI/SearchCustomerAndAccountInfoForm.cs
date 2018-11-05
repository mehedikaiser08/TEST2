using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerEntryUI.Models;
using CustomerEntryUI.BLL;

namespace CustomerEntryUI
{
    public partial class SearchCustomerAndAccountInfoForm : Form
    {
        public SearchCustomerAndAccountInfoForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchCustomerInfo searchObj=new SearchCustomerInfo();
            searchObj.AccountNo = searchTextBox.Text;

            if (searchObj.AccountNo=="")
            {
                MessageBox.Show("Null value not accepted !");
                return;
            }



            try
            {
                SearchManager searchManagerObj = new SearchManager();
                bool checkInfo = searchManagerObj.CheckInfo(searchObj);
                if (checkInfo==false)
                {
                    MessageBox.Show("Sorry ! Your requested Account not found !");
                    return;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            try
            {
                SearchManager searchManagerObj = new SearchManager();
                DataTable searchInfo = searchManagerObj.SearchInfo(searchObj);
                
               
                searchDataGridView.DataSource = searchInfo;
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
