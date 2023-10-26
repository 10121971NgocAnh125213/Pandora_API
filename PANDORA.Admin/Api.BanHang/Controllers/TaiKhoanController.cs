using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Api.BanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private ITaiKhoanBusiness _taiKhoanBusiness;
        public TaiKhoanController(ITaiKhoanBusiness taiKhoanBusiness)
        {  
            _taiKhoanBusiness = taiKhoanBusiness;
        }

        [Route("get-by-id/{MaTaiKhoan}")]
        [HttpGet]
        public TaiKhoanModel GetDatabyID(string MaTaiKhoan)
        {
            return _taiKhoanBusiness.GetDatabyID(MaTaiKhoan);
        }

        [Route("create-TaiKhoan")]
        [HttpPost]
        public TaiKhoanModel CreateItem([FromBody] TaiKhoanModel model)
        {
            _taiKhoanBusiness.Create(model);
            return model;
        }

        [Route("update-TaiKhoan")]
        [HttpPost]
        public TaiKhoanModel UpdateItem([FromBody] TaiKhoanModel model)
        {
            _taiKhoanBusiness.Update(model);
            return model;
        }

        [Route("Delete-TaiKhoan")]
        [HttpDelete]
        public IActionResult DeleteItem(string MaTaiKhoan)
        {
            _taiKhoanBusiness.Delete(MaTaiKhoan);
            return Ok(new { message = "Xóa thành công!" });
        }
    }
}