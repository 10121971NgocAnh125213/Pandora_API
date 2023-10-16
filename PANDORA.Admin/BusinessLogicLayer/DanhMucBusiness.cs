﻿using BusinessLogicLayer.Interfaces;
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
       
        public bool Create(DanhMucModel model)
        {
            return _res.Create(model);
        }
        public bool Update(DanhMucModel model)
        {
            return _res.Update(model);
        }

    }
}