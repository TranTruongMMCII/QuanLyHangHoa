namespace QuanLyHangHoa
{
    partial class frmLoiNhuan
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
            this.quanLyHangHoaDataSet = new QuanLyHangHoa.QuanLyHangHoaDataSet();
            this.loiNhuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loiNhuanTableAdapter = new QuanLyHangHoa.QuanLyHangHoaDataSetTableAdapters.LoiNhuanTableAdapter();
            this.maLoiNhuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriLoiNhuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThayDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiNhuanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lợi nhuận";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoiNhuanDataGridViewTextBoxColumn,
            this.giaTriLoiNhuanDataGridViewTextBoxColumn,
            this.ngayThayDoiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loiNhuanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(266, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 377);
            this.dataGridView1.TabIndex = 1;
            // 
            // quanLyHangHoaDataSet
            // 
            this.quanLyHangHoaDataSet.DataSetName = "QuanLyHangHoaDataSet";
            this.quanLyHangHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loiNhuanBindingSource
            // 
            this.loiNhuanBindingSource.DataMember = "LoiNhuan";
            this.loiNhuanBindingSource.DataSource = this.quanLyHangHoaDataSet;
            // 
            // loiNhuanTableAdapter
            // 
            this.loiNhuanTableAdapter.ClearBeforeFill = true;
            // 
            // maLoiNhuanDataGridViewTextBoxColumn
            // 
            this.maLoiNhuanDataGridViewTextBoxColumn.DataPropertyName = "MaLoiNhuan";
            this.maLoiNhuanDataGridViewTextBoxColumn.HeaderText = "Lần thay đổi";
            this.maLoiNhuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoiNhuanDataGridViewTextBoxColumn.Name = "maLoiNhuanDataGridViewTextBoxColumn";
            this.maLoiNhuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTriLoiNhuanDataGridViewTextBoxColumn
            // 
            this.giaTriLoiNhuanDataGridViewTextBoxColumn.DataPropertyName = "GiaTriLoiNhuan";
            this.giaTriLoiNhuanDataGridViewTextBoxColumn.HeaderText = "Giá trị lợi nhuận";
            this.giaTriLoiNhuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTriLoiNhuanDataGridViewTextBoxColumn.Name = "giaTriLoiNhuanDataGridViewTextBoxColumn";
            this.giaTriLoiNhuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayThayDoiDataGridViewTextBoxColumn
            // 
            this.ngayThayDoiDataGridViewTextBoxColumn.DataPropertyName = "NgayThayDoi";
            this.ngayThayDoiDataGridViewTextBoxColumn.HeaderText = "Ngày thay đổi";
            this.ngayThayDoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayThayDoiDataGridViewTextBoxColumn.Name = "ngayThayDoiDataGridViewTextBoxColumn";
            this.ngayThayDoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiNhuan.Location = new System.Drawing.Point(12, 162);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.Size = new System.Drawing.Size(248, 38);
            this.txtLoiNhuan.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(69, 261);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 38);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmLoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtLoiNhuan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmLoiNhuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoiNhuan";
            this.Load += new System.EventHandler(this.frmLoiNhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHangHoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiNhuanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyHangHoaDataSet quanLyHangHoaDataSet;
        private System.Windows.Forms.BindingSource loiNhuanBindingSource;
        private QuanLyHangHoaDataSetTableAdapters.LoiNhuanTableAdapter loiNhuanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoiNhuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriLoiNhuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThayDoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtLoiNhuan;
        private System.Windows.Forms.Button btnLuu;
    }
}