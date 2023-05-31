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
    public partial class frmDKCaTrong : Form
    {
        public frmDKCaTrong()
        {
            InitializeComponent();
        }

        public frmDKCaTrong(string malop, int tuan, string namhoc)
        {
            InitializeComponent();
            this.malop = malop;
            this.tuan = tuan;
            this.namhoc = namhoc;
        }
        public int kt = 0;
        public string malop;
        public int tuan;
        public string namhoc;
        public string id = Form1.id;
        DKCaTrongCTRL dk = new DKCaTrongCTRL();
        DataTable dt = new DataTable();
        private void Xeplich_Load(object sender, EventArgs e)
        {
            dgvXepLich.Rows.Add(4);
            dgvXepLich.Rows[0].Cells[0].Value = "Tiết 1-3";
            dgvXepLich.Rows[1].Cells[0].Value = "Tiết 4-6";
            dgvXepLich.Rows[2].Cells[0].Value = "Tiết 7-9";
            dgvXepLich.Rows[3].Cells[0].Value = "Tiết 10-12";
            dgvXepLich.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*dt = new DataTable();
            dt = dk.getData(id);
            lbGV.Text = dt.Rows[0][0].ToString();
            lbLHP.Text = dt.Rows[0][1].ToString();*/
            lbGV.Text = malop;
            lbLHP.Text = tuan.ToString();
            lbNamHoc.Text = namhoc;
        }
        DKCaTrongCTRL dkca = new DKCaTrongCTRL();
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (dkca.Check(malop,tuan))
            {
                MessageBox.Show("Lớp " + malop + " đã được đăng ký trong tuần " + tuan);
                kt = 1;
            }
            else
            {
                int i, j;
                CheckBox[][] checkBox;
                int index = 0;
                dgvXepLich.EndEdit();
                try
                {
                    for (i = 0; i < dgvXepLich.RowCount; i++)
                    {
                        for (j = 1; j < dgvXepLich.ColumnCount; j++)
                        {
                            if (Convert.ToBoolean(dgvXepLich.Rows[i].Cells[j].Value) == true)
                            {
                                //MessageBox.Show("" +(((i*6) +j) -1));
                                string maca = ("" + (((i * 6) + j) - 1));
                                dkca.Insert(malop, maca, tuan, namhoc);
                                kt = 2;
                            }
                        }
                    }
                    if (kt ==2)
                    {
                        MessageBox.Show("Đã Xong.!!!");
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn Lịch");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn Lịch Không Thành Công");
                    throw;
                }
            }
            
        }
    }
}
