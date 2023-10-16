﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface ISanPhamRepository
    {
        SanPhamModel GetDatabyID(string id);
        bool Create(SanPhamModel model);
        bool Update(SanPhamModel model);    
        bool Delete(SanPhamModel model);
    }
}