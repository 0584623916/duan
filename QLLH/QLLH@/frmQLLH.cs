using QLLH_.CTRL;
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
    public partial class frmQLLH : Form
    {
        public frmQLLH()
        {
            InitializeComponent();

        }

        GiaoVienCTL gv = new GiaoVienCTL();
        LopHocCTRL lh = new LopHocCTRL();
        DataTable dt;

        public void loadcbb()
        {
            dt = new DataTable();
            dt = gv.GetData();
            cbbGV.DataSource = dt;
            cbbGV.DisplayMember = "HoTenGiangVien";
            cbbGV.ValueMember = "Magiangvien";
        }

        public void loadDGV()
        {
            dt = new DataTable();
            dt = lh.GetTable();
            dgvLH.DataSource = dt;
        }

        public void loadFrom()
        {
            loadcbb();
            loadDGV();
        }

        private void frmQLLH_Load(object sender, EventArgs e)
        {
            loadFrom();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMa.Text;
            string tenlop = txtLop.Text;
            //string monhoc = txtMon.Text;
            string monhoc = cbbMonHoc.Text;
            string maGV = cbbGV.SelectedValue.ToString();
            
            lh.Insert(maLop, monhoc, tenlop, maGV);
            loadFrom();
        }

        private void dgvLH_MouseClick(object sender, MouseEventArgs e)
        {
            int chondong = -1;
            chondong = dgvLH.CurrentCell.RowIndex;
            txtMa.Text = dgvLH.Rows[chondong].Cells[0].Value.ToString();
            txtLop.Text = dgvLH.Rows[chondong].Cells[1].Value.ToString();
            cbbMonHoc.Text = dgvLH.Rows[chondong].Cells[2].Value.ToString();
            cbbGV.Text = dgvLH.Rows[chondong].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string malop = txtMa.Text;
            string tenlop = txtLop.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp: " + tenlop + " không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(result == DialogResult.Yes)
            {
                lh.Delete(malop);
            }
            loadDGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMa.Text;
            string tenlop = txtLop.Text;
            string monhoc = cbbMonHoc.Text;
            string maGV = cbbGV.SelectedValue.ToString();

            lh.update(maLop, monhoc, tenlop,  maGV);
            loadFrom();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            dt = new DataTable();
            dt = lh.search(tukhoa);
            dgvLH.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            dt = new DataTable();
            dt = lh.search(tukhoa);
            dgvLH.DataSource = dt;
        }

        private void cbbGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
