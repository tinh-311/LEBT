using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BT_NhanCong.model
{
    class CXuLyNhanCong
    {
        private Dictionary<string, CNhancong> dsNC;

        public CXuLyNhanCong(Dictionary<string, CNhancong> dsNC)
        {
            this.dsNC = dsNC;
        }



        /// <summary>
        /// cau 1
        /// </summary>
        public CXuLyNhanCong()
        {
            dsNC = new Dictionary<string, CNhancong>();
        }

        internal Dictionary<string, CNhancong> DsNC { get => dsNC; set => dsNC = value; }

        /// <summary>
        /// cau 2
        /// </summary>
        /// <returns></returns>
        public List<CNhancong> getDSNhanCong()
        {
            return dsNC.Values.ToList();
        }

        public bool sua(CNhancong a)
        {
            CNhancong b = tim(a.Msnv);

            if(b == null)
            {
                return false;
            }

            b.Tennv = a.Tennv;
            b.Loainhancong = a.Loainhancong;
            b.Songaycong = a.Songaycong;

            return true;
        }

        private CNhancong tim(string ma)
        {
            foreach (string s in dsNC.Keys)
            {
                if (s == ma)
                {
                    return dsNC[ma];
                }
            }

            return null;
        }
    }
}
