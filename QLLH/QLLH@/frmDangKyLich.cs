using QLLH_.CTRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLH_
{
    public partial class frmDangKyLich : Form
    {
        public frmDangKyLich(string maGv)
        {
            InitializeComponent();
            this.maGV = maGv;
        }

        public frmDangKyLich()
        {
        }
        XepLichCTRL xl = new XepLichCTRL();
        DangKyLichCTRL dk = new DangKyLichCTRL();
        string maGV;
        Connection conn = new Connection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string sql;

        public void LoadDGV()
        {
            dt = new DataTable();
            dt = dk.GetData(maGV);
            dgvDangKy.DataSource = dt; 
        }
        public void loadCBB()
        {
            dt = new DataTable();
            dt = dk.GetDataCBB(maGV);
            cbbMaHocPhan.DataSource = dt;
            cbbMaHocPhan.ValueMember = "Malophocphan";
            cbbMaHocPhan.DisplayMember = "Malophocphan";
        }

        private void frmDangKyLich_Load(object sender, EventArgs e)
        {
            btnChonLichHoc.Hide();
            LoadDGV();
            loadCBB();
            lbTenGiangVien.Text = dk.GetTenGV(maGV);
        }

        private void txtTuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSLC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        
        private void dgvDangKy_MouseClick(object sender, MouseEventArgs e)
        {
            int chondong = -1;
            chondong = dgvDangKy.CurrentCell.RowIndex;
            txtID.Text = dgvDangKy.Rows[chondong].Cells[0].Value.ToString();
            cbbMaHocPhan.Text = dgvDangKy.Rows[chondong].Cells[1].Value.ToString();
            //txtTuan.Text = dgvDangKy.Rows[chondong].Cells[3].Value.ToString();
            txtSLC.Text = dgvDangKy.Rows[chondong].Cells[4].Value.ToString();
            //txtNam.Text = dgvDangKy.Rows[chondong].Cells[5].Value.ToString();
        }

        

        

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string tukhoa = txtTuKhoa.Text;
            dt = new DataTable();
            dt = dk.search(tukhoa,maGV);
            dgvDangKy.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string malop = cbbMaHocPhan.Text;
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string soluong = txtSLC.Text;
            string nam = comboBox1.Text;

            frmDKCaTrong f = new frmDKCaTrong(malop, tuan, nam);
            f.ShowDialog();
            if (f.kt == 2)
            {
                dk.Insert(malop, tuan, soluong, nam);

                LoadDGV();
                loadCBB();
            }
            else if (f.kt ==1)
            {
                
            }
            else
            {
                MessageBox.Show("chưa chọn lịch đã có.");
            }

            //MessageBox.Show("aaaaa");


        }
        DKCaTrongCTRL dkca = new DKCaTrongCTRL();
        private void button2_Click_1(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string malop = cbbMaHocPhan.Text;
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string soluong = txtSLC.Text;
            string nam = comboBox1.Text;
            DialogResult result = MessageBox.Show("Bạn có chắn muốn xóa Lịch Đăng Ký của lớp: "+malop+" vào tuần học: "+tuan+" không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                dk.Delete(ID);
                dkca.Delete(malop, tuan);
            }

            LoadDGV();
            loadCBB();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnChonLichHoc_Click(object sender, EventArgs e)
        {
            string malop = cbbMaHocPhan.Text;
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string namhoc = comboBox1.Text;
            frmDKCaTrong f = new frmDKCaTrong(malop,tuan,namhoc);
            f.ShowDialog();
        }

    }
}
