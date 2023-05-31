using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLH_.CTRL;

namespace QLLH_
{
    public partial class frmQLPM : Form
    {
        public frmQLPM()
        {
            InitializeComponent();
        }
        PhongMayCTRL pm = new PhongMayCTRL();
        DataTable dt = new DataTable();
        public void LoadDGV()
        {
            dt = pm.GetTablePM();
            dgvQLPM.DataSource = dt;
        }
        private void frmQLPM_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void frmQLPM_Load_1(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string tenPM = txtTenPM.Text;
            string diachi = txtDiaChi.Text;

            pm.Insert(maPM, tenPM, diachi);
            LoadDGV();
        }

        private void dgvQLPM_MouseClick(object sender, MouseEventArgs e)
        {
            int chondong = -1;
            chondong = dgvQLPM.CurrentCell.RowIndex;
            txtMaPM.Text = dgvQLPM.Rows[chondong].Cells[0].Value.ToString();
            txtTenPM.Text = dgvQLPM.Rows[chondong].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvQLPM.Rows[chondong].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string tenPM = txtTenPM.Text;
            string diachi = txtDiaChi.Text;

            pm.update(maPM, tenPM, diachi);
            LoadDGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Maphong = txtMaPM.Text;
            if (pm.CheckID(Maphong))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa : " + Maphong + " Không???", "!Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pm.Delete(Maphong);
                }
            }
            else
            {
                MessageBox.Show("Mã Phòng Không Chính Xác.! Vui lòng kiểm tra lại");
            }

            LoadDGV();
        }
    }
}
