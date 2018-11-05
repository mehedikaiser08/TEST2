using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntryUI.Models;
using System.Data.SqlClient;

namespace CustomerEntryUI.DAL
{
    public class WithdrawRipository
    {
        public string WithdrawInfo(TransactionInfo withdrawObj)
        {
            string withdrawInfo = "";
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
            string query = @"SELECT AccountNumber FROM CustomerAndAccountInfos WHERE AccountNumber='" + withdrawObj.TranAccNo + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                conn.Close();
                query = @"SELECT Amount FROM Transactions WHERE AccountNo='" + withdrawObj.TranAccNo + "'";
                conn = new SqlConnection(connectionString);
                comd = new SqlCommand(query, conn);
                conn.Open();
                dr = comd.ExecuteReader();
                if (dr.Read())
                {
                    int balance = Convert.ToInt32(dr["Amount"]);
                    dr.Close();
                    conn.Close();

                    if (balance >= withdrawObj.TransAmmount)
                    {
                        query = @"UPDATE Transactions SET Amount=Amount-" + withdrawObj.TransAmmount + "WHERE AccountNo='" + withdrawObj.TranAccNo + "'";
                        comd = new SqlCommand(query, conn);
                        conn.Open();
                        comd.ExecuteNonQuery();
                        withdrawInfo = "Taka " + withdrawObj.TransAmmount + " withdrawn successfully !\n " +
                                       "Your currect balance is " + (balance - withdrawObj.TransAmmount);
                        conn.Close();
                    }
                    else
                    {
                        withdrawInfo = "Sorry ! No sufficient balance to withdraw.\n Your highest withdrawn limit " + balance;
                    }

                }
                else
                {
                    withdrawInfo = "No balance is diposited till now !\n Please diposit first.";
                }
            }
            else
            {
                withdrawInfo = "Account not found !\n Please create account and make diposit first.";
                //return withdrawInfo;
            }
            
            return withdrawInfo;
        }
        
    }
}
