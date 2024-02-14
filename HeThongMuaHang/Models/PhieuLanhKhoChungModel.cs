using Dapper;
using System;
using System.Collections.Generic;

namespace HeThongMuaHang.Models
{
    public class PhieuLanhKhoChungModel : BindableBase
    {
        private bool _completed;
        private string _sites;
        private string _statusSign;

        public string Facility { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestNo { get; set; }
        public string DepartmentRequest { get; set; }
        public string ProductionLineRequest { get; set; }
        public string DepartmentUsed { get; set; }
        public string ProductionLineUsed { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool Completed { get => _completed; set => SetProperty(ref _completed, value); }
        public string Sites { get => _sites; set => SetProperty(ref _sites, value); }
        public string StatusSign { get => _statusSign; set => SetProperty(ref _statusSign, value); }
    }

    public class PhieuLanhKhoChungRepository : RepositoryBase
    {
        private const string TableName = "phieu_lanh_kho_chung";
        public List<PhieuLanhKhoChungModel> Data { get; } = new List<PhieuLanhKhoChungModel>();
        public PhieuLanhKhoChungRepository()
        {
        }

        public override void QueryAll(System.Data.SqlClient.SqlConnection sqlConnection)
        {
            Data.AddRange(sqlConnection.Query<PhieuLanhKhoChungModel>($"SELECT * FROM {TableName}"));
        }

        public override bool SaveAll(System.Data.SqlClient.SqlConnection sqlConnection)
        {
            var isUpdated = false;
            foreach (var data in Data)
            {
                if (!data.IsDirty) continue;
                var inDbData = sqlConnection.QueryFirstOrDefault<PhieuLanhKhoChungModel>($"SELECT * FROM  {TableName} " +
                    "WITH (UPDLOCK) WHERE RequestNo = @RequestNo "
                    , new { data.RequestNo });
                if (inDbData == null) continue;
                var rowsAffected = sqlConnection.Execute("UPDATE phieu_lanh_kho_chung " +
                    "SET Facility = @Facility, " +
                    "Completed = @Completed " +
                    "WHERE RequestNo = @RequestNo ",
                    new
                    {
                        data.Facility,
                        data.Completed,
                        data.RequestNo
                    });
                if (rowsAffected < 1) continue;
                isUpdated = true;
            }
            return isUpdated;
        }
    }
}
