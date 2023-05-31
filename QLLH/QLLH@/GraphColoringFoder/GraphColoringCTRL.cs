using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLLH_.GraphColoring
{
    internal class GraphColoringCTRL
    {
        private int numHour, numRooms;
        private int[] cnt;
        private Dictionary<string, DKXLTH> mappingID;
        private Dictionary<string, HashSet<string>> adjCourse;
        private Dictionary<string, HashSet<int>> paintedCourse, paintedLecturer, paintedBusy;
        private List<string> vertex;
        private List<LTH> ans;
        private Dictionary<int, HashSet<int>> paintedRoom;
        private string tuan;

        public GraphColoringCTRL(int numHour, int numRooms, int tuan)
        {
            mappingID = new Dictionary<string, DKXLTH>();
            adjCourse = new Dictionary<string, HashSet<string>>();
            paintedLecturer = new Dictionary<string, HashSet<int>>();
            paintedCourse = new Dictionary<string, HashSet<int>>();
            paintedRoom = new Dictionary<int, HashSet<int>>();
            vertex = new List<string>();
            this.numHour = numHour;
            this.numRooms = numRooms;
            this.cnt = new int[numHour];
            ans = new List<LTH>();
            for (int color = 0; color < numHour; color++)
            {
                paintedRoom.Add(color, new HashSet<int>() { });
            }
            this.tuan = tuan.ToString();
        }

        public void addEdge(List<DKXLTH> listCourses)
        {
            vertex = new List<string>();
            paintedBusy = new Dictionary<string, HashSet<int>>();

            foreach (DKXLTH course in listCourses)
            {
                mappingID.Add(course.Id, course);
                vertex.Add(course.Id);
                if (!paintedLecturer.ContainsKey(course.MaLopHocPhan.MaGiaoVien))
                {
                    paintedLecturer.Add(course.MaLopHocPhan.MaGiaoVien, new HashSet<int>() { });
                }
                if (!paintedCourse.ContainsKey(course.MaLopHocPhan.LopDanhNghia))
                {
                    paintedCourse.Add(course.MaLopHocPhan.LopDanhNghia, new HashSet<int>() { });
                }
                if (!paintedBusy.ContainsKey(course.MaLopHocPhan.MaHocPhan)) {
                    paintedBusy.Add(course.MaLopHocPhan.MaHocPhan, new HashSet<int>() { });
                }
            }

            List<LHPDC> listLHPDC = new Data().ListLHPDC();

            foreach (LHPDC course in listLHPDC) 
            {
                if (!paintedBusy.ContainsKey(course.MaHocPhan))
                {
                    paintedBusy.Add(course.MaHocPhan, new HashSet<int>() { });
                }
                if (course.Tuan == tuan)
                {
                    paintedBusy[course.MaHocPhan].Add(int.Parse(course.MaCaHoc));
                }
            }

            int n = listCourses.Count;

            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    string u = listCourses[i].Id;
                    string v = listCourses[j].Id;
                    if (!adjCourse.ContainsKey(u))
                    {
                        adjCourse.Add(u, new HashSet<string>() { });
                    }
                    if (!adjCourse.ContainsKey(v))
                    {
                        adjCourse.Add(v, new HashSet<string>() { });
                    }
                    if (listCourses[i].MaLopHocPhan.LopDanhNghia == listCourses[j].MaLopHocPhan.LopDanhNghia
                        || listCourses[i].MaLopHocPhan.MaGiaoVien == listCourses[j].MaLopHocPhan.MaGiaoVien)
                    {
                        adjCourse[u].Add(v);
                        adjCourse[v].Add(u);
                    }
                }
            }
        }

        public List<LTH> coloring()
        {
            vertex = vertex.OrderByDescending(v => adjCourse[v].Count).ToList();

            Dictionary<string, int> mappingColor = new Dictionary<string, int>();
            foreach (string u in vertex)
            {
                HashSet<int> adjSidePainted = new HashSet<int>();

                if (adjCourse.ContainsKey(u))
                {
                    foreach (string v in adjCourse[u])
                    {
                        if (mappingColor.ContainsKey(v))
                        {
                            adjSidePainted.Add(mappingColor[v]);
                        }
                    }
                }

                int numColor = numHour;

                for (int color = 0; color < numColor; color++)
                {
                    if (cnt[color] == numRooms) { continue; }

                    if (paintedCourse[mappingID[u].MaLopHocPhan.LopDanhNghia].Contains(color)) { continue; }

                    if (paintedLecturer[mappingID[u].MaLopHocPhan.MaGiaoVien].Contains(color)) { continue; }

                    if (paintedBusy[mappingID[u].MaLopHocPhan.MaHocPhan].Contains(color)) { continue; };

                    if (adjSidePainted.Contains(color)) { continue; }

                    LTH obj = new LTH();

                    bool flag = false;

                    for (int numRoom = 0; numRoom < numRooms; numRoom++)
                    {
                        if (!paintedRoom[color].Contains(numRoom))
                        {
                            flag = true;
                            obj.MaPhong = "PM" + (numRoom+1).ToString();
                            paintedRoom[color].Add(numRoom);
                            break;
                        }
                    }

                    if (!flag)
                    {
                        continue;
                    }

                    cnt[color]++;
                    mappingColor.Add(u, color);
                    string LDN = mappingID[u].MaLopHocPhan.LopDanhNghia;
                    string MGV = mappingID[u].MaLopHocPhan.MaGiaoVien;

                    paintedLecturer[MGV].Add(color);
                    paintedCourse[LDN].Add(color);

                    DKXLTH tmpDKXLTH = mappingID[u];

                    obj.Id = u;
                    obj.MaHocPhan = tmpDKXLTH.MaLopHocPhan.MaHocPhan;
                    obj.Tuan = tmpDKXLTH.Tuan;
                    obj.Nam = tmpDKXLTH.Nam;
                    obj.MaCaHoc = color;

                    ans.Add(obj);

                    break;
                }
            }

            return ans;
        }
    }
}
