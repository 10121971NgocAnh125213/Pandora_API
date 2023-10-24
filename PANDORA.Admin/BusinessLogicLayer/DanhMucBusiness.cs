using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAccessLayer.Interfaces;

namespace BusinessLogicLayer
{
    public class DanhMucBusiness:IDanhMucBusiness
    {
        private IDanhMucRepository _res;
        public DanhMucBusiness(IDanhMucRepository res)
        {
            _res = res;
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
        public bool Delete(DanhMucModel model)
        {
            return _res.Delete(model);
        }
        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string danh_muc_cha, string ten_danh_muc)
        {
            return _res.Search(pageIndex, pageSize, out total, danh_muc_cha, ten_danh_muc);
        }
    }
}
