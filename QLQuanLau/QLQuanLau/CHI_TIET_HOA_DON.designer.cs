namespace QLQuanLau
{
    partial class frmChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHoaDon));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.col1MAHD_cthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMAKICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(224, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1MAHD_cthd,
            this.col2MAMON,
            this.col3TENMON,
            this.cKICHTHUOC,
            this.col4SOLUONG,
            this.col5Gia,
            this.col6THANHTIEN,
            this.cMAKICHTHUOC});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(9, 80);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(638, 206);
            this.dgvChiTietHoaDon.TabIndex = 19;
            // 
            // col1MAHD_cthd
            // 
            this.col1MAHD_cthd.DataPropertyName = "MAHD";
            this.col1MAHD_cthd.HeaderText = "Mã hóa đơn";
            this.col1MAHD_cthd.MinimumWidth = 6;
            this.col1MAHD_cthd.Name = "col1MAHD_cthd";
            this.col1MAHD_cthd.ReadOnly = true;
            // 
            // col2MAMON
            // 
            this.col2MAMON.DataPropertyName = "MAMONAN";
            this.col2MAMON.HeaderText = "Mã món";
            this.col2MAMON.MinimumWidth = 6;
            this.col2MAMON.Name = "col2MAMON";
            this.col2MAMON.ReadOnly = true;
            // 
            // col3TENMON
            // 
            this.col3TENMON.DataPropertyName = "TENMON";
            this.col3TENMON.HeaderText = "Tên món";
            this.col3TENMON.MinimumWidth = 6;
            this.col3TENMON.Name = "col3TENMON";
            this.col3TENMON.ReadOnly = true;
            // 
            // cKICHTHUOC
            // 
            this.cKICHTHUOC.DataPropertyName = "TENKICHTHUOC";
            this.cKICHTHUOC.HeaderText = "Kích cỡ";
            this.cKICHTHUOC.MinimumWidth = 6;
            this.cKICHTHUOC.Name = "cKICHTHUOC";
            this.cKICHTHUOC.ReadOnly = true;
            // 
            // col4SOLUONG
            // 
            this.col4SOLUONG.DataPropertyName = "SOLUONG";
            this.col4SOLUONG.HeaderText = "Số lượng";
            this.col4SOLUONG.MinimumWidth = 6;
            this.col4SOLUONG.Name = "col4SOLUONG";
            this.col4SOLUONG.ReadOnly = true;
            // 
            // col5Gia
            // 
            this.col5Gia.DataPropertyName = "GIA";
            this.col5Gia.HeaderText = "Giá";
            this.col5Gia.MinimumWidth = 6;
            this.col5Gia.Name = "col5Gia";
            this.col5Gia.ReadOnly = true;
            // 
            // col6THANHTIEN
            // 
            this.col6THANHTIEN.DataPropertyName = "THANHTIEN";
            this.col6THANHTIEN.HeaderText = "Thành tiền";
            this.col6THANHTIEN.MinimumWidth = 6;
            this.col6THANHTIEN.Name = "col6THANHTIEN";
            this.col6THANHTIEN.ReadOnly = true;
            // 
            // cMAKICHTHUOC
            // 
            this.cMAKICHTHUOC.DataPropertyName = "KICHTHUOC";
            this.cMAKICHTHUOC.HeaderText = "MAKICHTHUOC";
            this.cMAKICHTHUOC.MinimumWidth = 6;
            this.cMAKICHTHUOC.Name = "cMAKICHTHUOC";
            this.cMAKICHTHUOC.ReadOnly = true;
            this.cMAKICHTHUOC.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Location = new System.Drawing.Point(10, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 34);
            this.btnThoat.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackgroundImage = global::QLQuanLau.Properties.Resources.print;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIn.Location = new System.Drawing.Point(652, 80);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(70, 206);
            this.btnIn.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnIn, "In");
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(727, 298);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1MAHD_cthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMAKICHTHUOC;
    }
}