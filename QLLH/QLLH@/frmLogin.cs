using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLLH_
{
    public partial class frmLogin : Form
    {

        public string roles;
        SqlConnection conn;

        public frmLogin()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=NCKH_QLLH;Integrated Security=True");
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text !="" || txtUserName.Text != "")
            {
                string tk = txtUserName.Text;
                string mk = txtpassword.Text;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string sql = "select * from [User] where UserName = '" + tk + "' and [PassWord] = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    roles = dt.Rows[dt.Rows.Count - 1][2].ToString();
                    MessageBox.Show("Đăng nhập thành công với tư cách là: " + roles);
                    Form1 f = new Form1(tk, roles);
                    f.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.!");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ tài khoản mật khẩu");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtpassword.Text = "";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
