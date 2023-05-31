using QLLH_.CTRL;
using QLLH_.GraphColoring;
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
    public partial class FrmXepLich : Form
    {
        public FrmXepLich()
        {
            InitializeComponent();
        }

        XepLichCTRL xl = new XepLichCTRL();
        DataTable dt;
        public void LoadForm()
        {
            btnXepLich.Hide();
            btnXepLichLai.Hide();
            btnInLich.Hide();
            dgvXL.DataSource = null;
        }
        private void btnXepLich_Click(object sender, EventArgs e)
        {
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string nam = dateTimePicker1.Value.Year.ToString();
            List<LTH> lth = new List<LTH>();
            lth = xl.ListGrapColoring(tuan,nam);
            foreach (LTH l in lth)
            {
                /*ListViewItem item = listView1.Items.Add(l.Id);
                item.SubItems.Add(l.MaHocPhan);
                item.SubItems.Add(l.MaCaHoc.ToString());
                item.SubItems.Add(l.Tuan);
                item.SubItems.Add(l.Nam);
                item.SubItems.Add(l.MaPhong);*/
                xl.Insert(l.Id, l.MaHocPhan, l.MaCaHoc.ToString(), l.Tuan, l.Nam, l.MaPhong);
            }

            dt = new DataTable();
            dt = xl.LichTheoTuan(tuan, nam);
            dgvXL.DataSource = dt;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string nam = dateTimePicker1.Value.Year.ToString();
            dt = new DataTable();
            dt = xl.LichTheoTuan(tuan, nam);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Tuần " + tuan + " năm " + nam + " đã được xếp lịch.!");
                dgvXL.DataSource = dt;
                btnXepLichLai.Show();
                btnInLich.Show();
            }
            else
            {
                MessageBox.Show("Tuần " + tuan + " năm " + nam + " chưa được xếp lịch.!");
                btnXepLich.Show();
            }
            
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

        private void btnXepLichLai_Click(object sender, EventArgs e)
        {
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string nam = dateTimePicker1.Value.Year.ToString();
            xl.Delete(tuan);
            try
            {
                List<LTH> lth = new List<LTH>();
                lth = xl.ListGrapColoring(tuan, nam);
                foreach (LTH l in lth)
                {
                    /*ListViewItem item = listView1.Items.Add(l.Id);
                    item.SubItems.Add(l.MaHocPhan);
                    item.SubItems.Add(l.MaCaHoc.ToString());
                    item.SubItems.Add(l.Tuan);
                    item.SubItems.Add(l.Nam);
                    item.SubItems.Add(l.MaPhong);*/
                    xl.Insert(l.Id, l.MaHocPhan, l.MaCaHoc.ToString(), l.Tuan, l.Nam, l.MaPhong);
                }
                dt = new DataTable();
                dt = xl.LichTheoTuan(tuan, nam);
                dgvXL.DataSource = dt;
                btnInLich.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void FrmXepLich_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnInLich_Click(object sender, EventArgs e)
        {
            int tuan = xl.GetWeekOrderInYear(dateTimePicker1.Value);
            string nam = dateTimePicker1.Value.Year.ToString();
            dt = new DataTable();
            dt = xl.LichTheoTuan(tuan, nam);
            xl.ExportExcel(dt, "DanhSach", "Danh Sách phòng máy tuần " + tuan + " nam " + nam);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
