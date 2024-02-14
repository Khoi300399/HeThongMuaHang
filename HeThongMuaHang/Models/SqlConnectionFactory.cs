using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongMuaHang.Models
{
    public class SqlConnectionFactory
    {
        private const string _connectionString = "Data Source=THANHKHOI\\SQLEXPRESS;Initial Catalog=he_thong_mua_hang;Integrated Security=True";
        public static SqlConnectionFactory Instance { get; } = new SqlConnectionFactory();
        private SqlConnectionFactory()
        {

        }

        public System.Data.SqlClient.SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(_connectionString);
        }
    }
}
