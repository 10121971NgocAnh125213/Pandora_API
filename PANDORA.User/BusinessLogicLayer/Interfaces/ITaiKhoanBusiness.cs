using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ITaiKhoanBusiness
    {
        bool Create(TaiKhoanModel model);
        bool Update(TaiKhoanModel model);
        bool Delete(string MaTaiKhoan);
    }
}