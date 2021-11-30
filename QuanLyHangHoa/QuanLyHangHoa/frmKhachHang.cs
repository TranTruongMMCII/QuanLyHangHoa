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
    public partial class frmKhachHang : Form
    {
        string action = "";
        int index = -1;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet4.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyHangHoaDataSet4.KhachHang);
            BindingSource bd = new BindingSource();
            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
            bd.DataSource = (from k in db.KhachHangs
                             where k.TrangThai == true
                             select new
                             {
                                 Chứng_minh_nhân_dân = k.CMND,
                                 Họ_tên = k.HoTen,
                                 Số_điện_thoại = k.SDT,
                                 Địa_chỉ = k.DiaChi,
                                 Điểm = k.DiemSo,
                                 Hạng = k.HangThe
                             }).ToList();
            dataGridView1.DataSource = bd;
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Hủy_Click(object sender, EventArgs e)
        {
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDiem.Text = "";
            txtHang.Text = "";

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            action = "";
            index = -1;

            frmKhachHang_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            action = "add";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            action = "delete";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            action = "edit";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "add":
                    if (txtCMND.Text == "" || txtHoTen.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền thông tin!");
                    }
                    else
                    {
                        try
                        {
                            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                            string cmnd = txtCMND.Text;
                            KhachHang khach = db.KhachHangs.Where(p => p.CMND == cmnd).FirstOrDefault();
                            if (khach == null)
                            {
                                khach = new KhachHang();
                                khach.CMND = txtCMND.Text;
                                khach.HoTen = txtHoTen.Text;
                                khach.SDT = txtSDT.Text;
                                khach.DiaChi = txtDiaChi.Text;
                                khach.DiemSo = 0;
                                khach.TrangThai = true;
                                khach.HangThe = "Chưa có hạng";
                                db.KhachHangs.Add(khach);
                                db.SaveChanges();
                                MessageBox.Show("Thêm thông tin khách hàng thành công.");
                            }
                            else
                            {
                                khach.HoTen = txtHoTen.Text;
                                khach.SDT = txtSDT.Text;
                                khach.DiaChi = txtDiaChi.Text;
                                khach.DiemSo = 0;
                                khach.TrangThai = true;
                                khach.HangThe = "Chưa có hạng";
                                db.SaveChanges();
                                MessageBox.Show("Thêm thông tin khách hàng thành công.");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể thêm thông tin khách hàng.");
                        }
                    }
                    break;
                case "edit":
                    if (index == -1)
                    {
                        MessageBox.Show("Chọn 1 dòng để sửa");
                    }
                    else
                    {
                        if (txtCMND.Text == "" || txtHoTen.Text == "" || txtDiem.Text == "")
                        {
                            MessageBox.Show("Vui lòng điền thông tin!");
                        }
                        else
                        {
                            try
                            {
                                string cmnd = dataGridView1.Rows[index].Cells[0].Value.ToString();
                                QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                                KhachHang khach = db.KhachHangs.Where(p=>p.CMND == cmnd).FirstOrDefault();
                                khach.CMND = txtCMND.Text;
                                khach.HoTen = txtHoTen.Text;
                                khach.SDT = txtSDT.Text;
                                khach.DiaChi = txtDiaChi.Text;
                                khach.DiemSo = Convert.ToInt32(txtDiem.Text);
                                if (khach.DiemSo < 3000)
                                {
                                    khach.HangThe = "Chưa có hạng";
                                }
                                else if(khach.DiemSo < 5000)
                                {
                                    khach.HangThe = "Hạng vàng";
                                }
                                else
                                {
                                    khach.HangThe = "Hạng bạch kim";
                                }
                                db.SaveChanges();
                                MessageBox.Show("Sửa thông tin khách hàng thành công.");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Không thể sửa thông tin khách hàng.");
                            }
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
                        try
                        {
                            string cmnd = dataGridView1.Rows[index].Cells[0].Value.ToString();
                            QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                            KhachHang khach = db.KhachHangs.Where(p => p.CMND == cmnd).FirstOrDefault();
                            khach.TrangThai = false;
                            db.SaveChanges();
                            MessageBox.Show("Xóa thông tin khách hàng thành công.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể xóa thông tin khách hàng.");
                        }
                    }
                    break;
            }
            Hủy_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            txtCMND.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDiem.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtHang.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.FillBy(this.quanLyHangHoaDataSet4.KhachHang);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.FillBy1(this.quanLyHangHoaDataSet4.KhachHang);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
