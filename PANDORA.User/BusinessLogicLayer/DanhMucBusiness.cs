using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;

namespace BusinessLogicLayer
{
    public class DanhMucBusiness:IDanhMucBusiness
    {
        private IDanhMucRepository _res;
        public DanhMucBusiness(IDanhMucRepository res)
        {
            _res = res;
        }
        public List<DanhMucModel> GetAll()
        {
            return _res.GetAll();
        }
        public DanhMucModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public bool Create(DanhMucModel model)
        {
            return _res.Create(model);
        }
        public bool Update(DanhMucModel model)
        {
            return _res.Update(model);
        }
        public bool Delete(string MaDanhMuc)
        {
            return _res.Delete(MaDanhMuc);
        }
        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string danh_muc_cha, string ten_danh_muc)
        {
            return _res.Search(pageIndex, pageSize, out total, danh_muc_cha, ten_danh_muc);
        }
    }
}
