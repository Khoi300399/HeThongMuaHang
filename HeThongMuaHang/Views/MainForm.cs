using System.Windows.Forms;

namespace HeThongMuaHang.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var frmPhieuLanhKhoChung = new Views.PhieuLanhKhoChungView();
            frmPhieuLanhKhoChung.MdiParent = this;
            frmPhieuLanhKhoChung.Show();

            //var frmPhieuLanhKhoChiTiet = new Views.PhieuLanhKhoChiTietView();
            //frmPhieuLanhKhoChiTiet.MdiParent = this;
            //frmPhieuLanhKhoChiTiet.Show();

        }

    }
}
