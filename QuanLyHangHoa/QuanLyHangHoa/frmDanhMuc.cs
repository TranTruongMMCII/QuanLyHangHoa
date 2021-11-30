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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet1.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.quanLyHangHoaDataSet1.DanhMuc);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa danh mục", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    danhMucBindingSource.EndEdit();
                    danhMucTableAdapter.Update(this.quanLyHangHoaDataSet1.DanhMuc);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            frmDanhMuc_Load(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            danhMucBindingSource.AddNew();
            frmDanhMuc_Load(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                danhMucBindingSource.EndEdit();
                danhMucTableAdapter.Update(this.quanLyHangHoaDataSet1.DanhMuc);
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công!");
            }
            frmDanhMuc_Load(sender, e);
        }
    }
}
