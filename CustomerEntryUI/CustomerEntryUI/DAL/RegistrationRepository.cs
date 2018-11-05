using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.Models;
using System.Data.SqlClient;

namespace CustomerEntryUI.DAL
{
    public class RegistrationRepository
    {

        public bool CheckInfo(Registration registrationObj)
        {
            
                bool sameInfo = false;
                string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
                string query = @"SELECT AccountNumber FROM CustomerAndAccountInfos WHERE AccountNumber='" + registrationObj.AccountNumber + "'";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand comd = new SqlCommand(query, conn);             
                conn.Open();
                SqlDataReader dr = comd.ExecuteReader();
                if(dr.HasRows)
                {
                    sameInfo=true;
                    dr.Close();
                }
            conn.Close();
            return sameInfo;
        }
        public bool SaveRegistrationInfo(Registration registrationObj)
        {
              
                bool registrationInfo = false;
                string connectionString = @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
                string query = @"INSERT INTO CustomerAndAccountInfos(CustomerName,Email,AccountNumber,OpeningDate)VALUES('" + registrationObj.CustomerName + "','" + registrationObj.Email + "','" + registrationObj.AccountNumber + "','" + registrationObj.OpeningDate + "')";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand comd = new SqlCommand(query, conn);
                conn.Open();
                int rowAffected = comd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    registrationInfo = true;
                }
                conn.Close();
                return registrationInfo;
           
            
            
        }
    }
}
