using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface ISanPhamRepository
    {
        List<SanPhamModel> GetAll();
        SanPhamModel GetDatabyID(string id);
        SanPhamModel GetDatabyName(string name);
        List<SPBanChayModel> GetbySpHot();
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string ten_san_pham, string gia);
    }
}
