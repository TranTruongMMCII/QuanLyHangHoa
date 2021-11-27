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
    public partial class frmHangHoa : Form
    {
        string action = "";
        int index = -1;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "add";
        }

        private void loaData()
        {
            BindingSource bd = new BindingSource();
            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
            bd.DataSource = (from h in db.HangHoas
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
            dataGridView1.DataSource = bd;
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.quanLyHangHoaDataSet2.DanhMuc);
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.quanLyHangHoaDataSet2.DonViTinh);
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.QuiCach' table. You can move, or remove it, as needed.
            this.quiCachTableAdapter.Fill(this.quanLyHangHoaDataSet2.QuiCach);
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyHangHoaDataSet2.NhaCungCap);
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.quanLyHangHoaDataSet2.MatHang);
            loaData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Hủy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            cmbMatHang.SelectedIndex = 0;
            cmbNhaCungCap.SelectedIndex = 0;
            cmbQuiCach.SelectedIndex = 0;
            cmbDonViTinh.SelectedIndex = 0;
            action = "";
            index = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "delete";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            action = "edit";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "edit":
                    if (index == -1)
                    {
                        MessageBox.Show("Chọn 1 dòng để sửa");
                    }
                    else
                    {
                        try
                        {
                            int id = (int)dataGridView1.Rows[index].Cells[0].Value;
                            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                            HangHoa hangHoa = db.HangHoas.Find(id);
                            hangHoa.MaDanhMuc = Convert.ToInt32((cmbDanhMuc.SelectedValue).ToString());
                            hangHoa.MaNhaCungCap = Convert.ToInt32((cmbNhaCungCap.SelectedValue).ToString());
                            hangHoa.MaDonViTinh = Convert.ToInt32((cmbDonViTinh.SelectedValue).ToString());
                            hangHoa.MaQuiCach = Convert.ToInt32((cmbQuiCach.SelectedValue).ToString());
                            hangHoa.MaMatHang = Convert.ToInt32((cmbMatHang.SelectedValue).ToString());
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Xảy ra lỗi khi sửa");
                        }
                    }
                    break;
                case "delete":
                    if (index == -1)
                    {
                        MessageBox.Show("Chọn 1 dòng để xóa");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa mặt hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                int id = (int)dataGridView1.Rows[index].Cells[0].Value;
                                QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                                HangHoa hangHoa = db.HangHoas.Find(id);
                                hangHoa.TrangThai = false;
                                db.SaveChanges();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Xảy ra lỗi khi xóa");
                            }
                        }
                    }
                    break;
                case "add":
                    try
                    {
                        HangHoa hangHoa = new HangHoa();
                        hangHoa.MaHangHoa = 1;
                        hangHoa.MaDanhMuc = Convert.ToInt32((cmbDanhMuc.SelectedValue).ToString());
                        hangHoa.MaNhaCungCap = Convert.ToInt32((cmbNhaCungCap.SelectedValue).ToString());
                        hangHoa.MaDonViTinh = Convert.ToInt32((cmbDonViTinh.SelectedValue).ToString());
                        hangHoa.MaQuiCach = Convert.ToInt32((cmbQuiCach.SelectedValue).ToString());
                        hangHoa.MaMatHang = Convert.ToInt32((cmbMatHang.SelectedValue).ToString());
                        hangHoa.TrangThai = true;
                        QuanLyHangHoaEntities d = new QuanLyHangHoaEntities();
                        d.HangHoas.Add(hangHoa);
                        d.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xảy ra lỗi khi thêm");
                    }
                    break;
                default:
                    break;
            }

            loaData();
            Hủy_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
        }
    }
}
