using QLLH_.GraphColoring;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QLLH_.CTRL
{
    internal class XepLichCTRL
    {
        Connection a = new Connection();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string sql;
        public List<LTH> ListGrapColoring(int tuan,string nam)
        {
            GraphColoringCTRL g = new GraphColoringCTRL(24, 100, tuan);
            Data a = new Data();
            List<DKXLTH> ds = new List<DKXLTH>();
            ds = a.ListDKXLTH(tuan,nam);
            g.addEdge(ds);
            List<LTH> lth = new List<LTH>();
            lth = g.coloring();
            return lth;
        }

        public void Insert(string id, string malophoc,string macahoc,string tuan,string nam, string maphong)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                sql = "insert into LICHTHUCHANH(ID,Malophocphan,Macahoc,Tuan,Nam,Maphong) values(@ID,@Malophocphan,@Macahoc,@Tuan,@Nam,@Maphong)";
                cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("@Malophocphan", malophoc);
                cmd.Parameters.AddWithValue("@Macahoc", macahoc);
                cmd.Parameters.AddWithValue("@Tuan", tuan);
                cmd.Parameters.AddWithValue("@Nam", nam);
                cmd.Parameters.AddWithValue("@Maphong", maphong);
                
                if (cmd.ExecuteNonQuery()>0)
                {
                    //MessageBox.Show("Thêm Mới thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }

        }
        public void Delete(int Tuan) 
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                sql = "delete LICHTHUCHANH where Tuan = @Tuan";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Tuan", Tuan);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
                throw;
            }
        }

        public DataTable Select()
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            try
            {
                sql = "select * from LICHTHUCHANH";
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
                throw;
            }
        }

        public DataTable LichTheoTuan(int tuan, string nam)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                // sql = "select * from LICHTHUCHANH where Tuan = @tuan and Nam = @Nam";
                sql = "selectlichphongmay";
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tuan", tuan);
                cmd.Parameters.AddWithValue("@nam", nam);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
                throw;
            }
        }

        public DataTable SelectLTH(string magv,string nam)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            sql = "selectLichThucHang1";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@nam", nam);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable searchLTH(string magv, string malop)
        {
            conn = new SqlConnection();
            conn = a.Getconnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            sql = "searchLichThucHang";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", magv);
            cmd.Parameters.AddWithValue("@malop", malop);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int GetWeekOrderInYear(DateTime time)
        {
            CultureInfo myCI = CultureInfo.CurrentCulture;
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            return myCal.GetWeekOfYear(time, myCWR, myFirstDOW);
        }

        public void ExportExcel(DataTable dt, string sheetName, string title)
        {
            //tạo excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //mở excel trên workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold= true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //tạo tiêu đề cột

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên Lớp";
            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Giảng Viên";
            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Môn học";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Thứ";
            cl4.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tiết Học";
            cl5.ColumnWidth = 7;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Ngày";
            cl6.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Tên Phòng";
            cl7.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Địa chỉ";
            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");
            rowHead.Font.Bold = true;

            //kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //tạo mảng theo datatable

            object[,] arr = new object[dt.Rows.Count,dt.Columns.Count];
            //chuyển dữ liệu datatable vào mảng

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                DataRow dtRow = dt.Rows[row];
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    //arr[row, col] = dtRow[col].ToString();
                    if (col == 5)
                    {
                        arr[row, col] = DateTime.Parse(dtRow[col].ToString()).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        arr[row, col] = dtRow[col].ToString();
                    }
                }
            }
            //thiết lập vùng dữ liệu

            int rowStart = 4;
            int columnsStart = 1;
            int rowEnd = rowStart + dt.Rows.Count -2;

            int columnsEnd = columnsStart+ dt.Columns.Count-1;

            //ô bắt đầu dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnsStart];

            // ô điền cuối
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnsEnd];

            //lấy về vùng dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //điền dữ liệu vào vùng thiết lập
            range.Value2 = arr;
            //kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //căn giữa cả bảng
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //căn giữa 1 cột(id)
            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnsStart];
            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
        }
    }
}
