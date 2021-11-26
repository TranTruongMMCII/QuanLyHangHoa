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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHangHoaDataSet2.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyHangHoaDataSet2.NhaCungCap);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nhaCungCapBindingSource.AddNew();
            frmNhaCungCap_Load(sender, e);  
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Validate();
            nhaCungCapBindingSource.EndEdit();
            nhaCungCapTableAdapter.Update(quanLyHangHoaDataSet2.NhaCungCap);
            frmNhaCungCap_Load(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa chứ?", "Xóa nhà cung cấp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Validate();
                nhaCungCapBindingSource.EndEdit();
                nhaCungCapTableAdapter.Update(this.quanLyHangHoaDataSet2.NhaCungCap);
            }
            frmNhaCungCap_Load(sender, e);
        }
    }
}
