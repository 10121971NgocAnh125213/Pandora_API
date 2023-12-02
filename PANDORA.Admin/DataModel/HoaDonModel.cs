using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class HoaDonModel
    {
        public int MaHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string Sđt { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public List<ChiTietHoaDonModel> list_json_chitiethoadon { get; set; }
    }
    public class ChiTietHoaDonModel
    {
        public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }    
        public int MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }


    }
}
