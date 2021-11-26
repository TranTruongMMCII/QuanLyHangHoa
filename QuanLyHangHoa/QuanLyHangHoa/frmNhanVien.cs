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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyHangHoaDataSet2.NhanVien);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.AddNew();
            frmNhanVien_Load(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa nhân viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Validate();
                nhanVienBindingSource.EndEdit();
                nhanVienTableAdapter.Update(this.quanLyHangHoaDataSet2.NhanVien);
            }
            frmNhanVien_Load(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            nhanVienBindingSource.EndEdit();
            nhanVienTableAdapter.Update(quanLyHangHoaDataSet2.NhanVien);
            frmNhanVien_Load(sender, e);
        }
    }
}
