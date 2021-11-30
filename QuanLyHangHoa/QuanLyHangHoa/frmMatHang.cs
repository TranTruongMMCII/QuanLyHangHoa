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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.quanLyHangHoaDataSet2.MatHang);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            matHangBindingSource.AddNew();
            frmMatHang_Load(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa mặt hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    matHangBindingSource.EndEdit();
                    matHangTableAdapter.Update(this.quanLyHangHoaDataSet2.MatHang);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                frmMatHang_Load(sender, e);
            }
            frmMatHang_Load(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                matHangBindingSource.EndEdit();
                matHangTableAdapter.Update(quanLyHangHoaDataSet2.MatHang);
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công!");
            }
            frmMatHang_Load(sender, e);
        }
    }
}
