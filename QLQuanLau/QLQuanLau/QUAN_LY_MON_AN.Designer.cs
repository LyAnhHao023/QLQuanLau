namespace QLQuanLau
{
    partial class frmQLMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLMonAn));
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.MAMONAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIMONAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMonKem = new System.Windows.Forms.RadioButton();
            this.radMonLau = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radNho = new System.Windows.Forms.RadioButton();
            this.radBinhThuong = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMonAn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuayLaiTrangChu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimMaMonAn = new System.Windows.Forms.TextBox();
            this.txtTimTenMonAn = new System.Windows.Forms.TextBox();
            this.radMaMonAn = new System.Windows.Forms.RadioButton();
            this.radTenMonAn = new System.Windows.Forms.RadioButton();
            this.radTimMonLau = new System.Windows.Forms.RadioButton();
            this.radTimMonKem = new System.Windows.Forms.RadioButton();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMONAN,
            this.TENMON,
            this.KICHTHUOC,
            this.TENKICHTHUOC,
            this.GIA,
            this.SOLUONG,
            this.TRANGTHAI,
            this.TENTRANGTHAI,
            this.LOAIMONAN});
            this.dgvMonAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMonAn.Location = new System.Drawing.Point(0, 229);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(836, 260);
            this.dgvMonAn.TabIndex = 11;
            this.dgvMonAn.TabStop = false;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            this.dgvMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            this.dgvMonAn.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMonAn_CellMouseClick);
            // 
            // MAMONAN
            // 
            this.MAMONAN.DataPropertyName = "MAMONAN";
            this.MAMONAN.HeaderText = "Mã món ăn";
            this.MAMONAN.MinimumWidth = 6;
            this.MAMONAN.Name = "MAMONAN";
            this.MAMONAN.ReadOnly = true;
            // 
            // TENMON
            // 
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Tên món ăn";
            this.TENMON.MinimumWidth = 6;
            this.TENMON.Name = "TENMON";
            this.TENMON.ReadOnly = true;
            // 
            // KICHTHUOC
            // 
            this.KICHTHUOC.DataPropertyName = "KICHTHUOC";
            this.KICHTHUOC.HeaderText = "Kich thước";
            this.KICHTHUOC.MinimumWidth = 6;
            this.KICHTHUOC.Name = "KICHTHUOC";
            this.KICHTHUOC.ReadOnly = true;
            this.KICHTHUOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KICHTHUOC.Visible = false;
            // 
            // TENKICHTHUOC
            // 
            this.TENKICHTHUOC.DataPropertyName = "KICHTHUOCTXT";
            this.TENKICHTHUOC.HeaderText = "Kích thước";
            this.TENKICHTHUOC.Name = "TENKICHTHUOC";
            this.TENKICHTHUOC.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá";
            this.GIA.MinimumWidth = 6;
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            this.TRANGTHAI.Visible = false;
            // 
            // TENTRANGTHAI
            // 
            this.TENTRANGTHAI.DataPropertyName = "TRANGTHAITXT";
            this.TENTRANGTHAI.HeaderText = "Trạng thái";
            this.TENTRANGTHAI.Name = "TENTRANGTHAI";
            this.TENTRANGTHAI.ReadOnly = true;
            // 
            // LOAIMONAN
            // 
            this.LOAIMONAN.DataPropertyName = "LOAIMONAN";
            this.LOAIMONAN.HeaderText = "Loại món ăn";
            this.LOAIMONAN.Name = "LOAIMONAN";
            this.LOAIMONAN.ReadOnly = true;
            this.LOAIMONAN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LOAIMONAN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LOAIMONAN.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTaoMa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.nudSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radNho);
            this.groupBox1.Controls.Add(this.radBinhThuong);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaMonAn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ptbMonAn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMonKem);
            this.groupBox2.Controls.Add(this.radMonLau);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(134, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 48);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // radMonKem
            // 
            this.radMonKem.AutoSize = true;
            this.radMonKem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMonKem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMonKem.Location = new System.Drawing.Point(189, 16);
            this.radMonKem.Name = "radMonKem";
            this.radMonKem.Size = new System.Drawing.Size(80, 20);
            this.radMonKem.TabIndex = 2;
            this.radMonKem.Text = "Món kèm";
            this.radMonKem.UseVisualStyleBackColor = true;
            this.radMonKem.CheckedChanged += new System.EventHandler(this.radMonAn_CheckedChanged);
            // 
            // radMonLau
            // 
            this.radMonLau.AutoSize = true;
            this.radMonLau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMonLau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMonLau.Location = new System.Drawing.Point(89, 16);
            this.radMonLau.Name = "radMonLau";
            this.radMonLau.Size = new System.Drawing.Size(72, 20);
            this.radMonLau.TabIndex = 1;
            this.radMonLau.Text = "Món lẩu";
            this.radMonLau.UseVisualStyleBackColor = true;
            this.radMonLau.CheckedChanged += new System.EventHandler(this.radMonAn_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại món:";
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.BackgroundImage = global::QLQuanLau.Properties.Resources.create_account;
            this.btnTaoMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaoMa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMa.Location = new System.Drawing.Point(384, 19);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(39, 22);
            this.btnTaoMa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTaoMa, "Tạo mã");
            this.btnTaoMa.UseVisualStyleBackColor = true;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QLQuanLau.Properties.Resources.edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(743, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 56);
            this.btnSua.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImage = global::QLQuanLau.Properties.Resources.circle_of_two_clockwise_arrows_rotation;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(743, 83);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(58, 56);
            this.btnLamMoi.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QLQuanLau.Properties.Resources.trash;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(674, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 56);
            this.btnXoa.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QLQuanLau.Properties.Resources.add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(674, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 56);
            this.btnThem.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(518, 101);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(150, 22);
            this.nudSoLuong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kích thước:";
            // 
            // radNho
            // 
            this.radNho.AutoSize = true;
            this.radNho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNho.Location = new System.Drawing.Point(323, 107);
            this.radNho.Name = "radNho";
            this.radNho.Size = new System.Drawing.Size(50, 20);
            this.radNho.TabIndex = 7;
            this.radNho.Text = "Nhỏ";
            this.radNho.UseVisualStyleBackColor = true;
            // 
            // radBinhThuong
            // 
            this.radBinhThuong.AutoSize = true;
            this.radBinhThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radBinhThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBinhThuong.Location = new System.Drawing.Point(223, 107);
            this.radBinhThuong.Name = "radBinhThuong";
            this.radBinhThuong.Size = new System.Drawing.Size(94, 20);
            this.radBinhThuong.TabIndex = 6;
            this.radBinhThuong.Text = "Bình thường";
            this.radBinhThuong.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(518, 22);
            this.txtTen.MaxLength = 90;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 22);
            this.txtTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên món ăn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(518, 60);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(150, 22);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá:";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Enabled = false;
            this.txtMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonAn.Location = new System.Drawing.Point(228, 19);
            this.txtMaMonAn.MaxLength = 5;
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(150, 22);
            this.txtMaMonAn.TabIndex = 0;
            this.txtMaMonAn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã món ăn:";
            // 
            // ptbMonAn
            // 
            this.ptbMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMonAn.Location = new System.Drawing.Point(6, 19);
            this.ptbMonAn.Name = "ptbMonAn";
            this.ptbMonAn.Size = new System.Drawing.Size(100, 124);
            this.ptbMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMonAn.TabIndex = 0;
            this.ptbMonAn.TabStop = false;
            this.ptbMonAn.Click += new System.EventHandler(this.ptbMonAn_Click);
            // 
            // btnQuayLaiTrangChu
            // 
            this.btnQuayLaiTrangChu.BackgroundImage = global::QLQuanLau.Properties.Resources.exit;
            this.btnQuayLaiTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuayLaiTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLaiTrangChu.Location = new System.Drawing.Point(26, 12);
            this.btnQuayLaiTrangChu.Name = "btnQuayLaiTrangChu";
            this.btnQuayLaiTrangChu.Size = new System.Drawing.Size(68, 34);
            this.btnQuayLaiTrangChu.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnQuayLaiTrangChu, "Trang chủ");
            this.btnQuayLaiTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayLaiTrangChu.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::QLQuanLau.Properties.Resources.search;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(755, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(58, 56);
            this.btnTimKiem.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm kiếm");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimMaMonAn
            // 
            this.txtTimMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaMonAn.Location = new System.Drawing.Point(599, 12);
            this.txtTimMaMonAn.MaxLength = 5;
            this.txtTimMaMonAn.Name = "txtTimMaMonAn";
            this.txtTimMaMonAn.Size = new System.Drawing.Size(150, 22);
            this.txtTimMaMonAn.TabIndex = 15;
            // 
            // txtTimTenMonAn
            // 
            this.txtTimTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenMonAn.Location = new System.Drawing.Point(599, 46);
            this.txtTimTenMonAn.MaxLength = 100;
            this.txtTimTenMonAn.Name = "txtTimTenMonAn";
            this.txtTimTenMonAn.Size = new System.Drawing.Size(150, 22);
            this.txtTimTenMonAn.TabIndex = 18;
            // 
            // radMaMonAn
            // 
            this.radMaMonAn.AutoSize = true;
            this.radMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaMonAn.Location = new System.Drawing.Point(494, 13);
            this.radMaMonAn.Name = "radMaMonAn";
            this.radMaMonAn.Size = new System.Drawing.Size(94, 20);
            this.radMaMonAn.TabIndex = 14;
            this.radMaMonAn.Text = "Mã món ăn:";
            this.radMaMonAn.UseVisualStyleBackColor = true;
            // 
            // radTenMonAn
            // 
            this.radTenMonAn.AutoSize = true;
            this.radTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenMonAn.Location = new System.Drawing.Point(494, 48);
            this.radTenMonAn.Name = "radTenMonAn";
            this.radTenMonAn.Size = new System.Drawing.Size(99, 20);
            this.radTenMonAn.TabIndex = 17;
            this.radTenMonAn.Text = "Tên món ăn:";
            this.radTenMonAn.UseVisualStyleBackColor = true;
            // 
            // radTimMonLau
            // 
            this.radTimMonLau.AutoSize = true;
            this.radTimMonLau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radTimMonLau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimMonLau.Location = new System.Drawing.Point(408, 13);
            this.radTimMonLau.Name = "radTimMonLau";
            this.radTimMonLau.Size = new System.Drawing.Size(72, 20);
            this.radTimMonLau.TabIndex = 13;
            this.radTimMonLau.Text = "Món lẩu";
            this.radTimMonLau.UseVisualStyleBackColor = true;
            // 
            // radTimMonKem
            // 
            this.radTimMonKem.AutoSize = true;
            this.radTimMonKem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radTimMonKem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimMonKem.Location = new System.Drawing.Point(408, 48);
            this.radTimMonKem.Name = "radTimMonKem";
            this.radTimMonKem.Size = new System.Drawing.Size(80, 20);
            this.radTimMonKem.TabIndex = 16;
            this.radTimMonKem.Text = "Món kèm";
            this.radTimMonKem.UseVisualStyleBackColor = true;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // frmQLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(836, 489);
            this.ControlBox = false;
            this.Controls.Add(this.radTimMonKem);
            this.Controls.Add(this.radTimMonLau);
            this.Controls.Add(this.radTenMonAn);
            this.Controls.Add(this.radMaMonAn);
            this.Controls.Add(this.btnQuayLaiTrangChu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.txtTimMaMonAn);
            this.Controls.Add(this.txtTimTenMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý món ăn";
            this.Load += new System.EventHandler(this.frmQLMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radNho;
        private System.Windows.Forms.RadioButton radBinhThuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbMonAn;
        private System.Windows.Forms.Button btnTaoMa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnQuayLaiTrangChu;
        private System.Windows.Forms.TextBox txtTimMaMonAn;
        private System.Windows.Forms.TextBox txtTimTenMonAn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton radMaMonAn;
        private System.Windows.Forms.RadioButton radTenMonAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radMonKem;
        private System.Windows.Forms.RadioButton radMonLau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTimMonLau;
        private System.Windows.Forms.RadioButton radTimMonKem;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMONAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn KICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIMONAN;
    }
}