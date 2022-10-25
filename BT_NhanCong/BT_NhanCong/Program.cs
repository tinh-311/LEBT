using BT_NhanCong.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_NhanCong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CNhancong nc1 = new CNhancong("nv01", "Nhan vien 01", LoaiNhanCong.CoTayNghe, 10);
            CNhancong nc2 = new CNhancong("nv02", "Nhan vien 02", LoaiNhanCong.CoTayNgheCao, 24);
            CNhancong nc3 = new CNhancong("nv03", "Nhan vien 03", LoaiNhanCong.KhongCoTayNghe, 25);
            CNhancong nc4 = new CNhancong("nv04", "Nhan vien 04", LoaiNhanCong.CoTayNghe, 52);
            Dictionary<string, CNhancong> dsNC = new Dictionary<string, CNhancong>();

            dsNC.Add(nc1.Msnv, nc1);
            dsNC.Add(nc2.Msnv, nc2);
            dsNC.Add(nc3.Msnv, nc3);
            dsNC.Add(nc4.Msnv, nc4);

            CXuLyNhanCong xl = new CXuLyNhanCong(dsNC);

            xl.getDSNhanCong().ForEach(item =>
            {
                Console.WriteLine(item.Tennv);
            });

            CNhancong ncNew = new CNhancong("nv03", "Timmo", LoaiNhanCong.CoTayNghe, 150);

            xl.sua(ncNew);

            Console.WriteLine("-------------------------");

            xl.getDSNhanCong().ForEach(item =>
            {
                Console.WriteLine(item.Tennv);
            });

            Console.ReadKey();
        }
    }
}
