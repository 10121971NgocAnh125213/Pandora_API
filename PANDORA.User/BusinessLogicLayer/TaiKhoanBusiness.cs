using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;

namespace BusinessLogicLayer
{
    public class TaiKhoanBusiness : ITaiKhoanBusiness
    {
        private ITaiKhoanRepository _res;
        public TaiKhoanBusiness(ITaiKhoanRepository res)
        {
            _res = res;
        }
        public TaiKhoanModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public bool Create(TaiKhoanModel model)
        {
            return _res.Create(model);
        }
        public bool Update(TaiKhoanModel model)
        {
            return _res.Update(model);
        }
        public bool Delete(string MaTaiKhoan)
        {
            return _res.Delete(MaTaiKhoan);
        }
    }
}
