namespace BaiThi.Net
{
    partial class FormQLDeTai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvqldetai = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbgv = new System.Windows.Forms.ComboBox();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.maDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGiaoVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deTaiVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqldetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đề tài";
            // 
            // dgvqldetai
            // 
            this.dgvqldetai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqldetai.AutoGenerateColumns = false;
            this.dgvqldetai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvqldetai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvqldetai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqldetai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDeTaiDataGridViewTextBoxColumn,
            this.tenDeTaiDataGridViewTextBoxColumn,
            this.tenGiaoVienDataGridViewTextBoxColumn,
            this.tenKhoaDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.ngayCapNhatDataGridViewTextBoxColumn});
            this.dgvqldetai.DataSource = this.deTaiVMBindingSource;
            this.dgvqldetai.Location = new System.Drawing.Point(12, 164);
            this.dgvqldetai.MultiSelect = false;
            this.dgvqldetai.Name = "dgvqldetai";
            this.dgvqldetai.ReadOnly = true;
            this.dgvqldetai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvqldetai.RowTemplate.Height = 24;
            this.dgvqldetai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvqldetai.Size = new System.Drawing.Size(952, 339);
            this.dgvqldetai.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(733, 95);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(73, 31);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(812, 96);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(73, 31);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(891, 95);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(73, 31);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(13, 98);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(197, 27);
            this.txtsearch.TabIndex = 6;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(216, 98);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(72, 31);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Tìm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbgv
            // 
            this.cmbgv.FormattingEnabled = true;
            this.cmbgv.Location = new System.Drawing.Point(314, 99);
            this.cmbgv.Name = "cmbgv";
            this.cmbgv.Size = new System.Drawing.Size(186, 27);
            this.cmbgv.TabIndex = 8;
            this.cmbgv.SelectionChangeCommitted += new System.EventHandler(this.cmbgv_SelectionChangeCommitted);
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(517, 98);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(187, 27);
            this.cmbkhoa.TabIndex = 9;
            this.cmbkhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbkhoa_SelectionChangeCommitted);
            // 
            // maDeTaiDataGridViewTextBoxColumn
            // 
            this.maDeTaiDataGridViewTextBoxColumn.DataPropertyName = "MaDeTai";
            this.maDeTaiDataGridViewTextBoxColumn.HeaderText = "Mã đề";
            this.maDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDeTaiDataGridViewTextBoxColumn.Name = "maDeTaiDataGridViewTextBoxColumn";
            this.maDeTaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDeTaiDataGridViewTextBoxColumn
            // 
            this.tenDeTaiDataGridViewTextBoxColumn.DataPropertyName = "TenDeTai";
            this.tenDeTaiDataGridViewTextBoxColumn.FillWeight = 285F;
            this.tenDeTaiDataGridViewTextBoxColumn.HeaderText = "Tên đề tài";
            this.tenDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDeTaiDataGridViewTextBoxColumn.Name = "tenDeTaiDataGridViewTextBoxColumn";
            this.tenDeTaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGiaoVienDataGridViewTextBoxColumn
            // 
            this.tenGiaoVienDataGridViewTextBoxColumn.DataPropertyName = "TenGiaoVien";
            this.tenGiaoVienDataGridViewTextBoxColumn.HeaderText = "Tên giáo viên";
            this.tenGiaoVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGiaoVienDataGridViewTextBoxColumn.Name = "tenGiaoVienDataGridViewTextBoxColumn";
            this.tenGiaoVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhoaDataGridViewTextBoxColumn
            // 
            this.tenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.tenKhoaDataGridViewTextBoxColumn.HeaderText = "Khoa";
            this.tenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhoaDataGridViewTextBoxColumn.Name = "tenKhoaDataGridViewTextBoxColumn";
            this.tenKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayCapNhatDataGridViewTextBoxColumn
            // 
            this.ngayCapNhatDataGridViewTextBoxColumn.DataPropertyName = "NgayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            this.ngayCapNhatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapNhatDataGridViewTextBoxColumn.Name = "ngayCapNhatDataGridViewTextBoxColumn";
            this.ngayCapNhatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deTaiVMBindingSource
            // 
            this.deTaiVMBindingSource.DataSource = typeof(BaiThi.Net.VireModel.DeTaiVM);
            // 
            // deTaiBindingSource
            // 
            this.deTaiBindingSource.DataSource = typeof(BaiThi.Net.DeTai);
            // 
            // FormQLDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 515);
            this.Controls.Add(this.cmbkhoa);
            this.Controls.Add(this.cmbgv);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvqldetai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormQLDeTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đề tài";
            ((System.ComponentModel.ISupportInitialize)(this.dgvqldetai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvqldetai;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.BindingSource deTaiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deTaiVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGiaoVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cmbgv;
        private System.Windows.Forms.ComboBox cmbkhoa;
    }
}

