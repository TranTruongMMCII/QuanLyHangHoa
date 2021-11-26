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
    public partial class frmQuiCach : Form
    {
        public frmQuiCach()
        {
            InitializeComponent();
        }

        private void frmQuiCach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet.QuiCach' table. You can move, or remove it, as needed.
            this.quiCachTableAdapter.Fill(this.quanLyHangHoaDataSet2.QuiCach);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            quiCachBindingSource.AddNew();
            frmQuiCach_Load(sender, e);
        }

        private void frmQuiCach_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.QuiCach' table. You can move, or remove it, as needed.
            this.quiCachTableAdapter.Fill(this.quanLyHangHoaDataSet2.QuiCach);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            quiCachBindingSource.AddNew();
            frmQuiCach_Load(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa qui cách", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Validate();
                quiCachBindingSource.EndEdit();
                quiCachTableAdapter.Update(this.quanLyHangHoaDataSet2.QuiCach);
            }
            frmQuiCach_Load(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            quiCachBindingSource.EndEdit();
            quiCachTableAdapter.Update(quanLyHangHoaDataSet2.QuiCach);
            frmQuiCach_Load(sender, e);
        }
    }
}
