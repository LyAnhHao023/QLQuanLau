namespace QLQuanLau
{
    partial class frmQLBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBanAn));
            this.dgvQuanLyBanAn = new System.Windows.Forms.DataGridView();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCOKHACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemTenBan = new System.Windows.Forms.Button();
            this.btnTimKiemMaBan = new System.Windows.Forms.Button();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnQuayLaiTrangChu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyBanAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyBanAn
            // 
            this.dgvQuanLyBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTenBan,
            this.colTrangThai,
            this.colCOKHACH});
            this.dgvQuanLyBanAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuanLyBanAn.Location = new System.Drawing.Point(0, 166);
            this.dgvQuanLyBanAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanLyBanAn.MultiSelect = false;
            this.dgvQuanLyBanAn.Name = "dgvQuanLyBanAn";
            this.dgvQuanLyBanAn.ReadOnly = true;
            this.dgvQuanLyBanAn.RowHeadersWidth = 51;
            this.dgvQuanLyBanAn.RowTemplate.Height = 24;
            this.dgvQuanLyBanAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyBanAn.Size = new System.Drawing.Size(561, 211);
            this.dgvQuanLyBanAn.TabIndex = 10;
            this.dgvQuanLyBanAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyBanAn_CellClick);
            // 
            // colMaBan
            // 
            this.colMaBan.DataPropertyName = "MABAN";
            this.colMaBan.HeaderText = "Mã bàn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            this.colMaBan.ReadOnly = true;
            // 
            // colTenBan
            // 
            this.colTenBan.DataPropertyName = "TENBAN";
            this.colTenBan.HeaderText = "Tên bàn";
            this.colTenBan.MinimumWidth = 6;
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAITXT";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colCOKHACH
            // 
            this.colCOKHACH.DataPropertyName = "COKHACH";
            this.colCOKHACH.HeaderText = "COKHACH";
            this.colCOKHACH.MinimumWidth = 6;
            this.colCOKHACH.Name = "colCOKHACH";
            this.colCOKHACH.ReadOnly = true;
            this.colCOKHACH.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemTenBan);
            this.groupBox1.Controls.Add(this.btnTimKiemMaBan);
            this.groupBox1.Controls.Add(this.txtTenBan);
            this.groupBox1.Controls.Add(this.txtMaBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(371, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn ăn";
            // 
            // btnTimKiemTenBan
            // 
            this.btnTimKiemTenBan.BackgroundImage = global::QLQuanLau.Properties.Resources.search;
            this.btnTimKiemTenBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTenBan.Location = new System.Drawing.Point(305, 72);
            this.btnTimKiemTenBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemTenBan.Name = "btnTimKiemTenBan";
            this.btnTimKiemTenBan.Size = new System.Drawing.Size(33, 21);
            this.btnTimKiemTenBan.TabIndex = 25;
            this.btnTimKiemTenBan.UseVisualStyleBackColor = true;
            this.btnTimKiemTenBan.Click += new System.EventHandler(this.btnTimKiemTenBan_Click);
            // 
            // btnTimKiemMaBan
            // 
            this.btnTimKiemMaBan.BackgroundImage = global::QLQuanLau.Properties.Resources.search;
            this.btnTimKiemMaBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemMaBan.Location = new System.Drawing.Point(305, 33);
            this.btnTimKiemMaBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemMaBan.Name = "btnTimKiemMaBan";
            this.btnTimKiemMaBan.Size = new System.Drawing.Size(33, 21);
            this.btnTimKiemMaBan.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnTimKiemMaBan, "Tìm kiếm");
            this.btnTimKiemMaBan.UseVisualStyleBackColor = true;
            this.btnTimKiemMaBan.Click += new System.EventHandler(this.btnTimKiemMaBan_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(86, 72);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenBan.MaxLength = 50;
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(202, 22);
            this.txtTenBan.TabIndex = 2;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(86, 33);
            this.txtMaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBan.MaxLength = 5;
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(202, 22);
            this.txtMaBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bàn:";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(13, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 44);
            this.btnThem.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(84, 16);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 44);
            this.btnXoa.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.BackgroundImage")));
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Location = new System.Drawing.Point(84, 65);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 43);
            this.btnLamMoi.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(13, 65);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 43);
            this.btnSua.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnQuayLaiTrangChu
            // 
            this.btnQuayLaiTrangChu.BackgroundImage = global::QLQuanLau.Properties.Resources.exit;
            this.btnQuayLaiTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLaiTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLaiTrangChu.Location = new System.Drawing.Point(26, 12);
            this.btnQuayLaiTrangChu.Name = "btnQuayLaiTrangChu";
            this.btnQuayLaiTrangChu.Size = new System.Drawing.Size(68, 34);
            this.btnQuayLaiTrangChu.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnQuayLaiTrangChu, "Trang chủ");
            this.btnQuayLaiTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayLaiTrangChu.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(387, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(165, 111);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // frmQLBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(561, 377);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuayLaiTrangChu);
            this.Controls.Add(this.dgvQuanLyBanAn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ăn";
            this.Load += new System.EventHandler(this.frmQLBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyBanAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyBanAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuayLaiTrangChu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiemMaBan;
        private System.Windows.Forms.Button btnTimKiemTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCOKHACH;
    }
}