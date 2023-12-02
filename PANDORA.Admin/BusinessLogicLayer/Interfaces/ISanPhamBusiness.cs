﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ISanPhamBusiness
    {
        List<SanPhamModel> GetAll();
        SanPhamModel GetDatabyID(string id);
        List<SPBanChayModel> GetbySpHot();
        bool Create (SanPhamModelAL model);    
        bool Update (SanPhamModel model);
        bool Delete (string MaSanPham);
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string TenSanPham, string Gia);
    }
}
