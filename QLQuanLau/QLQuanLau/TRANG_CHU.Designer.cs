namespace TRANG_CHU
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsQuanLyMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsQuanLyBanAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienDu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.MAMONAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvwDanhSachBan = new System.Windows.Forms.ListView();
            this.colTenBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListTraSuaLarge = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbMonAn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.ptbMonAn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sstThongTinNV = new System.Windows.Forms.StatusStrip();
            this.tssThongTinNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sstThongTinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTrangChu,
            this.mnsBaoCaoThongKe,
            this.mnsHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsTrangChu
            // 
            this.mnsTrangChu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsQuanLyMonAn,
            this.mtsQuanLyHoaDon,
            this.mtsQuanLyBanAn,
            this.mtsQuanLyNhanVien,
            this.mtsQuanLyTaiKhoan});
            this.mnsTrangChu.Name = "mnsTrangChu";
            this.mnsTrangChu.Size = new System.Drawing.Size(89, 20);
            this.mnsTrangChu.Text = "CHỨC NĂNG";
            // 
            // mtsQuanLyMonAn
            // 
            this.mtsQuanLyMonAn.Name = "mtsQuanLyMonAn";
            this.mtsQuanLyMonAn.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mtsQuanLyMonAn.Size = new System.Drawing.Size(208, 22);
            this.mtsQuanLyMonAn.Text = "QUẢN LÝ MÓN ĂN";
            this.mtsQuanLyMonAn.Click += new System.EventHandler(this.mtsQuanLyMonAn_Click);
            // 
            // mtsQuanLyHoaDon
            // 
            this.mtsQuanLyHoaDon.Name = "mtsQuanLyHoaDon";
            this.mtsQuanLyHoaDon.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mtsQuanLyHoaDon.Size = new System.Drawing.Size(208, 22);
            this.mtsQuanLyHoaDon.Text = "QUẢN LÝ HÓA ĐƠN";
            this.mtsQuanLyHoaDon.Click += new System.EventHandler(this.mtsQuanLyHoaDon_Click);
            // 
            // mtsQuanLyBanAn
            // 
            this.mtsQuanLyBanAn.Name = "mtsQuanLyBanAn";
            this.mtsQuanLyBanAn.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mtsQuanLyBanAn.Size = new System.Drawing.Size(208, 22);
            this.mtsQuanLyBanAn.Text = "QUẢN LÝ BÀN ĂN";
            this.mtsQuanLyBanAn.Click += new System.EventHandler(this.mtsQuanLyBanAn_Click);
            // 
            // mtsQuanLyNhanVien
            // 
            this.mtsQuanLyNhanVien.Name = "mtsQuanLyNhanVien";
            this.mtsQuanLyNhanVien.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mtsQuanLyNhanVien.Size = new System.Drawing.Size(208, 22);
            this.mtsQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.mtsQuanLyNhanVien.Click += new System.EventHandler(this.mtsQuanLyNhanVien_Click);
            // 
            // mtsQuanLyTaiKhoan
            // 
            this.mtsQuanLyTaiKhoan.Name = "mtsQuanLyTaiKhoan";
            this.mtsQuanLyTaiKhoan.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mtsQuanLyTaiKhoan.Size = new System.Drawing.Size(208, 22);
            this.mtsQuanLyTaiKhoan.Text = "QUẢN LÝ TÀI KHOẢN";
            this.mtsQuanLyTaiKhoan.Click += new System.EventHandler(this.mtsQuanLyTaiKhoan_Click);
            // 
            // mnsBaoCaoThongKe
            // 
            this.mnsBaoCaoThongKe.Name = "mnsBaoCaoThongKe";
            this.mnsBaoCaoThongKe.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnsBaoCaoThongKe.Size = new System.Drawing.Size(148, 20);
            this.mnsBaoCaoThongKe.Text = "BÁO CÁO VÀ THỐNG KÊ";
            this.mnsBaoCaoThongKe.Click += new System.EventHandler(this.mnsBaoCaoThongKe_Click);
            // 
            // mnsHeThong
            // 
            this.mnsHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsDangXuat,
            this.mtsThoat});
            this.mnsHeThong.Name = "mnsHeThong";
            this.mnsHeThong.Size = new System.Drawing.Size(78, 20);
            this.mnsHeThong.Text = "HỆ THỐNG";
            // 
            // mtsDangXuat
            // 
            this.mtsDangXuat.Name = "mtsDangXuat";
            this.mtsDangXuat.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mtsDangXuat.Size = new System.Drawing.Size(158, 22);
            this.mtsDangXuat.Text = "ĐĂNG XUẤT";
            this.mtsDangXuat.Click += new System.EventHandler(this.mtsDangXuat_Click);
            // 
            // mtsThoat
            // 
            this.mtsThoat.Name = "mtsThoat";
            this.mtsThoat.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mtsThoat.Size = new System.Drawing.Size(158, 22);
            this.mtsThoat.Text = "THOÁT";
            this.mtsThoat.Click += new System.EventHandler(this.mtsThoat_Click);
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Enabled = false;
            this.txtTienNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNhan.Location = new System.Drawing.Point(857, 376);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(195, 22);
            this.txtTienNhan.TabIndex = 6;
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            this.txtTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienNhan_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tiền nhận:";
            // 
            // txtTienDu
            // 
            this.txtTienDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDu.Location = new System.Drawing.Point(857, 336);
            this.txtTienDu.Name = "txtTienDu";
            this.txtTienDu.ReadOnly = true;
            this.txtTienDu.Size = new System.Drawing.Size(195, 22);
            this.txtTienDu.TabIndex = 9;
            this.txtTienDu.TabStop = false;
            this.txtTienDu.TextChanged += new System.EventHandler(this.txtTienDu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tiền dư:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(857, 293);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(195, 22);
            this.txtTongTien.TabIndex = 8;
            this.txtTongTien.TabStop = false;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(785, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên món:";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMONAN,
            this.MAHD,
            this.TENMON,
            this.SOLUONG,
            this.TENKICHTHUOC,
            this.KICHTHUOC,
            this.GIA,
            this.THANHTIEN});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(338, 461);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(726, 236);
            this.dgvChiTietHoaDon.TabIndex = 13;
            this.dgvChiTietHoaDon.TabStop = false;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // MAMONAN
            // 
            this.MAMONAN.DataPropertyName = "MAMONAN";
            this.MAMONAN.HeaderText = "Mã món";
            this.MAMONAN.MinimumWidth = 6;
            this.MAMONAN.Name = "MAMONAN";
            this.MAMONAN.ReadOnly = true;
            this.MAMONAN.Visible = false;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Visible = false;
            // 
            // TENMON
            // 
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên";
            this.TENMON.MinimumWidth = 6;
            this.TENMON.Name = "TENMON";
            this.TENMON.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // TENKICHTHUOC
            // 
            this.TENKICHTHUOC.HeaderText = "Kích thước";
            this.TENKICHTHUOC.Name = "TENKICHTHUOC";
            this.TENKICHTHUOC.ReadOnly = true;
            // 
            // KICHTHUOC
            // 
            this.KICHTHUOC.DataPropertyName = "KICHTHUOC";
            this.KICHTHUOC.HeaderText = "Kích thước";
            this.KICHTHUOC.Name = "KICHTHUOC";
            this.KICHTHUOC.ReadOnly = true;
            this.KICHTHUOC.Visible = false;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.MinimumWidth = 6;
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // lvwDanhSachBan
            // 
            this.lvwDanhSachBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwDanhSachBan.BackColor = System.Drawing.Color.SkyBlue;
            this.lvwDanhSachBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenBan,
            this.colMaBan,
            this.colTrangThai});
            this.lvwDanhSachBan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwDanhSachBan.HideSelection = false;
            this.lvwDanhSachBan.LabelWrap = false;
            this.lvwDanhSachBan.LargeImageList = this.imgListTraSuaLarge;
            this.lvwDanhSachBan.Location = new System.Drawing.Point(0, 24);
            this.lvwDanhSachBan.MultiSelect = false;
            this.lvwDanhSachBan.Name = "lvwDanhSachBan";
            this.lvwDanhSachBan.Size = new System.Drawing.Size(340, 673);
            this.lvwDanhSachBan.TabIndex = 11;
            this.lvwDanhSachBan.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwDanhSachBan_MouseClick);
            // 
            // colTenBan
            // 
            this.colTenBan.DisplayIndex = 1;
            // 
            // colMaBan
            // 
            this.colMaBan.DisplayIndex = 0;
            // 
            // imgListTraSuaLarge
            // 
            this.imgListTraSuaLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListTraSuaLarge.ImageSize = new System.Drawing.Size(125, 125);
            this.imgListTraSuaLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(555, 296);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(176, 22);
            this.nudSoLuong.TabIndex = 2;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImage = global::QLQuanLau.Properties.Resources.cart;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(977, 403);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 52);
            this.btnThanhToan.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnThanhToan, "Thanh toán");
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QLQuanLau.Properties.Resources.trash;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(620, 403);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 52);
            this.btnXoa.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QLQuanLau.Properties.Resources.edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(536, 403);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 52);
            this.btnSua.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackgroundImage = global::QLQuanLau.Properties.Resources.change;
            this.btnChuyenBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChuyenBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Location = new System.Drawing.Point(346, 403);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 52);
            this.btnChuyenBan.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnChuyenBan, "Chuyển bàn");
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QLQuanLau.Properties.Resources.circle_of_two_clockwise_arrows_rotation;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(701, 403);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 52);
            this.btnLamMoi.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QLQuanLau.Properties.Resources.add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(453, 403);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 52);
            this.btnThem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbMonAn
            // 
            this.cbbMonAn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMonAn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbMonAn.FormattingEnabled = true;
            this.cbbMonAn.Location = new System.Drawing.Point(555, 251);
            this.cbbMonAn.Name = "cbbMonAn";
            this.cbbMonAn.Size = new System.Drawing.Size(176, 21);
            this.cbbMonAn.TabIndex = 1;
            this.cbbMonAn.SelectedIndexChanged += new System.EventHandler(this.cbbMonAn_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(555, 336);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(176, 22);
            this.txtGia.TabIndex = 15;
            this.txtGia.TabStop = false;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(555, 375);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(176, 22);
            this.txtThanhTien.TabIndex = 15;
            this.txtThanhTien.TabStop = false;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // ptbMonAn
            // 
            this.ptbMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbMonAn.Location = new System.Drawing.Point(565, 73);
            this.ptbMonAn.Name = "ptbMonAn";
            this.ptbMonAn.Size = new System.Drawing.Size(130, 160);
            this.ptbMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMonAn.TabIndex = 13;
            this.ptbMonAn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(750, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(770, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 33);
            this.label8.TabIndex = 28;
            this.label8.Text = "Quán lẩu HTP Lỏd";
            // 
            // sstThongTinNV
            // 
            this.sstThongTinNV.Dock = System.Windows.Forms.DockStyle.None;
            this.sstThongTinNV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssThongTinNV,
            this.tssTimer});
            this.sstThongTinNV.Location = new System.Drawing.Point(340, 24);
            this.sstThongTinNV.Name = "sstThongTinNV";
            this.sstThongTinNV.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sstThongTinNV.Size = new System.Drawing.Size(17, 22);
            this.sstThongTinNV.TabIndex = 29;
            this.sstThongTinNV.Text = "statusStrip1";
            // 
            // tssThongTinNV
            // 
            this.tssThongTinNV.Name = "tssThongTinNV";
            this.tssThongTinNV.Size = new System.Drawing.Size(0, 17);
            // 
            // tssTimer
            // 
            this.tssTimer.Name = "tssTimer";
            this.tssTimer.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1064, 697);
            this.ControlBox = false;
            this.Controls.Add(this.sstThongTinNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbMonAn);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTienNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTienDu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbMonAn);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.lvwDanhSachBan);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý quán lẩu HTP Lỏd";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sstThongTinNV.ResumeLayout(false);
            this.sstThongTinNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mtsQuanLyHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mtsQuanLyBanAn;
        private System.Windows.Forms.ToolStripMenuItem mtsQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mtsQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsBaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnsHeThong;
        private System.Windows.Forms.ToolStripMenuItem mtsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mtsThoat;
        private System.Windows.Forms.ToolStripMenuItem mtsQuanLyMonAn;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienDu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbMonAn;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.ListView lvwDanhSachBan;
        private System.Windows.Forms.ColumnHeader colMaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbbMonAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ImageList imgListTraSuaLarge;
        private System.Windows.Forms.ColumnHeader colTenBan;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMONAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip sstThongTinNV;
        private System.Windows.Forms.ToolStripStatusLabel tssThongTinNV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tssTimer;
    }
}

