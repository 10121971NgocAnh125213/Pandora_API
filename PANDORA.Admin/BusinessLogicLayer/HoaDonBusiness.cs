using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;

namespace BusinessLogicLayer
{
    public class HoaDonBusiness:IHoaDonBusiness
    {
        private IHoaDonRepository _res;
        public HoaDonBusiness(IHoaDonRepository res)
        {
            _res = res;
        }
        public bool Create(HoaDonModel model)
        {
            return _res.Create(model);
        }
        public bool Update(HoaDonModel model)
        {
            return _res.Update(model);
        }
        public bool Delete(HoaDonModel model)
        {
            return _res.Delete(model);
        }
        public List<ThongKeKhachModel> Search(int pageIndex, int pageSize, out long total, string ten_khach_hang, DateTime? fr_NgayTao, DateTime? to_NgayDuyet)
        {
            return _res.Search(pageIndex, pageSize, out total, ten_khach_hang, fr_NgayTao, to_NgayDuyet);
        }
    }
}