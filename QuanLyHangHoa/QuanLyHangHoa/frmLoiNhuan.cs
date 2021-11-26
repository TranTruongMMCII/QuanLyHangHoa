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
    public partial class frmLoiNhuan : Form
    {
        public frmLoiNhuan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoiNhuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet.LoiNhuan' table. You can move, or remove it, as needed.
            this.loiNhuanTableAdapter.Fill(this.quanLyHangHoaDataSet.LoiNhuan);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtLoiNhuan.Text.Equals(""))
            {
                try
                {
                   double loinhuan = Convert.ToDouble(txtLoiNhuan.Text);
                    try
                    {
                        QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                        LoiNhuan loiNhuan = new LoiNhuan();
                        loiNhuan.GiaTriLoiNhuan = loinhuan;
                        loiNhuan.NgayThayDoi = DateTime.Now;
                        db.LoiNhuans.Add(loiNhuan);
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật lợi nhuận thành công!");
                        frmLoiNhuan_Load(sender, e);
                        txtLoiNhuan.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cập nhật lợi nhuận không thành công!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu nhập vào không đúng!");
                }

            }
        }
    }
}
