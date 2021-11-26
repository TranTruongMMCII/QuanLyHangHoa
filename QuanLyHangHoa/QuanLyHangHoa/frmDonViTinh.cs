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
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donViTinhDataSet.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.donViTinhDataSet.DonViTinh);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            donViTinhBindingSource.AddNew();
            frmDonViTinh_Load(sender, e);   
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa đơn vị tính", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Validate();
                donViTinhBindingSource.EndEdit();
                donViTinhTableAdapter.Update(this.donViTinhDataSet.DonViTinh);
            }
            frmDonViTinh_Load(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            donViTinhBindingSource.EndEdit();
            donViTinhTableAdapter.Update(this.donViTinhDataSet.DonViTinh);
            frmDonViTinh_Load(sender, e);
        }
    }
}
