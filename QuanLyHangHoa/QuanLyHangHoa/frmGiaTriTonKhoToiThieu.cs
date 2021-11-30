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
    public partial class frmGiaTriTonKhoToiThieu : Form
    {
        public frmGiaTriTonKhoToiThieu()
        {
            InitializeComponent();
        }

        private void frmGiaTriTonKhoToiThieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet3.GiaTriTonKhoToiThieu' table. You can move, or remove it, as needed.
            this.giaTriTonKhoToiThieuTableAdapter.Fill(this.quanLyHangHoaDataSet3.GiaTriTonKhoToiThieu);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                double tonkho = Convert.ToInt32(txtTonKho.Text);
                try
                {
                    QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
                    GiaTriTonKhoToiThieu giaTriTonKhoToiThieu = new GiaTriTonKhoToiThieu();
                    giaTriTonKhoToiThieu.SoLuongTonKhoToiThieu = tonkho;
                    giaTriTonKhoToiThieu.NgayThayDoi = DateTime.Now;
                    db.GiaTriTonKhoToiThieux.Add(giaTriTonKhoToiThieu);
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật số lượng tồn kho tối thiểu thành công!");
                    frmGiaTriTonKhoToiThieu_Load(sender, e);
                    txtTonKho.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật số lượng tồn kho tối thiểu không thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng!");
            }
        }
    }
}
