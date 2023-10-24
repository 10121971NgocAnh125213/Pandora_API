using DataModel;


namespace DataAccessLayer
{
    public class DanhMucRepository:IDanhMucRepository
    {
        private IDatabaseHelper _dbHelper;
        public DanhMucRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        
        
        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string DanhMucCha, string TenDanhMuc)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_danhmuc_search",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@danh_muc_cha", DanhMucCha,
                    "@ten_danh_muc", TenDanhMuc);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<DanhMucModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
