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
    internal class PhongMayCTRL
    {
        Connection a = new Connection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection conn;

        public DataTable GetTablePM()
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            string sqlCheck = "select * from PHONGTHUCHANH";
            cmd = new SqlCommand(sqlCheck, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool CheckID(string Maphong)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string sql = "select * from PHONGTHUCHANH where Maphong =@Maphong";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Maphong", Maphong);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Insert(string Maphong, string Tenphong, string Diachiphong)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (CheckID(Maphong) == true)
            {
                MessageBox.Show("Phòng Đã Tồn Tại");
            }
            else
            {
                try
                {
                    string sql = "insert into PHONGTHUCHANH(Maphong, Tenphong,Diachiphong) values(@Maphong, @Tenphong,@Diachiphong)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Maphong", Maphong);
                    cmd.Parameters.AddWithValue("@Tenphong", Tenphong);
                    cmd.Parameters.AddWithValue("@Diachiphong", Diachiphong);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Tạo Mới Phòng Thành Công");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Tạo Mới Phòng Thất Bại!...." + e.ToString());
                    throw;
                }

            }
        }

        public void update(string Maphong, string Tenphong, string Diachiphong)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckID(Maphong) == true)
            {
                try
                {
                    string sql = "update PHONGTHUCHANH set Tenphong = @Tenphong, Diachiphong = @Diachiphong where Maphong =@Maphong";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Maphong", Maphong);
                    cmd.Parameters.AddWithValue("@Tenphong", Tenphong);
                    cmd.Parameters.AddWithValue("@Diachiphong", Diachiphong);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thay đổi Thành Công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thay đổi Không được chấp nhận..." + ex.ToString());
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Mã Phòng Không Tồn Tại");
            }
        }

        public void Delete(string Maphong)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckID(Maphong) == true)
            {
                try
                {
                    string sql = "delete PHONGTHUCHANH where Maphong =@Maphong";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Maphong", Maphong);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa Thành Công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại..." + ex.ToString());
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Mã Phòng Không Tồn Tại");
            }
        }
    }
}
