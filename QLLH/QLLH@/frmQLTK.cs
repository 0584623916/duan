using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QLLH_
{
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }

        TaiKhoangCTRL tk = new TaiKhoangCTRL();
        DataTable dt = new DataTable();
        public void LoadDGV()
        {
            dt = tk.GetTableUser();
            dgvQLTK.DataSource = dt;
        }
        
        private void frmQLTK_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string userName = txtUser.Text;
            string passWord = txtPass.Text;
            string role = txtRole.Text;

            tk.Insert(userName, passWord, role);
            LoadDGV();
        }

        private void dgvQLTK_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvQLTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvQLTK_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgvQLTK_MouseClick(object sender, MouseEventArgs e)
        {
            int chondong = -1;
            chondong = dgvQLTK.CurrentCell.RowIndex;
            txtUser.Text = dgvQLTK.Rows[chondong].Cells[0].Value.ToString();
            txtPass.Text = dgvQLTK.Rows[chondong].Cells[1].Value.ToString();
            txtRole.Text = dgvQLTK.Rows[chondong].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;
            string role = txtRole.Text;

            if (tk.CheckUserName(userName))
            {
                tk.update(userName, passWord, role);
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Chính Xác.! Vui lòng kiểm tra lại");
            }

            LoadDGV();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            if (tk.CheckUserName(userName))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa : " + userName + " Không???", "!Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tk.Delete(userName);
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Chính Xác.! Vui lòng kiểm tra lại");
            }

            LoadDGV();
            
        }
    }
}
