namespace QLQuanLau
{
    partial class frmQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoaDon));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.cMAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTENVLAPDON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radTimMAHD = new System.Windows.Forms.RadioButton();
            this.radTimNgayLap = new System.Windows.Forms.RadioButton();
            this.radTimMANVLAPDON = new System.Windows.Forms.RadioButton();
            this.radTimMABAN = new System.Windows.Forms.RadioButton();
            this.radTimTHANHTOAN = new System.Windows.Forms.RadioButton();
            this.radTimTatCa = new System.Windows.Forms.RadioButton();
            this.btnQuayLaiTrangChu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grbTraCuu = new System.Windows.Forms.GroupBox();
            this.cbbTimTRANGTHAI = new System.Windows.Forms.ComboBox();
            this.cbbTimMABAN = new System.Windows.Forms.ComboBox();
            this.dtpTimNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTimMANV = new System.Windows.Forms.TextBox();
            this.txtTimMAHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grbTraCuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMAHD,
            this.cNGAYLAP,
            this.cTENVLAPDON,
            this.cTENBAN,
            this.cTongTien,
            this.cThanhToan,
            this.cTT,
            this.cMANV,
            this.cMABAN});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 232);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(728, 208);
            this.dgvHoaDon.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvHoaDon, "Double click để hiển thi chi tiết");
            this.dgvHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellDoubleClick);
            // 
            // cMAHD
            // 
            this.cMAHD.DataPropertyName = "MAHD";
            this.cMAHD.HeaderText = "Mã HD";
            this.cMAHD.MinimumWidth = 6;
            this.cMAHD.Name = "cMAHD";
            this.cMAHD.ReadOnly = true;
            // 
            // cNGAYLAP
            // 
            this.cNGAYLAP.DataPropertyName = "NGAYLAP";
            this.cNGAYLAP.HeaderText = "Ngày lập";
            this.cNGAYLAP.MinimumWidth = 6;
            this.cNGAYLAP.Name = "cNGAYLAP";
            this.cNGAYLAP.ReadOnly = true;
            // 
            // cTENVLAPDON
            // 
            this.cTENVLAPDON.DataPropertyName = "TENNV";
            this.cTENVLAPDON.HeaderText = "Tên NV lập đơn";
            this.cTENVLAPDON.MinimumWidth = 6;
            this.cTENVLAPDON.Name = "cTENVLAPDON";
            this.cTENVLAPDON.ReadOnly = true;
            // 
            // cTENBAN
            // 
            this.cTENBAN.DataPropertyName = "TENBAN";
            this.cTENBAN.HeaderText = "Tên bàn";
            this.cTENBAN.MinimumWidth = 6;
            this.cTENBAN.Name = "cTENBAN";
            this.cTENBAN.ReadOnly = true;
            // 
            // cTongTien
            // 
            this.cTongTien.DataPropertyName = "TONGTIEN";
            this.cTongTien.HeaderText = "Tổng tiền";
            this.cTongTien.MinimumWidth = 6;
            this.cTongTien.Name = "cTongTien";
            this.cTongTien.ReadOnly = true;
            // 
            // cThanhToan
            // 
            this.cThanhToan.DataPropertyName = "TINHTRANG";
            this.cThanhToan.HeaderText = "Tình Trạng";
            this.cThanhToan.MinimumWidth = 6;
            this.cThanhToan.Name = "cThanhToan";
            this.cThanhToan.ReadOnly = true;
            // 
            // cTT
            // 
            this.cTT.DataPropertyName = "THANHTOAN";
            this.cTT.HeaderText = "THANHTOAN";
            this.cTT.MinimumWidth = 6;
            this.cTT.Name = "cTT";
            this.cTT.ReadOnly = true;
            this.cTT.Visible = false;
            // 
            // cMANV
            // 
            this.cMANV.DataPropertyName = "MANVLAPDON";
            this.cMANV.HeaderText = "MANV";
            this.cMANV.MinimumWidth = 6;
            this.cMANV.Name = "cMANV";
            this.cMANV.ReadOnly = true;
            this.cMANV.Visible = false;
            // 
            // cMABAN
            // 
            this.cMABAN.HeaderText = "TENBAN";
            this.cMABAN.MinimumWidth = 6;
            this.cMABAN.Name = "cMABAN";
            this.cMABAN.ReadOnly = true;
            this.cMABAN.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // radTimMAHD
            // 
            this.radTimMAHD.AutoSize = true;
            this.radTimMAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radTimMAHD.Location = new System.Drawing.Point(16, 58);
            this.radTimMAHD.Margin = new System.Windows.Forms.Padding(2);
            this.radTimMAHD.Name = "radTimMAHD";
            this.radTimMAHD.Size = new System.Drawing.Size(70, 20);
            this.radTimMAHD.TabIndex = 0;
            this.radTimMAHD.TabStop = true;
            this.radTimMAHD.Text = "Mã HD:";
            this.toolTip1.SetToolTip(this.radTimMAHD, "Lọc theo mã HD");
            this.radTimMAHD.UseVisualStyleBackColor = true;
            // 
            // radTimNgayLap
            // 
            this.radTimNgayLap.AutoSize = true;
            this.radTimNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radTimNgayLap.Location = new System.Drawing.Point(16, 94);
            this.radTimNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.radTimNgayLap.Name = "radTimNgayLap";
            this.radTimNgayLap.Size = new System.Drawing.Size(83, 20);
            this.radTimNgayLap.TabIndex = 0;
            this.radTimNgayLap.TabStop = true;
            this.radTimNgayLap.Text = "Ngày lập:";
            this.toolTip1.SetToolTip(this.radTimNgayLap, "Lọc theo ngày lập");
            this.radTimNgayLap.UseVisualStyleBackColor = true;
            // 
            // radTimMANVLAPDON
            // 
            this.radTimMANVLAPDON.AutoSize = true;
            this.radTimMANVLAPDON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radTimMANVLAPDON.Location = new System.Drawing.Point(313, 20);
            this.radTimMANVLAPDON.Margin = new System.Windows.Forms.Padding(2);
            this.radTimMANVLAPDON.Name = "radTimMANVLAPDON";
            this.radTimMANVLAPDON.Size = new System.Drawing.Size(69, 20);
            this.radTimMANVLAPDON.TabIndex = 0;
            this.radTimMANVLAPDON.TabStop = true;
            this.radTimMANVLAPDON.Text = "Mã NV:";
            this.toolTip1.SetToolTip(this.radTimMANVLAPDON, "Lọc theo Mã NV");
            this.radTimMANVLAPDON.UseVisualStyleBackColor = true;
            // 
            // radTimMABAN
            // 
            this.radTimMABAN.AutoSize = true;
            this.radTimMABAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radTimMABAN.Location = new System.Drawing.Point(313, 58);
            this.radTimMABAN.Margin = new System.Windows.Forms.Padding(2);
            this.radTimMABAN.Name = "radTimMABAN";
            this.radTimMABAN.Size = new System.Drawing.Size(73, 20);
            this.radTimMABAN.TabIndex = 0;
            this.radTimMABAN.TabStop = true;
            this.radTimMABAN.Text = "Mã bàn:";
            this.toolTip1.SetToolTip(this.radTimMABAN, "Lọc theo mã bàn");
            this.radTimMABAN.UseVisualStyleBackColor = true;
            // 
            // radTimTHANHTOAN
            // 
            this.radTimTHANHTOAN.AutoSize = true;
            this.radTimTHANHTOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radTimTHANHTOAN.Location = new System.Drawing.Point(313, 94);
            this.radTimTHANHTOAN.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTHANHTOAN.Name = "radTimTHANHTOAN";
            this.radTimTHANHTOAN.Size = new System.Drawing.Size(88, 20);
            this.radTimTHANHTOAN.TabIndex = 0;
            this.radTimTHANHTOAN.TabStop = true;
            this.radTimTHANHTOAN.Text = "Trạng thái:";
            this.toolTip1.SetToolTip(this.radTimTHANHTOAN, "lọc theo trạng thái");
            this.radTimTHANHTOAN.UseVisualStyleBackColor = true;
            // 
            // radTimTatCa
            // 
            this.radTimTatCa.AutoSize = true;
            this.radTimTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radTimTatCa.Location = new System.Drawing.Point(16, 20);
            this.radTimTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTatCa.Name = "radTimTatCa";
            this.radTimTatCa.Size = new System.Drawing.Size(63, 20);
            this.radTimTatCa.TabIndex = 0;
            this.radTimTatCa.TabStop = true;
            this.radTimTatCa.Text = "Tất cả";
            this.toolTip1.SetToolTip(this.radTimTatCa, "Xem tất cả");
            this.radTimTatCa.UseVisualStyleBackColor = true;
            // 
            // btnQuayLaiTrangChu
            // 
            this.btnQuayLaiTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuayLaiTrangChu.BackgroundImage")));
            this.btnQuayLaiTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLaiTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLaiTrangChu.Location = new System.Drawing.Point(9, 11);
            this.btnQuayLaiTrangChu.Name = "btnQuayLaiTrangChu";
            this.btnQuayLaiTrangChu.Size = new System.Drawing.Size(68, 34);
            this.btnQuayLaiTrangChu.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnQuayLaiTrangChu, "Trang chủ");
            this.btnQuayLaiTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayLaiTrangChu.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::QLQuanLau.Properties.Resources.search;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(628, 51);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 148);
            this.btnTimKiem.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Lọc hóa đơn");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grbTraCuu
            // 
            this.grbTraCuu.Controls.Add(this.cbbTimTRANGTHAI);
            this.grbTraCuu.Controls.Add(this.cbbTimMABAN);
            this.grbTraCuu.Controls.Add(this.dtpTimNgayLap);
            this.grbTraCuu.Controls.Add(this.txtTimMANV);
            this.grbTraCuu.Controls.Add(this.txtTimMAHD);
            this.grbTraCuu.Controls.Add(this.radTimMANVLAPDON);
            this.grbTraCuu.Controls.Add(this.radTimMABAN);
            this.grbTraCuu.Controls.Add(this.radTimTatCa);
            this.grbTraCuu.Controls.Add(this.radTimTHANHTOAN);
            this.grbTraCuu.Controls.Add(this.radTimNgayLap);
            this.grbTraCuu.Controls.Add(this.radTimMAHD);
            this.grbTraCuu.Location = new System.Drawing.Point(9, 51);
            this.grbTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.grbTraCuu.Name = "grbTraCuu";
            this.grbTraCuu.Padding = new System.Windows.Forms.Padding(2);
            this.grbTraCuu.Size = new System.Drawing.Size(614, 148);
            this.grbTraCuu.TabIndex = 17;
            this.grbTraCuu.TabStop = false;
            this.grbTraCuu.Text = "Tra cứu";
            // 
            // cbbTimTRANGTHAI
            // 
            this.cbbTimTRANGTHAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbTimTRANGTHAI.FormattingEnabled = true;
            this.cbbTimTRANGTHAI.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbTimTRANGTHAI.Location = new System.Drawing.Point(400, 93);
            this.cbbTimTRANGTHAI.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTimTRANGTHAI.Name = "cbbTimTRANGTHAI";
            this.cbbTimTRANGTHAI.Size = new System.Drawing.Size(193, 24);
            this.cbbTimTRANGTHAI.TabIndex = 3;
            // 
            // cbbTimMABAN
            // 
            this.cbbTimMABAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbTimMABAN.FormattingEnabled = true;
            this.cbbTimMABAN.Location = new System.Drawing.Point(400, 57);
            this.cbbTimMABAN.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTimMABAN.Name = "cbbTimMABAN";
            this.cbbTimMABAN.Size = new System.Drawing.Size(193, 24);
            this.cbbTimMABAN.TabIndex = 3;
            // 
            // dtpTimNgayLap
            // 
            this.dtpTimNgayLap.CustomFormat = "M/d/yyyy";
            this.dtpTimNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpTimNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimNgayLap.Location = new System.Drawing.Point(95, 92);
            this.dtpTimNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimNgayLap.Name = "dtpTimNgayLap";
            this.dtpTimNgayLap.Size = new System.Drawing.Size(193, 22);
            this.dtpTimNgayLap.TabIndex = 2;
            this.dtpTimNgayLap.Value = new System.DateTime(2023, 5, 24, 0, 0, 0, 0);
            // 
            // txtTimMANV
            // 
            this.txtTimMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTimMANV.Location = new System.Drawing.Point(400, 19);
            this.txtTimMANV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimMANV.MaxLength = 10;
            this.txtTimMANV.Name = "txtTimMANV";
            this.txtTimMANV.Size = new System.Drawing.Size(193, 22);
            this.txtTimMANV.TabIndex = 1;
            // 
            // txtTimMAHD
            // 
            this.txtTimMAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTimMAHD.Location = new System.Drawing.Point(95, 57);
            this.txtTimMAHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimMAHD.MaxLength = 10;
            this.txtTimMAHD.Name = "txtTimMAHD";
            this.txtTimMAHD.Size = new System.Drawing.Size(193, 22);
            this.txtTimMAHD.TabIndex = 1;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(728, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grbTraCuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayLaiTrangChu);
            this.Controls.Add(this.dgvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grbTraCuu.ResumeLayout(false);
            this.grbTraCuu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnQuayLaiTrangChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grbTraCuu;
        private System.Windows.Forms.TextBox txtTimMAHD;
        private System.Windows.Forms.RadioButton radTimMANVLAPDON;
        private System.Windows.Forms.RadioButton radTimMABAN;
        private System.Windows.Forms.RadioButton radTimNgayLap;
        private System.Windows.Forms.RadioButton radTimMAHD;
        private System.Windows.Forms.ComboBox cbbTimMABAN;
        private System.Windows.Forms.DateTimePicker dtpTimNgayLap;
        private System.Windows.Forms.TextBox txtTimMANV;
        private System.Windows.Forms.RadioButton radTimTatCa;
        private System.Windows.Forms.RadioButton radTimTHANHTOAN;
        private System.Windows.Forms.ComboBox cbbTimTRANGTHAI;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTENVLAPDON;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMABAN;
    }
}