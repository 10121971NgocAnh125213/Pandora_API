using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface IKhachBusiness
    {
        List<KhachModel> GetAll();
        KhachModel GetDatabyID(string id);
        bool Create(KhachModel model);
        bool Update(KhachModel model);
        bool Delete(string MaKhachHang);
        List<KHMuaNhieuModel> TopKhachMuaHang();
        public List<KhachModel> Search(int pageIndex, int pageSize, out long total, string TenKhachHang, string DiaChi);
    }
}
