﻿using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private ISanPhamBusiness _sanPhamBusiness;
        public SanPhamController(ISanPhamBusiness sanPhamBusiness)
        {
            _sanPhamBusiness = sanPhamBusiness;
        }

        [Route("get-by-id/{MaSanPham}")]
        [HttpGet]
        public SanPhamModel GetDatabyID(string MaSanPham)
        {
            return _sanPhamBusiness.GetDatabyID(MaSanPham);
        }
    }
}