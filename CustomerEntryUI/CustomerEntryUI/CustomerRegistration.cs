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
    public partial class CustomerRegistration : Form
    {
        
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        Registration registrationObj = new Registration();
        RegistrationManager regiManagerObj = new RegistrationManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
                registrationObj.CustomerName = custNameTextBox.Text;
                registrationObj.Email = emailTextBox.Text;
                registrationObj.AccountNumber = accountNumTextBox.Text;
                registrationObj.OpeningDate = openingDateTextBox.Text;


            System.Text.RegularExpressions.Regex expr= new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (expr.IsMatch(registrationObj.Email))
                {
                  //MessageBox.Show("valid");
                }
               

                else
                {
                    MessageBox.Show("Email Id is not valid");
                    return;
                }
                   

                if (registrationObj.CustomerName == "" || registrationObj.Email == "" || registrationObj.AccountNumber == "" || registrationObj.OpeningDate == "")
            {
                MessageBox.Show("No empty value accepted !");
                return;
            }

            if (registrationObj.AccountNumber.Length != 8)
            {
                MessageBox.Show("Account number length should be 8");
                return;
            }

            bool sameInfo = regiManagerObj.CheckInfo(registrationObj);

            if (sameInfo == true)
            {
                MessageBox.Show("Account Already Exist !");
                 return;
            }



            bool registrationInfo = regiManagerObj.SaveRegistrationInfo(registrationObj);
            if (registrationInfo == true)
            {
                MessageBox.Show("Save successfully !");
            }
            else
            {
                MessageBox.Show("Save Failed !");
            }


           
        }
    }
}
