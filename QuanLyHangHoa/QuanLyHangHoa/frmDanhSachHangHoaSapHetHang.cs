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
    public partial class frmDanhSachHangHoaSapHetHang : Form
    {
        public frmDanhSachHangHoaSapHetHang()
        {
            InitializeComponent();
        }

        private void frmDanhSachHangHoaSapHetHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            BindingSource bd = new BindingSource();
            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
            int toithieu = (int)(from g in db.GiaTriTonKhoToiThieux orderby g.MaGiaTriTonKho descending select g.SoLuongTonKhoToiThieu).FirstOrDefault();
            bd.DataSource = (from p in db.HangTonKhoes
                             join h in db.HangHoas on p.MaHangHoa equals h.MaHangHoa
                             join m in db.MatHangs on h.MaMatHang equals m.MaMatHang
                             join q in db.QuiCaches on h.MaQuiCach equals q.MaQuiCach
                             join n in db.NhaCungCaps on h.MaNhaCungCap equals n.MaNhaCungCap
                             join d in db.DonViTinhs on h.MaDonViTinh equals d.MaDonViTinh
                             join e in db.DanhMucs on h.MaDanhMuc equals e.MaDanhMuc
                             where h.TrangThai == true && p.SoLuongCon <= toithieu
                             orderby h.MaMatHang ascending
                             select new
                             {
                                 Mã_hàng_hóa = h.MaHangHoa,
                                 Tên_hàng = m.TenMatHang,
                                 Nhà_cung_cấp = n.TenNhaCungCap,
                                 Qui_cách = q.TenQuiCach,
                                 Đơn_vị_tính = d.TenDonViTinh,
                                 Danh_mục = e.TenDanhMuc,
                                 Số_lượng_còn = p.SoLuongCon,
                             }).ToList();
            dataGridView1.DataSource = bd;
        }
    }
}
