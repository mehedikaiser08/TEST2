using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.Models;
using System.Data.SqlClient;

namespace CustomerEntryUI.DAL
{
    public class TransactionRipository
    {
        
        public bool CheckInfo(Transaction transObj)
        {
            bool sameInfo = false;
            string connectionString =
            @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";

            string query = @"SELECT AccountNumber FROM CustomerAndAccountInfos WHERE AccountNumber='" + transObj.TranAccNo + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                sameInfo = true;
            }
            
            conn.Close();
            return sameInfo;
        }

        public bool TransactionInfo(Transaction transObj)
        {
            bool transInfo = false;
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
            string query = @"SELECT AccountNo FROM Transactions WHERE AccountNo='" + transObj.TranAccNo + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.HasRows)
            {
                transInfo = true;
            }
            conn.Close();
            
            
           if(transInfo==true)
            {
              query = @"UPDATE Transactions SET Amount=(Amount+"+transObj.TransAmmount+") WHERE AccountNo='"+transObj.TranAccNo+"'";
              conn.Open();
              comd = new SqlCommand(query, conn);              
              comd.ExecuteNonQuery();
              transInfo = true;
              conn.Close();
                
            }
           else
           {
               conn.Open();
               query = "INSERT INTO Transactions(Amount,AccountNo)VALUES(" + transObj.TransAmmount + ",'" + transObj.TranAccNo + "')";
               comd = new SqlCommand(query, conn);
               int rowAffected = comd.ExecuteNonQuery();
               if (rowAffected > 0)
               {
                   transInfo = true;
               }
               conn.Close();
           }
            
            return transInfo;

        }
    }
}
