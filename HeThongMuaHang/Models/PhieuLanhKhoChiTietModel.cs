using HeThongMuaHang.Models;
using System;

namespace HeThongMuaHang
{
    public class PhieuLanhKhoChiTiet : BindableBase
    {
        public string Facility { get; set; }
        public int RequestNo { get; set; }
        public int RequestLine { get; set; }
        public int ItemNo { get; set; }
        public string ItemName { get; set; }
        public int WorkerID { get; set; }
        public string WorkerName { get; set; }
        public int RequestQty { get; set; }
        public string UnitCode { get; set; }
        public string RequestRemark { get; set; }
        public int DisQty { get; set; }
        public DateTime DisDate { get; set; }
        public string DisUser { get; set; }
        public string DisRemark { get; set; }
    }
}
