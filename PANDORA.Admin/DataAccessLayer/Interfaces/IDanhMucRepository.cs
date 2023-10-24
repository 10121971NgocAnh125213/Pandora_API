﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface IDanhMucRepository
    {
        DanhMucModel GetDatabyID(string id);
        bool Create(DanhMucModel model);
        bool Update(DanhMucModel model);
        bool Delete(DanhMucModel model);
        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string danh_muc_cha, string ten_danh_muc);
    }
}
