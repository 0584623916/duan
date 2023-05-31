using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLH_.GraphColoring
{
    internal class LTH
    {
        private string id;
        private string maHocPhan;
        private string tuan, nam;
        private int maCaHoc;
        private string maPhong;

        public string Id { get => id; set => id = value; }
        public string Tuan { get => tuan; set => tuan = value; }
        public string Nam { get => nam; set => nam = value; }
        public int MaCaHoc { get => maCaHoc; set => maCaHoc = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
    }
}
