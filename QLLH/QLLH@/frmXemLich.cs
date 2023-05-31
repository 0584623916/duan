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
using QLLH_.CTRL;

namespace QLLH_
{
    public partial class frmXemLich : Form
    {
        public frmXemLich()
        {
            InitializeComponent();
        }

        public frmXemLich(string magv)
        {
            InitializeComponent();
            this.magv = magv;
        }
        string magv;
        string nam;
        SqlConnection conn;
        DataTable dt;
        SqlDataAdapter da;
        
        XepLichCTRL xl = new XepLichCTRL();
        DangKyLichCTRL dk = new DangKyLichCTRL();
        public void Loadcbb()
        {
            dt = new DataTable();
            dt = dk.GetDataCBB(magv);
            cbbLHP.DataSource = dt;
            cbbLHP.ValueMember = "Malophocphan";
            cbbLHP.DisplayMember = "Malophocphan";
        }
        public void LoadDGV()
        {
            nam = 2023.ToString();
            dt = new DataTable();
            dt = xl.SelectLTH(magv,nam);
            
            dgvLH.DataSource = dt;
            lbTenGiangVien.Text = dk.GetTenGV(magv);
        }
        private void frmXemLich_Load(object sender, EventArgs e)
        {
            Loadcbb();
            LoadDGV();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            string malop = cbbLHP.SelectedValue.ToString();
            dt = xl.searchLTH(magv, malop);
            dgvLH.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadcbb();
            LoadDGV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nam = comboBox1.Text;
            dt = new DataTable();
            dt = xl.SelectLTH(magv, nam);

            dgvLH.DataSource = dt;
        }
    }
}
