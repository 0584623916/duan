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
    internal class LopHocCTRL
    {
        Connection a = new Connection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection conn;

        public DataTable GetTable()
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            string sqlCheck = "select l.Malophocphan,l.Lopdanhnghia,l.Monhoc,g.HoTenGiangVien from LOPHOCPHAN l inner join GIANGVIEN g on g.Magiangvien = l.Giaoviengiangday";
            cmd = new SqlCommand(sqlCheck, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool CheckID(string Malop)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string sql = "select * from LOPHOCPHAN where Malophocphan = @Malophocphan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Malophocphan", Malop);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Insert(string Malop, string Monhoc, string lopdanhnghia, string maGV)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (CheckID(Malop) == true)
            {
                MessageBox.Show("Mã Lớp Đã Tồn Tại");
            }
            else
            {
                try
                {
                    string sql = "insert into LOPHOCPHAN(Malophocphan,Monhoc,Lopdanhnghia,Giaoviengiangday) values(@Malophocphan,@Monhoc,@Lopdanhnghia,@Giaoviengiangday)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Malophocphan", Malop);
                    cmd.Parameters.AddWithValue("@Monhoc", Monhoc);
                    cmd.Parameters.AddWithValue("@Lopdanhnghia", lopdanhnghia);
                    cmd.Parameters.AddWithValue("@Giaoviengiangday", maGV);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Tạo Mới Lớp Học Phần Thành Công");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Tạo Mới Thất Bại!...." + e.ToString());
                    throw;
                }

            }
        }

        public void update(string Malop, string Monhoc, string lopdanhnghia, string maGV)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckID(Malop) == true)
            {
                try
                {
                    string sql = "update LOPHOCPHAN set Monhoc =@Monhoc, Lopdanhnghia= @Lopdanhnghia,Giaoviengiangday=@Giaoviengiangday where Malophocphan = @Malophocphan";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Malophocphan", Malop);
                    cmd.Parameters.AddWithValue("@Monhoc", Monhoc);
                    cmd.Parameters.AddWithValue("@Lopdanhnghia", lopdanhnghia);
                    cmd.Parameters.AddWithValue("@Giaoviengiangday", maGV);
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
                MessageBox.Show("Mã Lớp Không Tồn Tại");
            }
        }

        public void Delete(string Malop)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckID(Malop) == true)
            {
                try
                {
                    string sql = "delete LOPHOCPHAN where Malophocphan = @Malophocphan";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Malophocphan", Malop);

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
                MessageBox.Show("Mã Lớp Không Tồn Tại");
            }
        }

        public DataTable search(string tukhoa)
        {
            string sql = "SearchLop";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
