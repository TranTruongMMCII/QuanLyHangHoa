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
    public partial class frmNhapHang : Form
    {
        class ThongTinHangHoa
        {
            private int mahanghoa;
            private string tenmathang;
            private string quicach;
            private string nhacungcap;
            private string donvitinh;
            private string danhmuc;

            public int Mahanghoa { get => mahanghoa; set => mahanghoa = value; }
            public string Tenmathang { get => tenmathang + "; " + nhacungcap + "; " + danhmuc + "; " + quicach + "; " + donvitinh; set => tenmathang = value; }
            public string Quicach { get => quicach; set => quicach = value; }
            public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
            public string Donvitinh { get => donvitinh; set => donvitinh = value; }
            public string Danhmuc { get => danhmuc; set => danhmuc = value; }

            public ThongTinHangHoa(int mahanghoa, string tenmathang, string quicach, string nhacungcap, string donvitinh, string danhmuc)
            {
                Mahanghoa = mahanghoa;
                Tenmathang = tenmathang;
                Quicach = quicach;
                Nhacungcap = nhacungcap;
                Donvitinh = donvitinh;
                Danhmuc = danhmuc;
            }
        }

        string action = "";
        int index;
        List<ThongTinHangHoa> hanghoa;
        int soluongcu;

        public frmNhapHang()
        {
            InitializeComponent();
            hanghoa = new List<ThongTinHangHoa>();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyHangHoaDataSet2.NhanVien);
            LoadData();
            loadComboboxHangHoa();
        }

        private void loadComboboxHangHoa()
        {
            BindingSource bd = new BindingSource();
            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
            var l = (from h in db.HangHoas
                     join m in db.MatHangs on h.MaMatHang equals m.MaMatHang
                     join q in db.QuiCaches on h.MaQuiCach equals q.MaQuiCach
                     join n in db.NhaCungCaps on h.MaNhaCungCap equals n.MaNhaCungCap
                     join d in db.DonViTinhs on h.MaDonViTinh equals d.MaDonViTinh
                     join e in db.DanhMucs on h.MaDanhMuc equals e.MaDanhMuc
                     where h.TrangThai == true
                     orderby h.MaHangHoa ascending
                     select new
                     {
                         Mã_hàng_hóa = h.MaHangHoa,
                         Tên_hàng = m.TenMatHang,
                         Nhà_cung_cấp = n.TenNhaCungCap,
                         Qui_cách = q.TenQuiCach,
                         Đơn_vị_tính = d.TenDonViTinh,
                         Danh_mục = e.TenDanhMuc
                     }).ToList();
            foreach (var i in l)
            {
                hanghoa.Add(new ThongTinHangHoa(i.Mã_hàng_hóa, i.Tên_hàng, i.Qui_cách, i.Nhà_cung_cấp, i.Đơn_vị_tính, i.Danh_mục));
            }
            cmbMatHang.DisplayMember = "Tenmathang";
            cmbMatHang.ValueMember = "Mahanghoa";
            cmbMatHang.DataSource = hanghoa;
            cmbMatHang.SelectedIndex = 0;
        }

        private void LoadData()
        {
            BindingSource bd = new BindingSource();
            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
            bd.DataSource = (from p in db.PhieuNhapHangs
                             join h in db.HangHoas on p.MaHangHoa equals h.MaHangHoa
                             join nv in db.NhanViens on p.MaNhanVien equals nv.MaNhanVien
                             join m in db.MatHangs on h.MaMatHang equals m.MaMatHang
                             join q in db.QuiCaches on h.MaQuiCach equals q.MaQuiCach
                             join n in db.NhaCungCaps on h.MaNhaCungCap equals n.MaNhaCungCap
                             join d in db.DonViTinhs on h.MaDonViTinh equals d.MaDonViTinh
                             join e in db.DanhMucs on h.MaDanhMuc equals e.MaDanhMuc
                             where h.TrangThai == true
                             orderby p.MaPhieuNhap ascending
                             select new
                             {
                                 Lần_nhập_hàng = p.MaPhieuNhap,
                                 Mã_hàng_hóa = h.MaHangHoa,
                                 Tên_hàng = m.TenMatHang,
                                 Nhà_cung_cấp = n.TenNhaCungCap,
                                 Qui_cách = q.TenQuiCach,
                                 Đơn_vị_tính = d.TenDonViTinh,
                                 Danh_mục = e.TenDanhMuc,
                                 Nhân_viên_nhập = nv.TenNhanVien,
                                 Số_lượng_nhập = p.SoLuong,
                                 Đơn_giá = p.GiaNhap
                             }).ToList();
            dataGridView1.DataSource = bd;
        }

        private void Hủy_Click(object sender, EventArgs e)
        {
            action = "";
            index = -1;
            btnThem.Enabled = true;
            //  btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            cmbMatHang.SelectedIndex = 0;
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            //  btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            action = "add";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            //  btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            action = "delete";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            // btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            action = "edit";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            cmbNhanVien.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            cmbMatHang.SelectedIndex = getIndexCombobox((int)dataGridView1.Rows[index].Cells[1].Value);
            soluongcu = (int)dataGridView1.Rows[index].Cells[8].Value;
            txtSoLuong.Text = Convert.ToString(soluongcu);
            txtDonGia.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "add":
                    if (txtDonGia.Text == "" || txtSoLuong.Text == "")
                    {
                        MessageBox.Show("Không được để trống dữ liệu!");
                    }
                    else
                    {
                        try
                        {
                            PhieuNhapHang p = new PhieuNhapHang();
                            p.MaPhieuNhap = 1;
                            p.MaHangHoa = (int?)cmbMatHang.SelectedValue;
                            p.MaNhanVien = (int?)cmbNhanVien.SelectedValue;
                            p.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                            p.GiaNhap = float.Parse(txtDonGia.Text);
                            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                            db.PhieuNhapHangs.Add(p);
                            db.SaveChanges();
                            HangTonKho hangTonKho = new HangTonKho();
                            hangTonKho = db.HangTonKhoes.Where(x => x.MaHangHoa == p.MaHangHoa).FirstOrDefault();
                            if (hangTonKho == null)
                            {
                                hangTonKho = new HangTonKho();
                                hangTonKho.MaHangHoa = (int)p.MaHangHoa;
                                hangTonKho.SoLuongCon = p.SoLuong;
                                db.HangTonKhoes.Add(hangTonKho);
                                db.SaveChanges();
                            }
                            else
                            {
                                hangTonKho.SoLuongCon += p.SoLuong;
                                db.SaveChanges();
                            }
                            MessageBox.Show("Thêm thành công.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Xảy ra lỗi khi thêm");
                        }
                    }
                    break;
                case "delete":
                    if (index == -1)
                    {
                        MessageBox.Show("Chọn 1 dòng để xóa!");
                    }
                    else
                    {

                    }
                    break;
                case "edit":
                    if (txtDonGia.Text == "" || txtSoLuong.Text == "" || index == -1)
                    {
                        MessageBox.Show("Không được để trống dữ liệu!");
                    }
                    else
                    {
                        try
                        {
                            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                            PhieuNhapHang p = db.PhieuNhapHangs.Where(x => x.MaPhieuNhap == Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value)).FirstOrDefault();
                            p.MaHangHoa = (int?)cmbMatHang.SelectedValue;
                            p.MaNhanVien = (int?)cmbNhanVien.SelectedValue;
                            p.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                            p.GiaNhap = float.Parse(txtDonGia.Text);
                            db.SaveChanges();
                            HangTonKho hangTonKho = new HangTonKho();
                            hangTonKho = db.HangTonKhoes.Where(x => x.MaHangHoa == p.MaHangHoa).FirstOrDefault();
                            hangTonKho.SoLuongCon += (p.SoLuong - soluongcu);
                            if (hangTonKho.SoLuongCon < 0)
                            {
                                hangTonKho.SoLuongCon = 0;
                            }
                            MessageBox.Show("Sửa thành công.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Xảy ra lỗi khi sửa");
                        }
                    }
                    break;
            }

            LoadData();
            Hủy_Click(sender, e);
        }

        private int getIndexCombobox(int index)
        {
            for (int i = 0; i < hanghoa.Count; ++i)
            {
                if (hanghoa[i].Mahanghoa == index)
                {
                    return i;
                }
            }

            return 0;// never reach
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbMatHang_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (ThongTinHangHoa s in ((ComboBox)sender).Items)
            {
                string a = s.Tenmathang;
                newWidth = (int)g.MeasureString(a, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        private void cmbNhanVien_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (DataRowView s in ((ComboBox)sender).Items)
            {
                string v = s.ToString();
                newWidth = (int)g.MeasureString(v, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        private void cmbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongTinHangHoa t = hanghoa[cmbMatHang.SelectedIndex];
            txtDanhMuc.Text = t.Danhmuc;
            txtNhaCungCap.Text = t.Nhacungcap;
            txtQuiCach.Text = t.Quicach;
            txtDonViTinh.Text = t.Donvitinh;
        }
    }
}
