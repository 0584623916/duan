using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLLH_.CTRL
{
    internal class DKCaTrongCTRL
    {
        Connection a = new Connection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection conn;
        string sql;


        public void Insert(string malop,string maca,int tuan, string nam)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                sql = "insert into LICHHOCLOPDACO(Malophocphan,Macahoc,Tuan,Nam) values(@Malophocphan,@Macahoc,@Tuan,@Nam)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Malophocphan", malop);
                cmd.Parameters.AddWithValue("@Macahoc", maca);
                cmd.Parameters.AddWithValue("@Tuan", tuan);
                cmd.Parameters.AddWithValue("@Nam", nam);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("Đã xong.!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại.!" + ex.ToString());
                throw;
            }
        }

        public void Delete(string malophoc, int tuan)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                sql = "delete LICHHOCLOPDACO where Malophocphan = @Malophocphan and Tuan = @Tuan";
                cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@Malophocphan", malophoc);
                cmd.Parameters.AddWithValue("@Tuan", tuan);
                if (cmd.ExecuteNonQuery()>0)
                {
                    //MessageBox.Show("Đã xong.!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public Boolean Check(string malop, int tuan)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                sql = "select * from LICHHOCLOPDACO where Malophocphan = @Malophocphan and Tuan = @Tuan";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Malophocphan", malop);
                cmd.Parameters.AddWithValue("@Tuan", tuan);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
