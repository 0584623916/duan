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
    internal class GiaoVienCTL
    {
        
        Connection a = new Connection();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string sql;

        public DataTable GetData()
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            String sql = "select g.Magiangvien,g.HoTenGiangVien,u.UserName,u.[PassWord] from GIANGVIEN g inner join [User] u on u.UserName = g.UserName";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetDataMaGV(string magv)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            string sql = "select * from GIANGVIEN where Magiangvien = '"+magv+"'";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CheckMaGV(string maGV)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string sqlCheckMaGV = "select * from GIANGVIEN where Magiangvien = @Magiangvien";
            SqlCommand cmdCheckMaGV = new SqlCommand(sqlCheckMaGV, conn);
            cmdCheckMaGV.Parameters.AddWithValue("@Magiangvien", maGV);
            da = new SqlDataAdapter(cmdCheckMaGV);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckUserName(string userName)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string sqlCheckUserName = "select * from [User] where UserName = @UserName";
            SqlCommand cmdCheckUserName = new SqlCommand(sqlCheckUserName, conn);
            cmdCheckUserName.Parameters.AddWithValue("@UserName", userName);
            da = new SqlDataAdapter(cmdCheckUserName);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Insert(string maGV, string tenGV, string userName, string password)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (CheckMaGV(maGV) == true)
            {
                MessageBox.Show("Mã Giáo Viên Đã Tồn Tại");
            }
            else if (CheckUserName(userName) == true)
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại");
            }
            else
            {
                try
                {
                    string sqlUser = "insert into [User](UserName,[PassWord],[Role]) values (@UserName,@PassWord,@Role)";
                    SqlCommand cmdUser = new SqlCommand(sqlUser, conn);
                    cmdUser.Parameters.AddWithValue("@UserName", userName);
                    cmdUser.Parameters.AddWithValue("@PassWord", password);
                    cmdUser.Parameters.AddWithValue("@Role", "user");
                    if (cmdUser.ExecuteNonQuery() > 0)
                    {
                        string sqlGV = "insert into GIANGVIEN(Magiangvien,HoTenGiangVien,UserName) values(@Magiangvien,@HoTenGiangVien,@UserName)";
                        SqlCommand cmdGV = new SqlCommand(sqlGV, conn);
                        cmdGV.Parameters.AddWithValue("@Magiangvien", maGV);
                        cmdGV.Parameters.AddWithValue("@HoTenGiangVien", tenGV);
                        cmdGV.Parameters.AddWithValue("@UserName", userName);
                        if (cmdGV.ExecuteNonQuery()>0)
                        {
                            MessageBox.Show("Thêm Mới Thành Công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm Mới thất bại.!!");
                    MessageBox.Show("Hệ Thống: "+ex.ToString());
                    throw;
                }
            }

        }

        public void Update(string maGV, string tenGV, string userName, string password)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (CheckUserName(userName)==true)
            {
                if (CheckMaGV(maGV) == true)
                {
                    try
                    {
                        string sqlUser = "update [User] set [PassWord] = @PassWord where UserName = @UserName";
                        SqlCommand cmdUser = new SqlCommand(sqlUser, conn);
                        cmdUser.Parameters.AddWithValue("@UserName", userName);
                        cmdUser.Parameters.AddWithValue("@PassWord", password);
                        if (cmdUser.ExecuteNonQuery() > 0)
                        {
                            string sqlGV = "update GIANGVIEN set HoTenGiangVien = @HoTenGiangVien where Magiangvien = @Magiangvien";
                            SqlCommand cmdGV = new SqlCommand(sqlGV, conn);
                            cmdGV.Parameters.AddWithValue("@Magiangvien", maGV);
                            cmdGV.Parameters.AddWithValue("@HoTenGiangVien", tenGV);
                            if (cmdGV.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Sửa đổi thành công.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sủa đổi thất bại.!...   " + ex.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Mã giáo Viên không đúng");
                }    
            }
            else
            {
                MessageBox.Show("Mã User Name Không đúng");
            }    
        }
        public void Delete(string maGV,string userName)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (CheckUserName(userName)==true)
            {
                if (CheckMaGV(maGV) == true)
                {
                    try
                    {
                        string sql = "delete GIANGVIEN where Magiangvien = @Magiangvien";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Magiangvien", maGV);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            string sql1 = "delete [User] where [UserName] = @UserName";
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            cmd1.Parameters.AddWithValue("@UserName", userName);
                            if (cmd1.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Xóa Thành Công");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm Mới Thất Bại.!!..   " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Giáo viên không tồn tại");
                }    
            } 
            else
            {
                MessageBox.Show("UserName không tồn tại");
            }   
        }

        public DataTable search(string tukhoa)
        {
            sql = "searchGV";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

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
    }
}
