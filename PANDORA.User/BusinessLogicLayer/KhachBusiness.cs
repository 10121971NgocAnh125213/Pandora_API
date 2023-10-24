using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;

namespace BusinessLogicLayer
{
    public class KhachBusiness:IKhachBusiness
    {
        private IKhachRepository _res;
        public KhachBusiness(IKhachRepository res)
        {
            _res = res;
        }
        
        public bool Update(KhachModel model)
        {
            return _res.Update(model);
        }
        
       
    }
}