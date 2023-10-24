using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachController : ControllerBase
    {
        private IKhachBusiness _khachBusiness;
        public KhachController(IKhachBusiness khachBusiness)
        {
            _khachBusiness = khachBusiness;
        }

        [Route("update-khach")]
        [HttpPut]
        public KhachModel UpdateItem([FromBody] KhachModel model)
        {
            _khachBusiness.Update(model);
            return model;
        }
    
    }
}
