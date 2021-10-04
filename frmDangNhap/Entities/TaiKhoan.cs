using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmDangNhap.Entities
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public static List<TaiKhoan> GetList()
        {
            var ls = new List<TaiKhoan>();
            ls.Add(new TaiKhoan()
            {
                TenDangNhap = "ndungithue",
                MatKhau = "Abc@123"
            });
            return ls;
        }

        public static TaiKhoan Get(string tendn, string mk)
        {
            var dbTaiKhoan = GetList();
            var taikhoan = dbTaiKhoan.Where(s => s.TenDangNhap == tendn && s.MatKhau == mk).FirstOrDefault();
            return taikhoan;

        }
    }
}
