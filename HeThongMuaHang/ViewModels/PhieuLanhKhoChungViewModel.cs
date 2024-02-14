using HeThongMuaHang.Models;

namespace HeThongMuaHang.ViewModels
{
    public class PhieuLanhKhoChungViewModel
    {
        public PhieuLanhKhoChungRepository Repository { get; set; }
        private SqlConnectionFactory _sqlConnectionFactory;

        public PhieuLanhKhoChungViewModel(SqlConnectionFactory sqlConnectionFactory, PhieuLanhKhoChungRepository repository)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
            Repository = repository;
            using (var connection = _sqlConnectionFactory.GetConnection())
            {
                Repository.QueryAll(connection);
            }
        }

        public void SaveAll()
        {
            using (var connection = _sqlConnectionFactory.GetConnection())
            {
                Repository.SaveAll(connection);
            }
        }
    }
}
