namespace QuanLyHangHoa
{
    partial class frmGiaTriTonKhoToiThieu
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quanLyHangHoaDataSet3 = new QuanLyHangHoa.QuanLyHangHoaDataSet3();
            this.giaTriTonKhoToiThieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaTriTonKhoToiThieuTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSet3TableAdapters.GiaTriTonKhoToiThieuTableAdapter();
            this.maGiaTriTonKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThayDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaTriTonKhoToiThieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(69, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 38);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTonKho
            // 
            this.txtTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKho.Location = new System.Drawing.Point(12, 155);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(248, 38);
            this.txtTonKho.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiaTriTonKhoDataGridViewTextBoxColumn,
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn,
            this.ngayThayDoiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giaTriTonKhoToiThieuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(266, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 377);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giá trị tồn kho tối thiểu";
            // 
            // quanLyHangHoaDataSet3
            // 
            this.quanLyHangHoaDataSet3.DataSetName = "QuanLyHangHoaDataSet3";
            this.quanLyHangHoaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaTriTonKhoToiThieuBindingSource
            // 
            this.giaTriTonKhoToiThieuBindingSource.DataMember = "GiaTriTonKhoToiThieu";
            this.giaTriTonKhoToiThieuBindingSource.DataSource = this.quanLyHangHoaDataSet3;
            // 
            // giaTriTonKhoToiThieuTableAdapter
            // 
            this.giaTriTonKhoToiThieuTableAdapter.ClearBeforeFill = true;
            // 
            // maGiaTriTonKhoDataGridViewTextBoxColumn
            // 
            this.maGiaTriTonKhoDataGridViewTextBoxColumn.DataPropertyName = "MaGiaTriTonKho";
            this.maGiaTriTonKhoDataGridViewTextBoxColumn.HeaderText = "Lần thay đổi";
            this.maGiaTriTonKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maGiaTriTonKhoDataGridViewTextBoxColumn.Name = "maGiaTriTonKhoDataGridViewTextBoxColumn";
            this.maGiaTriTonKhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongTonKhoToiThieuDataGridViewTextBoxColumn
            // 
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTonKhoToiThieu";
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn kho tối thiểu";
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn.Name = "soLuongTonKhoToiThieuDataGridViewTextBoxColumn";
            this.soLuongTonKhoToiThieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayThayDoiDataGridViewTextBoxColumn
            // 
            this.ngayThayDoiDataGridViewTextBoxColumn.DataPropertyName = "NgayThayDoi";
            this.ngayThayDoiDataGridViewTextBoxColumn.HeaderText = "Ngày thay đổi";
            this.ngayThayDoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayThayDoiDataGridViewTextBoxColumn.Name = "ngayThayDoiDataGridViewTextBoxColumn";
            this.ngayThayDoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmGiaTriTonKhoToiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmGiaTriTonKhoToiThieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaTriTonKhoToiThieu";
            this.Load += new System.EventHandler(this.frmGiaTriTonKhoToiThieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaTriTonKhoToiThieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private QuanLyHangHoaDataSet3 quanLyHangHoaDataSet3;
        private System.Windows.Forms.BindingSource giaTriTonKhoToiThieuBindingSource;
        private QuanLyHangHoaDataSet3TableAdapters.GiaTriTonKhoToiThieuTableAdapter giaTriTonKhoToiThieuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiaTriTonKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonKhoToiThieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThayDoiDataGridViewTextBoxColumn;
    }
}