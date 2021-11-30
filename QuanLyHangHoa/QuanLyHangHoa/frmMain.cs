using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDanhMuc frmDanhMuc = new frmDanhMuc();
            frmDanhSachHangHoaSapHetHang frmDanhSachHangHoaSapHetHang = new frmDanhSachHangHoaSapHetHang();
            frmDonViTinh frmDonViTinh = new frmDonViTinh();
            frmGiaTriTonKhoToiThieu frmGiaTriTonKhoToiThieu = new frmGiaTriTonKhoToiThieu();
            frmHangHoa frmHangHoa = new frmHangHoa();
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmLoiNhuan frmLoiNhuan = new frmLoiNhuan();
            frmMatHang frmMatHang = new frmMatHang();
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhapHang frmNhapHang = new frmNhapHang();
            frmQuiCach frmQuiCach = new frmQuiCach();

            List<Form> list = new List<Form>();
            list.Add(frmGiaTriTonKhoToiThieu);
            list.Add(frmLoiNhuan);
            list.Add(frmDanhMuc);
            list.Add(frmQuiCach);
            list.Add(frmDonViTinh);
            list.Add(frmNhaCungCap);
            list.Add(frmMatHang);
            list.Add(frmHangHoa);
            list.Add(frmNhapHang);
            list.Add(frmDanhSachHangHoaSapHetHang);
            list.Add(frmKhachHang);
            list.Add(frmNhanVien);
            foreach (Form item in list)
            {
                TabPage tabPage = new TabPage { Text = item.Text };
                tabPage.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tabPage);
                item.TopLevel = false;
                item.Parent = tabPage;
                item.Show();
                item.Dock = DockStyle.Fill;
            }
        }
    }
}
