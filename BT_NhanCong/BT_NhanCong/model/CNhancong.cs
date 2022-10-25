using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_NhanCong.model
{
    enum LoaiNhanCong
    {
        KhongCoTayNghe=0,
        CoTayNghe=1,
        CoTayNgheCao=2,
    }

    class CNhancong
    {
        private string m_msnv;
        private string m_tennv;
        private LoaiNhanCong m_loainhancong;
        private int m_songaycong;

        /// <summary>
        ///  Constructor
        /// </summary>
        public CNhancong()
        {
            this.m_msnv = "";
            this.m_tennv = "";
            this.Loainhancong = LoaiNhanCong.KhongCoTayNghe;
            this.m_songaycong = 0;
        }

        public CNhancong(string msnv, string tennv, LoaiNhanCong loainhancong, int songaycong)
        {
            Msnv = msnv;
            Tennv = tennv;
            Loainhancong = loainhancong;
            Songaycong = songaycong;
        }

        /// <summary>
        /// Methods
        /// </summary>
        /// <returns></returns>
        public double tiencong()
        {
            double res = 0;

            switch(this.Loainhancong)
            {
                case LoaiNhanCong.CoTayNghe:
                    {
                        res = 200000 * this.Songaycong;
                        break;
                    }
                case LoaiNhanCong.CoTayNgheCao:
                    {
                        res = 280000 * this.Songaycong;
                        break;
                    }
                default:
                    {
                        res = 120000 * this.Songaycong;
                        break;
                    }
            }

            return res;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public string Msnv { get => m_msnv; set => m_msnv = value; }
        public string Tennv { get => m_tennv; set => m_tennv = value; }
        public int Songaycong { get => m_songaycong; set => m_songaycong = value; }
        internal LoaiNhanCong Loainhancong { get => m_loainhancong; set => m_loainhancong = value; }
    }
}
