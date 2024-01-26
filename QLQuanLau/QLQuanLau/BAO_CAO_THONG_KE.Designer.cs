namespace QLQuanLau
{
    partial class frmBaoCaoVaThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoVaThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.radHoaDon = new System.Windows.Forms.RadioButton();
            this.radSanPham = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuayLaiTrangChu = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radNhanVien = new System.Windows.Forms.RadioButton();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "CHỌN BÁO CÁO HOẶC THỐNG KÊ";
            // 
            // radHoaDon
            // 
            this.radHoaDon.AutoSize = true;
            this.radHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHoaDon.Location = new System.Drawing.Point(13, 204);
            this.radHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.radHoaDon.Name = "radHoaDon";
            this.radHoaDon.Size = new System.Drawing.Size(77, 20);
            this.radHoaDon.TabIndex = 2;
            this.radHoaDon.TabStop = true;
            this.radHoaDon.Text = "Hóa đơn";
            this.radHoaDon.UseVisualStyleBackColor = true;
            // 
            // radSanPham
            // 
            this.radSanPham.AutoSize = true;
            this.radSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSanPham.Location = new System.Drawing.Point(11, 105);
            this.radSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.radSanPham.Name = "radSanPham";
            this.radSanPham.Size = new System.Drawing.Size(86, 20);
            this.radSanPham.TabIndex = 1;
            this.radSanPham.TabStop = true;
            this.radSanPham.Text = "Sản phẩm";
            this.radSanPham.UseVisualStyleBackColor = true;
            // 
            // btnQuayLaiTrangChu
            // 
            this.btnQuayLaiTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuayLaiTrangChu.BackgroundImage")));
            this.btnQuayLaiTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLaiTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLaiTrangChu.Location = new System.Drawing.Point(15, 11);
            this.btnQuayLaiTrangChu.Name = "btnQuayLaiTrangChu";
            this.btnQuayLaiTrangChu.Size = new System.Drawing.Size(68, 34);
            this.btnQuayLaiTrangChu.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnQuayLaiTrangChu, "Trang chủ");
            this.btnQuayLaiTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayLaiTrangChu.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBaoCao.BackgroundImage = global::QLQuanLau.Properties.Resources.BaoCao1;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(262, 171);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(96, 105);
            this.btnBaoCao.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBaoCao, "Xem");
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(107, 257);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(151, 21);
            this.dtpDenNgay.TabIndex = 8;
            this.dtpDenNgay.Value = new System.DateTime(2023, 5, 28, 23, 59, 0, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(107, 224);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(151, 21);
            this.dtpTuNgay.TabIndex = 8;
            this.dtpTuNgay.Value = new System.DateTime(2023, 5, 28, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radNhanVien
            // 
            this.radNhanVien.AutoSize = true;
            this.radNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhanVien.Location = new System.Drawing.Point(13, 152);
            this.radNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(85, 20);
            this.radNhanVien.TabIndex = 1;
            this.radNhanVien.TabStop = true;
            this.radNhanVien.Text = "Nhân viên";
            this.radNhanVien.UseVisualStyleBackColor = true;
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Items.AddRange(new object[] {
            "Tất cả sản phẩm",
            "Sản phẩm còn kinh doanh"});
            this.cbbSanPham.Location = new System.Drawing.Point(57, 128);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(151, 21);
            this.cbbSanPham.TabIndex = 10;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Items.AddRange(new object[] {
            "Tất cả nhân viên",
            "Nhân viên còn làm việc"});
            this.cbbNhanVien.Location = new System.Drawing.Point(57, 176);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(151, 21);
            this.cbbNhanVien.TabIndex = 10;
            // 
            // frmBaoCaoVaThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(366, 285);
            this.ControlBox = false;
            this.Controls.Add(this.cbbNhanVien);
            this.Controls.Add(this.cbbSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.btnQuayLaiTrangChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radHoaDon);
            this.Controls.Add(this.radNhanVien);
            this.Controls.Add(this.radSanPham);
            this.Controls.Add(this.btnBaoCao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoVaThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo và thống kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radHoaDon;
        private System.Windows.Forms.RadioButton radSanPham;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnQuayLaiTrangChu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radNhanVien;
        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.ComboBox cbbNhanVien;
    }
}