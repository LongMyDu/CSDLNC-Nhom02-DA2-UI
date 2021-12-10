using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaYeuThuong
{
    public class SanPham
    {
        public String MaSP { get; set; }
        public String TenSP { get; set; }
        public String GiaBan { get; set; }
        public String LoaiSP { get; set; }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                SanPham sp = (SanPham)obj;
                return this.MaSP == sp.MaSP;
            }
        }
        public override int GetHashCode()
        {
            return this.MaSP.GetHashCode();
        }
    }
}
