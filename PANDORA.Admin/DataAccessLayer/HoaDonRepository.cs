using DataModel;

namespace DataAccessLayer
{
    public class HoaDonRepository:IHoaDonRepository
    {
        private IDatabaseHelper _dbHelper;
        public HoaDonRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public bool Create(HoaDonModel model)
        {
            string msgError = "";
            try
            {
                var xxx = model.list_json_chitiethoadon != null ? MessageConvert.SerializeObject(model.list_json_chitiethoadon) : null;
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_create",
                "@TenKH", model.TenKhachHang,
                "@Sđt", model.Sđt,
                "@Diachi", model.DiaChiGiaoHang,
                "@TrangThai", model.TrangThai,
                "@NgayTao", model.NgayTao,
                "@list_json_chitiethoadon", model.list_json_chitiethoadon != null ? MessageConvert.SerializeObject(model.list_json_chitiethoadon) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                    if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(HoaDonModel model)
        {
            string msgError = "";
            try
            {
                var xxx = model.list_json_chitiethoadon != null ? MessageConvert.SerializeObject(model.list_json_chitiethoadon) : null;
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_create",
                "@TenKH", model.TenKhachHang,
                "@Sđt", model.Sđt,
                "@Diachi", model.DiaChiGiaoHang,
                "@TrangThai", model.TrangThai,
                "@NgayTao", model.NgayTao,
                "@list_json_chitiethoadon", model.list_json_chitiethoadon != null ? MessageConvert.SerializeObject(model.list_json_chitiethoadon) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                    if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                    {
                        throw new Exception(Convert.ToString(result) + msgError);
                    }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(HoaDonModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_delete",
                "@MaHoaDon", model.MaHoaDon);
                ;
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ThongKeKhachModel> Search(int pageIndex, int pageSize, out long total, string ten_khach_hang, DateTime? fr_NgayTao, DateTime? to_NgayDuyet)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_thongke_hoadon",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@ten_khach_hang", ten_khach_hang,
                    "@fr_NgayTao", fr_NgayTao,
                    "@to_NgayDuyet", to_NgayDuyet
                     );
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<ThongKeKhachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
