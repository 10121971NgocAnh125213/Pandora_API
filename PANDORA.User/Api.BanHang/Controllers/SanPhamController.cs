﻿using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [Route("get-all")]
        [HttpGet]
        public List<SanPhamModel> GetAll()
        {
            return _sanPhamBusiness.GetAll();
        }

        [Route("get-by-id/{MaSanPham}")]
        [HttpGet]
        public SanPhamModel GetDatabyID(string MaSanPham)
        {
            return _sanPhamBusiness.GetDatabyID(MaSanPham);
        }

        [Route("get-BestSeller")]
        [HttpGet]
        public List<SPBanChayModel> GetbySpHot()
        {
            return _sanPhamBusiness.GetbySpHot();
        }

        [Route("get-by-name/{TenSanPham}")]
        [HttpPost]
        public SanPhamModel GetDatabyName(string TenSanPham)
        {
            return _sanPhamBusiness.GetDatabyName(TenSanPham);
        }

       

        [Route("Search-SanPham")]
        [HttpPost]
        public IActionResult Search([FromBody] Dictionary<string, object> formData)
        {
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                string TenSanPham = "";
                if (formData.Keys.Contains("ten_san_pham") && !string.IsNullOrEmpty(Convert.ToString(formData["ten_san_pham"]))) { TenSanPham = Convert.ToString(formData["ten_san_pham"]); }
                string Gia = "";
                if (formData.Keys.Contains("gia") && !string.IsNullOrEmpty(Convert.ToString(formData["gia"]))) { Gia = Convert.ToString(formData["gia"]); }
                long total = 0;
                var data = _sanPhamBusiness.Search(page, pageSize, out total, TenSanPham, Gia);
                return Ok(
                    new
                    {
                        TotalItems = total,
                        Data = data,
                        Page = page,
                        PageSize = pageSize
                    }
                    );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
