using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLLH_.GraphColoring
{
    internal class Data
    {
        // SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=NCKH_QLLH;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=NCKH_QLLH;Integrated Security=True");
        public void openConnect()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void closeConnect()
        {
            conn.Close();
        }

        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;

        public List<GiaoVien> ListGiangVien()
        {
            List<GiaoVien> ds = new List<GiaoVien>();
            string sql = "select * from GIANGVIEN";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien vn = new GiaoVien();
                vn.MaGiaoVien = dt.Rows[i][0].ToString();
                vn.HoTenGiangVien = dt.Rows[i][1].ToString();
                vn.Username1 = dt.Rows[i][2].ToString();
                ds.Add(vn);
            }

            return ds;
        }
        public List<LHP> ListLHP()
        {
            List<LHP> ds = new List<LHP>();
            string sql = "select * from LOPHOCPHAN";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LHP lhp = new LHP();
                lhp.MaHocPhan = dt.Rows[i][0].ToString();
                lhp.MonHoc = dt.Rows[i][1].ToString();
                lhp.LopDanhNghia = dt.Rows[i][2].ToString();
                lhp.MaGiaoVien = dt.Rows[i][3].ToString();
                ds.Add(lhp);
            }

            return ds;
        }


        public List<LHPDC> ListLHPDC()
        {
            List<LHPDC> ds = new List<LHPDC>();
            string sql = "select * from LICHHOCLOPDACO";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LHPDC lhpdc = new LHPDC();
                lhpdc.MaHocPhan = dt.Rows[i][0].ToString();
                lhpdc.MaCaHoc = dt.Rows[i][1].ToString();
                lhpdc.Tuan = dt.Rows[i][2].ToString();
                lhpdc.Nam = dt.Rows[i][3].ToString();
                ds.Add(lhpdc);
            }
            return ds;
        }

        public List<DKXLTH> ListDKXLTH(int tuan,string nam)
        {
            /* List<DKXLTH> ds = new List<DKXLTH>();
             string sql = "select * from DANGKIXEPLICHTHUCHANH where Tuan = @tuan and Nam = @Nam";
             cmd = new SqlCommand(sql, conn);
             cmd.Parameters.AddWithValue("@tuan", tuan);
             cmd.Parameters.AddWithValue("@Nam", nam);
             da = new SqlDataAdapter(cmd);
             dt = new DataTable();
             da.Fill(dt);*/

            List<DKXLTH> ds = new List<DKXLTH>();
            string sql = "select * from DANGKIXEPLICHTHUCHANH where Tuan = @tuan and Nam = @Nam";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tuan", tuan);
            cmd.Parameters.AddWithValue("@Nam", nam);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DKXLTH dkxlth = new DKXLTH();
                LHP lhp = new LHP();
                string sql1 = "select * from LOPHOCPHAN where Malophocphan = @Malophocphan";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@Malophocphan", dt.Rows[i][1].ToString());
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                lhp.MaHocPhan = dt1.Rows[0][0].ToString();
                lhp.MonHoc = dt1.Rows[0][1].ToString();
                lhp.LopDanhNghia = dt1.Rows[0][2].ToString();
                lhp.MaGiaoVien = dt1.Rows[0][3].ToString();

                dkxlth.Id = dt.Rows[i][0].ToString();
                dkxlth.MaLopHocPhan = lhp;
                dkxlth.Tuan = dt.Rows[i][2].ToString();
                dkxlth.SoLuongCa = Convert.ToInt32(dt.Rows[i][3].ToString());
                dkxlth.Nam = dt.Rows[i][4].ToString();

                ds.Add(dkxlth);
            }
            return ds;
        }

        public List<LTH> ListLTH()
        {
            List<LTH> ds = new List<LTH>();
            string sql = "select * from LICHTHUCHANH";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LTH lth = new LTH();
                lth.Id = dt.Rows[i][0].ToString();
                lth.MaHocPhan = dt.Rows[i][1].ToString();
                lth.MaCaHoc = Convert.ToInt32(dt.Rows[i][2].ToString());
                lth.Tuan = dt.Rows[i][3].ToString();
                lth.Nam = dt.Rows[i][4].ToString();
                lth.MaPhong = dt.Rows[i][5].ToString();
                ds.Add(lth);
            }
            return ds;
        }

        public List<PM> ListPM()
        {
            List<PM> ds = new List<PM>();
            string sql = "select * from PHONGTHUCHANH";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PM pm = new PM();
                pm.MaPhong = dt.Rows[i][0].ToString();
                pm.TenPhong = dt.Rows[i][1].ToString();
                pm.DiaChi = dt.Rows[i][2].ToString();
                ds.Add(pm);
            }
            return ds;
        }
    }
}
