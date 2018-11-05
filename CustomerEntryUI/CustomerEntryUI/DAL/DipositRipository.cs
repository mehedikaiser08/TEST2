using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.Models;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CustomerEntryUI.DAL
{
    public class DipositRipository
    {
        bool checkInfo = false;
        public bool CheckInfo(TransactionInfo dipositObj)
        {
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
            string query = @"SELECT AccountNumber FROM CustomerAndAccountInfos WHERE AccountNumber='" + dipositObj.TranAccNo + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                checkInfo = true;
                conn.Close();
                
            }
            return checkInfo;

        }

        public bool DipositInfo(TransactionInfo dipositObj)
        {
            bool dipositInfo = false;
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
            string query = @"SELECT AccountNo FROM Transactions WHERE AccountNo='" + dipositObj.TranAccNo + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                conn.Close();
                query = @"UPDATE Transactions SET Amount=Amount+" + dipositObj.TransAmmount + "WHERE AccountNo='" + dipositObj.TranAccNo + "'";
                comd = new SqlCommand(query, conn);
                conn.Open();
                comd.ExecuteNonQuery();
                dipositInfo = true;
                conn.Close();
               // return dipositInfo;
            }
            else
            {
                dr.Close();
                query = @"INSERT INTO Transactions(Amount,AccountNo)VALUES(" + dipositObj.TransAmmount + ",'" +
                        dipositObj.TranAccNo + "')";

                comd = new SqlCommand(query, conn);
                int rowAffected = comd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    dipositInfo = true;
                }
                conn.Close();

               // return dipositInfo; 
            }

            return dipositInfo;
        }
           
        
    }
}
