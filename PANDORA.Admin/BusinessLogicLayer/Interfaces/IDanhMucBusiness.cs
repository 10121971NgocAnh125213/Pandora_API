using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface IDanhMucBusiness
    {
       
        bool Create(DanhMucModel model);
        bool Update(DanhMucModel model);
    }
}
