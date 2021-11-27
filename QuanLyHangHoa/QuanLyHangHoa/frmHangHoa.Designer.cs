namespace QuanLyHangHoa
{
    partial class frmHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.quanLyHangHoaDataSet2 = new QuanLyHangHoa.QuanLyHangHoaDataSet2();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSet2TableAdapters.MatHangTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSet2TableAdapters.NhaCungCapTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbQuiCach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.quiCachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiCachTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSet2TableAdapters.QuiCachTableAdapter();
            this.quanLyHangHoaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSet2TableAdapters.DonViTinhTableAdapter();
            this.danhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhMucTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSet2TableAdapters.DanhMucTableAdapter();
            this.danhMucBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.Hủy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiCachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hàng hóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 255);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(17, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(17, 56);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.Hủy);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(597, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbDanhMuc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbDonViTinh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbQuiCach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbNhaCungCap);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbMatHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá trị";
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.DataSource = this.matHangBindingSource;
            this.cmbMatHang.DisplayMember = "TenMatHang";
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(116, 18);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(156, 24);
            this.cmbMatHang.TabIndex = 0;
            this.cmbMatHang.ValueMember = "MaMatHang";
            // 
            // quanLyHangHoaDataSet2
            // 
            this.quanLyHangHoaDataSet2.DataSetName = "QuanLyHangHoaDataSet2";
            this.quanLyHangHoaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.quanLyHangHoaDataSet2;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.DataSource = this.nhaCungCapBindingSource;
            this.cmbNhaCungCap.DisplayMember = "TenNhaCungCap";
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(116, 88);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(156, 24);
            this.cmbNhaCungCap.TabIndex = 2;
            this.cmbNhaCungCap.ValueMember = "MaNhaCungCap";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyHangHoaDataSet2;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qui cách";
            // 
            // cmbQuiCach
            // 
            this.cmbQuiCach.DataSource = this.quiCachBindingSource;
            this.cmbQuiCach.DisplayMember = "TenQuiCach";
            this.cmbQuiCach.FormattingEnabled = true;
            this.cmbQuiCach.Location = new System.Drawing.Point(417, 18);
            this.cmbQuiCach.Name = "cmbQuiCach";
            this.cmbQuiCach.Size = new System.Drawing.Size(156, 24);
            this.cmbQuiCach.TabIndex = 4;
            this.cmbQuiCach.ValueMember = "MaQuiCach";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn vị tính";
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.DataSource = this.donViTinhBindingSource;
            this.cmbDonViTinh.DisplayMember = "TenDonViTinh";
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.Location = new System.Drawing.Point(417, 53);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(156, 24);
            this.cmbDonViTinh.TabIndex = 6;
            this.cmbDonViTinh.ValueMember = "MaDonViTinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Danh mục";
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.DataSource = this.danhMucBindingSource;
            this.cmbDanhMuc.DisplayMember = "TenDanhMuc";
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(417, 88);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(156, 24);
            this.cmbDanhMuc.TabIndex = 8;
            this.cmbDanhMuc.ValueMember = "MaDanhMuc";
            // 
            // quiCachBindingSource
            // 
            this.quiCachBindingSource.DataMember = "QuiCach";
            this.quiCachBindingSource.DataSource = this.quanLyHangHoaDataSet2;
            // 
            // quiCachTableAdapter
            // 
            this.quiCachTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyHangHoaDataSet2BindingSource
            // 
            this.quanLyHangHoaDataSet2BindingSource.DataSource = this.quanLyHangHoaDataSet2;
            this.quanLyHangHoaDataSet2BindingSource.Position = 0;
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "DonViTinh";
            this.donViTinhBindingSource.DataSource = this.quanLyHangHoaDataSet2BindingSource;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // danhMucBindingSource
            // 
            this.danhMucBindingSource.DataMember = "DanhMuc";
            this.danhMucBindingSource.DataSource = this.quanLyHangHoaDataSet2;
            // 
            // danhMucTableAdapter
            // 
            this.danhMucTableAdapter.ClearBeforeFill = true;
            // 
            // danhMucBindingSource1
            // 
            this.danhMucBindingSource1.DataMember = "DanhMuc";
            this.danhMucBindingSource1.DataSource = this.quanLyHangHoaDataSet2;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(98, 27);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 37);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Hủy
            // 
            this.Hủy.Location = new System.Drawing.Point(98, 80);
            this.Hủy.Name = "Hủy";
            this.Hủy.Size = new System.Drawing.Size(75, 37);
            this.Hủy.TabIndex = 5;
            this.Hủy.Text = "Hủy";
            this.Hủy.UseVisualStyleBackColor = true;
            this.Hủy.Click += new System.EventHandler(this.Hủy_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiCachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private QuanLyHangHoaDataSet2 quanLyHangHoaDataSet2;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private QuanLyHangHoaDataSet2TableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyHangHoaDataSet2TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbQuiCach;
        private System.Windows.Forms.BindingSource quiCachBindingSource;
        private QuanLyHangHoaDataSet2TableAdapters.QuiCachTableAdapter quiCachTableAdapter;
        private System.Windows.Forms.BindingSource quanLyHangHoaDataSet2BindingSource;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private QuanLyHangHoaDataSet2TableAdapters.DonViTinhTableAdapter donViTinhTableAdapter;
        private System.Windows.Forms.BindingSource danhMucBindingSource;
        private QuanLyHangHoaDataSet2TableAdapters.DanhMucTableAdapter danhMucTableAdapter;
        private System.Windows.Forms.BindingSource danhMucBindingSource1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button Hủy;
    }
}