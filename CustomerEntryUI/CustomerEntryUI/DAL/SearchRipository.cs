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
    public class SearchRipository
    {

        public bool CheckInfo(SearchCustomerInfo searchObj)
        {
            bool checkInfo = false;
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
            string query = @"SELECT AccountNumber FROM CustomerAndAccountInfos WHERE AccountNumber='" + searchObj.AccountNo + "'";
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

        public DataTable  SearchInfo(SearchCustomerInfo searchObj)
        {
            DataTable dt = new DataTable();
            string connectionString =
                @"Server=DESKTOP-063GM06\SQLEXPRESS;Database=CUSTOMERDATABASE;user=sa;password=mh_kaiser";
            string query = @"SELECT AccountNumber FROM CustomerAndAccountInfos WHERE AccountNumber='" + searchObj.AccountNo + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                conn.Close();

                query="SELECT CI.AccountNumber AccountNumber,CI.CustomerName CustomerName,CI.OpeningDate OpeningDate," +
                      " TR.Amount Balance FROM CustomerAndAccountInfos CI " +
                      "INNER JOIN Transactions TR ON CI.AccountNumber=TR.AccountNo WHERE CI.AccountNumber='"+searchObj.AccountNo+"'";


                comd =new SqlCommand(query,conn);
                
                SqlDataAdapter da=new SqlDataAdapter(comd);
                da.Fill(dt);
                conn.Close();
            }

            return dt;

        }
    }
}
