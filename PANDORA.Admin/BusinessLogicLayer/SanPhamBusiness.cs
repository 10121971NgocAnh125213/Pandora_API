using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;

namespace BusinessLogicLayer
{
    public class SanPhamBusiness:ISanPhamBusiness
    {
        private ISanPhamRepository _res;
        public SanPhamBusiness (ISanPhamRepository res)
        {
            _res = res;
        }
        public List<SanPhamModel> GetAll()
        {
            return _res.GetAll();
        }
        public SanPhamModel GetDatabyName(string name)
        {
            return _res.GetDatabyID(name);
        }
        public List<SPBanChayModel> GetbySpHot()
        {
            return _res.GetbySpHot();
        }
        public SanPhamModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public bool Create(SanPhamModel model)
        {
            return _res.Create(model);
        }
        public bool Update(SanPhamModel model)
        {
            return _res.Update(model);
        }
        public bool Delete(string MaSanPham)
        {
            return _res.Delete(MaSanPham);
        }
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string ten_san_pham, string gia)
        {
            return _res.Search(pageIndex, pageSize, out total, ten_san_pham, gia);
        }
    }
}