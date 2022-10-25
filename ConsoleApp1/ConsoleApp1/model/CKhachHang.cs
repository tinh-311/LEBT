using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    class CKhachHang
    {
        private string maSoDK;
        private string tenKH;
        private int chiSoCu;
        private int chiSoMoi;

        /// <summary>
        /// Constructor
        /// </summary>
        public CKhachHang()
        {
            maSoDK = "";
            tenKH = "";
            chiSoCu = 0;
            chiSoMoi = 0;
        }

        public CKhachHang(string maSoDK, string tenKH, int chiSoCu, int chiSoMoi)
        {
            this.maSoDK = maSoDK;
            this.tenKH = tenKH;
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
        }

        public double tinhTiendien()
        {
            double thanhtien = 0;
            if (tinhSodien() <= 50)
            {
                thanhtien = (double)tinhSodien() * 1800;
            }
            else if (tinhSodien() >= 50 && tinhSodien() <= 150)
            {
                thanhtien = (double)tinhSodien() * 2300;
            }
            else
            {
                thanhtien = (double)tinhSodien() * 3200;
            }

            return thanhtien;
        }

        public int tinhSodien()
        {
            return (chiSoMoi - chiSoCu);
        }

        public string MaSoDK { get => maSoDK; set => maSoDK = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int ChiSoCu { get => chiSoCu; set => chiSoCu = value; }
        public int ChiSoMoi { get => chiSoMoi; set => chiSoMoi = value; }
    }
}
