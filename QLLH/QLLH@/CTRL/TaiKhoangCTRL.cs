using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLLH_
{
    internal class TaiKhoangCTRL
    {
        Connection a = new Connection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection conn;
        

        public DataTable GetTableUser()
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            string sqlCheck = "select * from [User]";
            cmd = new SqlCommand(sqlCheck, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CheckUserName(string userName)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string sql = "select * from [User] where UserName = @UserName";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        
        public void Insert(string userName, string passWord, string role)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (CheckUserName(userName)==true)
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại");
            }
            else 
            {
                try
                {
                    string sql = "insert into [User](UserName,[PassWord],[Role]) values (@UserName,@PassWord,@Role)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@PassWord", passWord);
                    cmd.Parameters.AddWithValue("@Role", role);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Tạo Tài Khoản Thành Công");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Tạo Tài Khoản Thất Bại!...." + e.ToString());
                    throw;
                }
                
            } 
        }

        public void update(string userName, string passWord, string role)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckUserName(userName) == true)
            {
                try
                {
                    string sql = "update [User] set [PassWord] = @PassWord , [Role] = @Role where userName = @userName";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@PassWord", passWord);
                    cmd.Parameters.AddWithValue("@Role", role);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thay đổi đã được chấp nhận");
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
                MessageBox.Show("Tài Khoản Không Tồn Tại");
            }    
        }

        public void Delete(string userName)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            if (CheckUserName(userName) == true)
            {
                try
                {
                    string sql = "delete [User] where [UserName] = @UserName";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);

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
                MessageBox.Show("Tài Khoản Không Tồn Tại");
            }
        }
    }
}
