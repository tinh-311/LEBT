using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    class CXuLyKH
    {
        private List<CKhachHang> dsKH;


        /// <summary>
        /// Cau 1: Constructor
        /// </summary>
        public CXuLyKH()
        {
            dsKH = new List<CKhachHang>();
        }

        public CXuLyKH(List<CKhachHang> list)
        {
            this.dsKH = list;
        }

        /// <summary>
        /// Cau 2
        /// </summary>
        /// <returns></returns>
        public List<CKhachHang> getDanhSachKH()
        {
            return dsKH;
        }

        /// <summary>
        /// cau 3
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public CKhachHang tim(string ma)
        {
            CKhachHang c = null;

            foreach (CKhachHang kh in dsKH)
            {
                if(kh.MaSoDK == ma)
                {
                    c = kh;
                }
            }

            //list.ForEach(item =>
            //{
            //    if(item.MaSoDK == ma)
            //    {
            //        c = item;
            //    }
            //});

            return c;
        }

        public double tong()
        {
            double result = 0;

            foreach(CKhachHang kh in dsKH)
            {
                result += kh.tinhTiendien();
            }

            return result;
        }
    }
}
