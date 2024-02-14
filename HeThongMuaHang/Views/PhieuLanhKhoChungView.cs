using HeThongMuaHang.Models;
using HeThongMuaHang.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HeThongMuaHang.Views
{
    public partial class PhieuLanhKhoChungView : Form
    {
        public PhieuLanhKhoChungViewModel ViewModel { get; } = new PhieuLanhKhoChungViewModel(SqlConnectionFactory.Instance, new PhieuLanhKhoChungRepository());
        public List<PhieuLanhKhoChungModel> Model => ViewModel.Repository.Data;
        public PhieuLanhKhoChungView()
        {
            InitializeComponent();
            gridControl1.DataSource = new BindingList<PhieuLanhKhoChungModel>(Model);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ViewModel.SaveAll();
        }
    }
}
