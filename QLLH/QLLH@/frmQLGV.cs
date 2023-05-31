using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data;
using System.Data.SqlClient;

namespace QLLH_
{
    public partial class frmQLGV : Office2007Form
    {
        GiaoVienCTL gv = new GiaoVienCTL();
        Connection conn = new Connection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public frmQLGV()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadDGV()
        {
            dt = new DataTable();
            dt = gv.GetData();
            dgvGV.DataSource = dt;
        }
        private void frmQLGV_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtTenGV.Text;
            string userName = txtTK.Text;
            string passWord = txtMK.Text;
            gv.Insert(maGV,tenGV, userName, passWord);

            LoadDGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtTenGV.Text;
            string userName = txtTK.Text;
            string passWord = txtMK.Text;
            
            
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa : " + maGV + " Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                gv.Delete(maGV, userName);
            }
            LoadDGV();

        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chondong = -1;
            chondong = dgvGV.CurrentCell.RowIndex;
            txtMaGV.Text = dgvGV.Rows[chondong].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGV.Rows[chondong].Cells[1].Value.ToString();
            txtTK.Text = dgvGV.Rows[chondong].Cells[2].Value.ToString();
            txtMK.Text = dgvGV.Rows[chondong].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string tenGV = txtTenGV.Text;
            string userName = txtTK.Text;
            string passWord = txtMK.Text;
            gv.Update(maGV, tenGV, userName, passWord);
            LoadDGV();  
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            dt = new DataTable();
            dt = gv.search(tukhoa);
            dgvGV.DataSource = dt;
        }

        private void dgvGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int chondong = -1;
            chondong = dgvGV.CurrentCell.RowIndex;
            string maGV = dgvGV.Rows[chondong].Cells[0].Value.ToString();
            frmDangKyLich fr = new frmDangKyLich(maGV);
            fr.ShowDialog();
        }

        private void txtMaGV_TextChanged_1(object sender, EventArgs e)
        {
            txtTK.Text = txtMaGV.Text;
        }


        private void txtTenGV_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            dt = new DataTable();
            dt = gv.search(tukhoa);
            dgvGV.DataSource = dt;
        }
    }
}
