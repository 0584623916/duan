using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLLH_
{
    internal class Connection
    {
        //string connectionString = @"Data Source=DESKTOP-MM0H4N8\SQLEXPRESS;Initial Catalog=NCKH_QLLH;Integrated Security=True";
        string connectionString = @"Data Source=.;Initial Catalog=NCKH_QLLH;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        
        public SqlConnection Getconnection()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show("connection faild: " + e.ToString());
               
            }
            return conn;
        }    

        public void OpenData()
        {
            if (Getconnection().State == ConnectionState.Closed)
            {
                Getconnection().Open();
            }
        }
        public void CloseData()
        {
            if (Getconnection().State == ConnectionState.Open)
            {
                Getconnection().Close();
            }
        }

    }
}
