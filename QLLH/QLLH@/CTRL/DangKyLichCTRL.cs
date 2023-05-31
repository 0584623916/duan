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
    internal class DangKyLichCTRL
    {
        Connection a = new Connection();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string sql;

        public string GetTenGV(string maGV)
        {
            String sql = "select HoTenGiangVien from GIANGVIEN where Magiangvien = @Magiangvien";
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Magiangvien", maGV);
            var ten = cmd.ExecuteScalar();
            return ten.ToString();
        }
        public DataTable GetDataCBB(string maGV)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            String sql = "select * from LOPHOCPHAN l inner join GIANGVIEN g on g.Magiangvien = l.Giaoviengiangday where l.Giaoviengiangday= @Magiangvien";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Magiangvien", maGV);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetData(string maGV)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            String sql = "select " +
                "d.ID,d.Malophocphan,g.HoTenGiangVien,d.Tuan,d.SoluongCa, d.Nam " +
                "from DANGKIXEPLICHTHUCHANH d " +
                "inner join LOPHOCPHAN l on l.Malophocphan = d.Malophocphan " +
                "inner join GIANGVIEN g on g.Magiangvien = l.Giaoviengiangday " +
                "where g.Magiangvien = @Magiangvien";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Magiangvien", maGV);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool CheckID(string ID)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string sqlCheckMaGV = "select * from DANGKIXEPLICHTHUCHANH where ID = @ID";
            SqlCommand cmdCheckMaGV = new SqlCommand(sqlCheckMaGV, conn);
            cmdCheckMaGV.Parameters.AddWithValue("@ID", ID);
            da = new SqlDataAdapter(cmdCheckMaGV);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Insert(string maLopHP, int tuan, string soluong, string nam)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            /*if (CheckID(ID) == true)
            {
                MessageBox.Show("ID Đã Tồn Tại");
            }*/
            try
            {
                string sql = "insert into DANGKIXEPLICHTHUCHANH(Malophocphan,Tuan,SoluongCa,Nam) values(@Malophocphan,@Tuan,@SoluongCa,@Nam)";
                cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Malophocphan", maLopHP);
                cmd.Parameters.AddWithValue("@Tuan", tuan);
                cmd.Parameters.AddWithValue("@SoluongCa", soluong);
                cmd.Parameters.AddWithValue("@Nam", nam);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đăng Ký Thành Công Thành Công");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Đăng Ký Thất Bại!...." + e.ToString());
                throw;
            }
        }

        public void Delete(string ID)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckID(ID) == true)
            {
                try
                {
                    string sql = "delete DANGKIXEPLICHTHUCHANH where ID =@ID";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Hủy Đăng Ký Thành Công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hủy Đăng Ký thất bại..." + ex.ToString());
                    throw;
                }

            }
            else
            {
                MessageBox.Show("ID Không Tồn Tại");
            }
        }

        public DataTable search(string tukhoa,string magv)
        {
            sql = "searchDangKyLichHoc";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
            cmd.Parameters.AddWithValue("@magv", magv);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
