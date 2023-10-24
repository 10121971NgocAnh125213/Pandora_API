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

        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string danh_muc_cha, string ten_danh_muc)
        {
            return _res.Search(pageIndex, pageSize, out total, danh_muc_cha, ten_danh_muc);
        }
    }
}
