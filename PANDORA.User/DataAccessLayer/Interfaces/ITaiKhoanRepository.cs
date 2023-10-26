﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface ITaiKhoanRepository
    {
        TaiKhoanModel GetDatabyID(string id);
        bool Create(TaiKhoanModel model);
        bool Update(TaiKhoanModel model);
        bool Delete(string MaTaiKhoan);
    }
}
