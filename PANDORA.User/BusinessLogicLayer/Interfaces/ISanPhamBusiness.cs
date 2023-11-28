using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ISanPhamBusiness
    {
        List<SanPhamModel> GetAll();
        SanPhamModel GetDatabyName(string name);
        SanPhamModel GetDatabyID(string id);
        List<SPBanChayModel> GetbySpHot();
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string TenSanPham, string Gia);
    }
}
