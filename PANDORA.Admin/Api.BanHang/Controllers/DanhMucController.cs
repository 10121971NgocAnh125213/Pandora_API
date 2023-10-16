using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : Controller
    {
        private IDanhMucBusiness _danhMucBusiness;
        public DanhMucController(IDanhMucBusiness danhMucBusiness)
        {
            _danhMucBusiness = danhMucBusiness;
        }

        

        [Route("create-DanhMuc")]
        [HttpPost]
        public DanhMucModel CreateItem([FromBody] DanhMucModel model)
        {
            _danhMucBusiness.Create(model);
            return model;
        }

        [Route("update-DanhMuc")]
        [HttpPost]
        public DanhMucModel UpdateItem([FromBody] DanhMucModel model)
        {
            _danhMucBusiness.Update(model);
            return model;
        }

    }
}
