namespace QLQuanLau
{
    partial class frmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            this.dgvDSNSS = new System.Windows.Forms.DataGridView();
            this.cMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTENCHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemMoiMaNV = new System.Windows.Forms.Button();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.btnTimKiemHoTenNV = new System.Windows.Forms.Button();
            this.btnTimKiemMaNV = new System.Windows.Forms.Button();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtCMNDNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuayLaiTrangChu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNSS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSNSS
            // 
            this.dgvDSNSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSNSS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNSS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNV,
            this.cHOTEN,
            this.cNGAYSINH,
            this.cCMND,
            this.cTENCHUCVU,
            this.CHUCVU});
            this.dgvDSNSS.Location = new System.Drawing.Point(0, 290);
            this.dgvDSNSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSNSS.MultiSelect = false;
            this.dgvDSNSS.Name = "dgvDSNSS";
            this.dgvDSNSS.ReadOnly = true;
            this.dgvDSNSS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDSNSS.RowTemplate.Height = 24;
            this.dgvDSNSS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNSS.Size = new System.Drawing.Size(1000, 300);
            this.dgvDSNSS.TabIndex = 12;
            this.dgvDSNSS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNSS_CellClick);
            // 
            // cMaNV
            // 
            this.cMaNV.DataPropertyName = "MANV";
            this.cMaNV.HeaderText = "Mã NV";
            this.cMaNV.MinimumWidth = 6;
            this.cMaNV.Name = "cMaNV";
            this.cMaNV.ReadOnly = true;
            // 
            // cHOTEN
            // 
            this.cHOTEN.DataPropertyName = "HOTEN";
            this.cHOTEN.HeaderText = "Họ Tên";
            this.cHOTEN.MinimumWidth = 6;
            this.cHOTEN.Name = "cHOTEN";
            this.cHOTEN.ReadOnly = true;
            // 
            // cNGAYSINH
            // 
            this.cNGAYSINH.DataPropertyName = "NGAYSINH";
            this.cNGAYSINH.HeaderText = "Ngày sinh";
            this.cNGAYSINH.MinimumWidth = 6;
            this.cNGAYSINH.Name = "cNGAYSINH";
            this.cNGAYSINH.ReadOnly = true;
            // 
            // cCMND
            // 
            this.cCMND.DataPropertyName = "CMND";
            this.cCMND.HeaderText = "CMND";
            this.cCMND.MinimumWidth = 6;
            this.cCMND.Name = "cCMND";
            this.cCMND.ReadOnly = true;
            this.cCMND.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cTENCHUCVU
            // 
            this.cTENCHUCVU.DataPropertyName = "TENCHUCVU";
            this.cTENCHUCVU.HeaderText = "Chức vụ";
            this.cTENCHUCVU.MinimumWidth = 6;
            this.cTENCHUCVU.Name = "cTENCHUCVU";
            this.cTENCHUCVU.ReadOnly = true;
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "CHUCVU";
            this.CHUCVU.MinimumWidth = 6;
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.ReadOnly = true;
            this.CHUCVU.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemMoiMaNV);
            this.groupBox2.Controls.Add(this.cbbChucVu);
            this.groupBox2.Controls.Add(this.btnTimKiemHoTenNV);
            this.groupBox2.Controls.Add(this.btnTimKiemMaNV);
            this.groupBox2.Controls.Add(this.dtpNgaySinhNV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.txtHoTenNV);
            this.groupBox2.Controls.Add(this.txtCMNDNV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(510, 222);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // btnThemMoiMaNV
            // 
            this.btnThemMoiMaNV.BackgroundImage = global::QLQuanLau.Properties.Resources.create_account;
            this.btnThemMoiMaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemMoiMaNV.Location = new System.Drawing.Point(393, 27);
            this.btnThemMoiMaNV.Name = "btnThemMoiMaNV";
            this.btnThemMoiMaNV.Size = new System.Drawing.Size(38, 30);
            this.btnThemMoiMaNV.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnThemMoiMaNV, "Tạo mã mới");
            this.btnThemMoiMaNV.UseVisualStyleBackColor = true;
            this.btnThemMoiMaNV.Click += new System.EventHandler(this.btnThemMoiMaNV_Click);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Boss"});
            this.cbbChucVu.Location = new System.Drawing.Point(111, 182);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(276, 28);
            this.cbbChucVu.TabIndex = 12;
            // 
            // btnTimKiemHoTenNV
            // 
            this.btnTimKiemHoTenNV.BackgroundImage = global::QLQuanLau.Properties.Resources.search;
            this.btnTimKiemHoTenNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemHoTenNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemHoTenNV.Location = new System.Drawing.Point(437, 64);
            this.btnTimKiemHoTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemHoTenNV.Name = "btnTimKiemHoTenNV";
            this.btnTimKiemHoTenNV.Size = new System.Drawing.Size(44, 30);
            this.btnTimKiemHoTenNV.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnTimKiemHoTenNV, "Tìm kiếm");
            this.btnTimKiemHoTenNV.UseVisualStyleBackColor = true;
            this.btnTimKiemHoTenNV.Click += new System.EventHandler(this.btnTimKiemHoTenNV_Click);
            // 
            // btnTimKiemMaNV
            // 
            this.btnTimKiemMaNV.BackgroundImage = global::QLQuanLau.Properties.Resources.search;
            this.btnTimKiemMaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemMaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemMaNV.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemMaNV.Location = new System.Drawing.Point(437, 27);
            this.btnTimKiemMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemMaNV.Name = "btnTimKiemMaNV";
            this.btnTimKiemMaNV.Size = new System.Drawing.Size(44, 30);
            this.btnTimKiemMaNV.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnTimKiemMaNV, "Tìm kiếm");
            this.btnTimKiemMaNV.UseVisualStyleBackColor = true;
            this.btnTimKiemMaNV.Click += new System.EventHandler(this.btnTimKiemMaNV_Click);
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.CustomFormat = "MM/dd/yyyy";
            this.dtpNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(111, 103);
            this.dtpNgaySinhNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(276, 26);
            this.dtpNgaySinhNV.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chức vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Họ tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(111, 28);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.MaxLength = 10;
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(276, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNV.Location = new System.Drawing.Point(111, 65);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenNV.MaxLength = 50;
            this.txtHoTenNV.Multiline = true;
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(276, 27);
            this.txtHoTenNV.TabIndex = 2;
            // 
            // txtCMNDNV
            // 
            this.txtCMNDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDNV.Location = new System.Drawing.Point(111, 144);
            this.txtCMNDNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMNDNV.MaxLength = 12;
            this.txtCMNDNV.Multiline = true;
            this.txtCMNDNV.Name = "txtCMNDNV";
            this.txtCMNDNV.Size = new System.Drawing.Size(276, 27);
            this.txtCMNDNV.TabIndex = 4;
            this.txtCMNDNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMNDNV_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QLQuanLau.Properties.Resources.add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(15, 38);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 64);
            this.btnThem.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QLQuanLau.Properties.Resources.edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(108, 38);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 62);
            this.btnSua.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QLQuanLau.Properties.Resources.circle_of_two_clockwise_arrows_rotation;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(108, 115);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(73, 64);
            this.btnLamMoi.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QLQuanLau.Properties.Resources.trash;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(15, 116);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 63);
            this.btnXoa.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnQuayLaiTrangChu
            // 
            this.btnQuayLaiTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuayLaiTrangChu.BackgroundImage")));
            this.btnQuayLaiTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLaiTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLaiTrangChu.Location = new System.Drawing.Point(35, 15);
            this.btnQuayLaiTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuayLaiTrangChu.Name = "btnQuayLaiTrangChu";
            this.btnQuayLaiTrangChu.Size = new System.Drawing.Size(91, 42);
            this.btnQuayLaiTrangChu.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnQuayLaiTrangChu, "Trang chủ");
            this.btnQuayLaiTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayLaiTrangChu.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(531, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuayLaiTrangChu);
            this.Controls.Add(this.dgvDSNSS);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNSS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNSS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemHoTenNV;
        private System.Windows.Forms.Button btnTimKiemMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtCMNDNV;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnQuayLaiTrangChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTENCHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Button btnThemMoiMaNV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}