using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
        public class SPBanChayModel
        {
            public int MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string MauSac { get; set; }
            public float Gia { get; set; }
            public string SoLuongDaBan{ get; set; }

        }

        public class KHMuaNhieuModel
        {
            public int MaKhachHang { get; set; }
            public string? TenKhachHang { get; set; }
            public string? Sđt { get; set; }
            public string? DiaChi { get; set; }
            public string? SoLuongSanPhamĐaMua { get; set; }
        }
}

