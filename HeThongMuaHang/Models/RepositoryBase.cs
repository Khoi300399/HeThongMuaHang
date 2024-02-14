using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongMuaHang.Models
{
    public abstract class RepositoryBase
    {
        public abstract void QueryAll(System.Data.SqlClient.SqlConnection sqlConnection);
        public abstract bool SaveAll(System.Data.SqlClient.SqlConnection sqlConnection);
    }
}
