using QLQuanLau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.PowerBI.Api.Models;
using System.Configuration;
using System.IO;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRANG_CHU
{
    public partial class frmTrangChu : Form
    {
        TRANGCHU_BUS trangchuBUS = new TRANGCHU_BUS();

        List<CTHOADON_DTO> cthdEF = new List<CTHOADON_DTO>();

        List<HOADON_DTO> hdEF = new List<HOADON_DTO>();

        bool chuyenBan = false;

        string bAn = null;

        bool dNhap = false;

        private string tennv;

        private string manv;

        public string TenNV { get { return tennv; } set { tennv = value; } }

        public string MaNV { get { return manv; } set { manv = value; } }

        List<string> lstTenBan = new List<string>();

        List<string> lstMaBan = new List<string>();

        List<bool> lstTrangThai = new List<bool>();

        public frmTrangChu()
        {
            InitializeComponent();

            dgvChiTietHoaDon.AutoGenerateColumns = false;

            txtGia.Text = CONST.ZERO.ToString();

            var tt = Convert.ToInt32(nudSoLuong.Value) * Convert.ToInt32(txtGia.Text);

            txtThanhTien.Text = tt.ToString();
        }

        private void LayThongTinTK(bool role)
        {
            ChangeRole(role);
        }

        private void dangNhap()
        {
            frmDangNhap dn = new frmDangNhap();

            this.Hide();
            if (dn.ShowDialog(this) == DialogResult.OK)
            {
                LayThongTinTK(dn.Role);
                TenNV = dn.TenNV;
                MaNV = dn.MaNV;
                tssThongTinNV.Text = (dn.Role ? CONST.ADMIN : CONST.NHANVIEN) + TenNV;
                dNhap = true;
                this.Show();
            }
        }

        private void mtsDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(CONST.XACNHANDANGXUAT, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                dNhap = false;
                frmTrangChu_Load(sender, e);
            }
        }

        private void mtsThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(CONST.XACNHANTHOAT, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ChangeRole(bool role)
        {
            mtsQuanLyBanAn.Enabled = role;
            mtsQuanLyMonAn.Enabled = role;
            mtsQuanLyNhanVien.Enabled = role;
            mtsQuanLyTaiKhoan.Enabled = role;

            mtsQuanLyBanAn.Visible = role;
            mtsQuanLyMonAn.Visible = role;
            mtsQuanLyNhanVien.Visible = role;
            mtsQuanLyTaiKhoan.Visible = role;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (!dNhap)
                dangNhap();

            LoadCbb();

            LoadImageList();
            LoadAnhNULL();
            LoadDSBan();
            btnLamMoi_Click(sender, e);

            cbbMonAn.SelectedIndex = -1;
        }

        private void LoadCbb()
        {
            AutoCompleteStringCollection au = new AutoCompleteStringCollection();

            List<MONAN_DTO> ds = trangchuBUS.LayDSMonAn();

            foreach (var item in ds)
            {
                string ten = item.TENMON;
                au.Add(ten);
            }

            cbbMonAn.AutoCompleteCustomSource = au;
            cbbMonAn.DataSource = ds;
            cbbMonAn.DisplayMember = CONST.TENMON;
            cbbMonAn.ValueMember = CONST.MAMONAN;
        }

        private void mtsQuanLyMonAn_Click(object sender, EventArgs e)
        {
            frmQLMonAn ml = new frmQLMonAn();
            this.Hide();
            ml.ShowDialog();
            frmTrangChu_Load(sender, e);
            this.Show();
        }

        private void mtsQuanLyBanAn_Click(object sender, EventArgs e)
        {
            frmQLBanAn ba = new frmQLBanAn();
            this.Hide();
            ba.ShowDialog();
            frmTrangChu_Load(sender, e);
            this.Show();
        }

        private void mtsQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan tk = new frmQuanLyTaiKhoan();
            this.Hide();
            tk.MaNV = this.MaNV;
            tk.ShowDialog();
            this.Show();
        }

        private void mtsQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon hd = new frmQuanLyHoaDon();
            this.Hide();
            hd.ShowDialog();
            this.Show();

        }

        private void mtsQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien nv = new frmQLNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void mnsBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            frmBaoCaoVaThongKe bctk = new frmBaoCaoVaThongKe();
            this.Hide();
            bctk.ShowDialog();
            this.Show();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbMonAn.SelectedValue == null)
            {
                MessageBox.Show(CONST.TBNHAPMONAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bAn == null)
            {
                MessageBox.Show(CONST.TBCHONBAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maMonAn = null;
            bool ktMonAn = true;
            string maHD = null;

            foreach (var item in hdEF)
            {
                maHD = item.MAHD;
            }

            if (!trangchuBUS.HDCoTonTai(maHD))
            {
                int slHD = trangchuBUS.DemSLHoaDon() + 1;

                HOADON_DTO newHD = new HOADON_DTO
                {
                    MAHD = string.Format(CONST.HD, slHD.ToString(CONST.FORMAT_TAM0)),
                    MABAN = bAn,
                    MANVLAPDON = MaNV,
                    NGAYLAP = DateTime.Now,
                    TONGTIEN = CONST.ZERO,
                    THANHTOAN = false
                };

                maHD = string.Format(CONST.HD, slHD.ToString(CONST.FORMAT_TAM0));

                if (!trangchuBUS.ThemHD(newHD))
                {
                    MessageBox.Show(CONST.THEMTB, CONST.THONGBAO);
                    return;
                }
            }

            List<MONAN_DTO> dsMA = trangchuBUS.LayDSMonAn();

            foreach (var item in dsMA)
            {
                if (item.MAMONAN == cbbMonAn.SelectedValue.ToString())
                {
                    maMonAn = item.MAMONAN;
                    ktMonAn = item.KICHTHUOC;
                    break;
                }
            }

            CTHOADON_DTO newCTHD = new CTHOADON_DTO
            {
                MAHD = maHD,
                MAMONAN = maMonAn,
                TENMON = cbbMonAn.Text,
                GIA = Convert.ToInt32(txtGia.Text.Replace(CONST.DAUPHAY, CONST.TRONG)),
                THANHTIEN = Convert.ToInt32(txtThanhTien.Text.Replace(CONST.DAUPHAY,CONST.TRONG)),
                SOLUONG = Convert.ToInt32(nudSoLuong.Value),
                KICHTHUOC = ktMonAn
            };

            if (trangchuBUS.ThemCTHD(newCTHD))
            {
                hdEF = trangchuBUS.LayHoaDonTheoBan(bAn);

                foreach (var item in hdEF)
                {
                    trangchuBUS.LoadTrangThaiBanAn(item.MABAN, item.THANHTOAN);
                }

                MessageBox.Show(CONST.THEMTC, CONST.THONGBAO);
                LoadCbb();
                LamMoi();
                LoadDSMonAn();

                lvwDanhSachBan.SelectedItems[CONST.ZERO].SubItems[CONST.HAI].Text = CONST.TRUE;
            }
            else
            {
                MessageBox.Show(CONST.THEMTB, CONST.THONGBAO);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMonAn = null;
            bool ktMonAn = true;
            string maHD = null;

            foreach (var item in hdEF)
            {
                maHD = item.MAHD;
            }

            List<MONAN_DTO> dsMA = trangchuBUS.LayDSMonAn();

            foreach (var item in dsMA)
            {
                if (cbbMonAn.SelectedValue == null)
                {
                    maMonAn = dgvChiTietHoaDon.SelectedRows[CONST.ZERO].Cells[CONST.MAMONAN].Value.ToString();
                    ktMonAn = (bool)dgvChiTietHoaDon.SelectedRows[CONST.ZERO].Cells[CONST.KICHTHUOC].Value;
                    break;
                }
                else
                {
                    if (item.MAMONAN == cbbMonAn.SelectedValue.ToString())
                    {
                        maMonAn = item.MAMONAN;
                        ktMonAn = item.KICHTHUOC;
                        break;
                    }
                }
            }

            CTHOADON_DTO newCTHD = new CTHOADON_DTO
            {
                MAHD = maHD,
                MAMONAN = maMonAn,
                TENMON = cbbMonAn.Text,
                GIA = Convert.ToInt32(txtGia.Text.Replace(CONST.DAUPHAY, CONST.TRONG)),
                THANHTIEN = Convert.ToInt32(txtThanhTien.Text.Replace(CONST.DAUPHAY, CONST.TRONG)),
                SOLUONG = Convert.ToInt32(nudSoLuong.Value),
                KICHTHUOC = ktMonAn
            };

            if (trangchuBUS.SuaCTHD(newCTHD))
            {
                MessageBox.Show(CONST.SUATC, CONST.THONGBAO);
                LoadCbb();
                LamMoi();
                LoadDSMonAn();
            }
            else
            {
                MessageBox.Show(CONST.SUATC, CONST.THONGBAO);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbMonAn.SelectedValue == null)
            {
                MessageBox.Show(CONST.TBNHAPMONAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bAn == null)
            {
                MessageBox.Show(CONST.TBCHONBAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maMonAn = null;
            bool ktMonAn = true;
            string maHD = null;

            foreach (var item in hdEF)
            {
                maHD = item.MAHD;
            }

            List<MONAN_DTO> dsMA = trangchuBUS.LayDSMonAn();

            foreach (var item in dsMA)
            {
                if (item.MAMONAN == cbbMonAn.SelectedValue.ToString())
                {
                    maMonAn = item.MAMONAN;
                    ktMonAn = item.KICHTHUOC;
                    break;
                }
            }

            DialogResult dia = MessageBox.Show(CONST.TBXACNHANXOA, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No) return;

            CTHOADON_DTO delCTHD = new CTHOADON_DTO
            {
                MAHD = maHD,
                MAMONAN = maMonAn
            };

            if (trangchuBUS.XoaCTHD(delCTHD))
            {
                MessageBox.Show(CONST.XOATC, CONST.THONGBAO);
                LoadCbb();
                LamMoi();
                LoadDSMonAn();
            }
            else
            {
                MessageBox.Show(CONST.XOATB, CONST.THONGBAO);
            }
        }

        private void cbbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonAn.SelectedIndex == -1) return;

            List<MONAN_DTO> ds = trangchuBUS.LayDSMonAn();

            foreach (var item in ds)
            {
                if (cbbMonAn.SelectedValue.ToString() == item.MAMONAN)
                {
                    txtGia.Text = item.GIA.ToString();

                    nudSoLuong.Value = nudSoLuong.Minimum;
                    nudSoLuong.Maximum = item.SOLUONG;

                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    if (File.Exists(CONST.FOLDER_PATH + CONST.CHEO_PHAI + item.MAMONAN + CONST.DINHDANG_JPG))
                    {
                        try
                        {
                            byte[] byteHA = File.ReadAllBytes(CONST.FOLDER_PATH + CONST.CHEO_PHAI + item.MAMONAN + CONST.DINHDANG_JPG);

                            MemoryStream mos = new MemoryStream(byteHA);

                            ptbMonAn.Image = Image.FromStream(mos);
                        }
                        catch
                        {
                            LoadAnhError();
                        }
                    }
                    else
                    {
                        LoadAnhNULL();
                    }

                    break;
                }
            }
        }

        private void LoadThongTinDSMonAn()
        {
            for (int i = CONST.ZERO; i < dgvChiTietHoaDon.RowCount; i++)
            {
                dgvChiTietHoaDon.Rows[i].Cells[CONST.TENKICHTHUOC].Value = (bool)dgvChiTietHoaDon.Rows[i].Cells[CONST.KICHTHUOC].Value ? CONST.BINHTHUONG : CONST.NHO;
            }
        }

        private void LoadDuLieuBan()
        {
            lstMaBan.Clear();
            lstTenBan.Clear();
            lstTrangThai.Clear();

            List<BANAN_DTO> dsBA = trangchuBUS.LayDSBanAn();

            foreach (var item in dsBA)
            {
                lstMaBan.Add(item.MABAN);
                lstTenBan.Add(item.TENBAN);
                lstTrangThai.Add(item.COKHACH);
            }
        }

        private void LoadDSBan()
        {
            LoadDuLieuBan();

            lvwDanhSachBan.Items.Clear();

            for (int i = CONST.ZERO; i < lstMaBan.Count; i++)
            {
                ListViewItem item = new ListViewItem(lstTenBan[i], lstTrangThai[i] ? CONST.RED_HOT_POT : CONST.GREEN_HOT_POT);
                item.SubItems.Add(lstMaBan[i]);
                item.SubItems.Add(lstTrangThai[i].ToString());

                lvwDanhSachBan.Items.Add(item);
            }
        }

        private void LoadImageList()
        {
            DirectoryInfo dir = new DirectoryInfo(CONST.FOLDER_PATH_BA);

            FileInfo[] listFile = dir.GetFiles(CONST.LAYDINHDANG_JPG);

            foreach (FileInfo fi in listFile)
            {
                imgListTraSuaLarge.Images.Add(fi.Name, Image.FromFile(fi.FullName));
            }
        }

        private void LoadAnhNULL()
        {
            byte[] byteHA = File.ReadAllBytes(CONST.ANHNULL);

            MemoryStream mos = new MemoryStream(byteHA);

            ptbMonAn.Image = Image.FromStream(mos);
        }

        private void LoadAnhError()
        {
            byte[] byteHA = File.ReadAllBytes(CONST.ANHLOI);

            MemoryStream mos = new MemoryStream(byteHA);

            ptbMonAn.Image = Image.FromStream(mos);
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == -1) return;

            cbbMonAn.SelectedValue = dgvChiTietHoaDon.Rows[i].Cells[CONST.MAMONAN].Value.ToString();
            cbbMonAn.Text = dgvChiTietHoaDon.Rows[i].Cells[CONST.TENMON].Value.ToString();
            nudSoLuong.Value = Convert.ToInt32(dgvChiTietHoaDon.Rows[i].Cells[CONST.SOLUONG].Value);
            txtGia.Text = dgvChiTietHoaDon.Rows[i].Cells[CONST.GIA].Value.ToString();
            txtThanhTien.Text = dgvChiTietHoaDon.Rows[i].Cells[CONST.THANHTIEN].Value.ToString();

            if (File.Exists(CONST.FOLDER_PATH + CONST.CHEO_PHAI + cbbMonAn.SelectedValue + CONST.DINHDANG_JPG))
            {
                try
                {
                    byte[] byteHA = File.ReadAllBytes(CONST.FOLDER_PATH + CONST.CHEO_PHAI + cbbMonAn.SelectedValue + CONST.DINHDANG_JPG);

                    MemoryStream mos = new MemoryStream(byteHA);

                    ptbMonAn.Image = Image.FromStream(mos);
                }
                catch
                {
                    LoadAnhError();
                }
            }
            else
            {
                LoadAnhNULL();
            }

            cbbMonAn.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            var tt = Convert.ToInt32(nudSoLuong.Value) * Convert.ToInt32(txtGia.Text.Replace(CONST.DAUPHAY,CONST.TRONG));
            txtThanhTien.Text = ConvertToMoney(tt.ToString());
        }

        private void LoadDSMonAn()
        {
            double tongTien = CONST.ZERO;
            hdEF.Clear();
            cthdEF.Clear();
            dgvChiTietHoaDon.DataSource = null;

            hdEF = trangchuBUS.LayHoaDonTheoBan(bAn);

            foreach (var item in hdEF)
            {
                cthdEF = trangchuBUS.LayDSMonAnTheoBan(item.MAHD);
            }

            foreach (var item in cthdEF)
            {
                tongTien += item.THANHTIEN;
            }

            txtTongTien.Text = ConvertToMoney(tongTien.ToString());

            dgvChiTietHoaDon.DataSource = cthdEF;

            if (cthdEF.Count != CONST.ZERO)
            {
                LoadThongTinDSMonAn();

                txtTienNhan.Enabled = true;
                btnThanhToan.Enabled = true;
            }
        }

        private void LoadTrangThaiBanAn()
        {
            foreach (var item in hdEF)
            {
                trangchuBUS.LoadTrangThaiBanAn(item.MABAN, item.THANHTOAN);
            }

            LoadDSBan();

            for (int i = CONST.ZERO; i < lstMaBan.Count; i++)
            {
                lvwDanhSachBan.Items[i].ImageKey = lstTrangThai[i] ? CONST.RED_HOT_POT : CONST.GREEN_HOT_POT;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            bAn = null;
            chuyenBan = false;
            lvwDanhSachBan.SelectedItems.Clear();
            txtTienNhan.Enabled = false;
            btnThanhToan.Enabled = false;

            LamMoi();
            LoadTrangThaiBanAn();
        }

        private void LamMoi()
        {
            nudSoLuong.Value = nudSoLuong.Minimum;
            txtGia.Text = CONST.KYTUZERO;
            txtThanhTien.Text = CONST.KYTUZERO;
            txtTongTien.Text = CONST.KYTUZERO;
            txtTienDu.Text = CONST.KYTUZERO;
            txtTienNhan.Text = string.Empty;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cbbMonAn.Enabled = true;
            cbbMonAn.SelectedIndex = -1;

            dgvChiTietHoaDon.DataSource = null;
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            string maHD = null;

            foreach (var item in hdEF)
            {
                maHD = item.MAHD;
            }

            if (bAn == null)
            {
                MessageBox.Show(CONST.TBCHONBAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maHD == null)
            {
                MessageBox.Show(CONST.KHONG_THE_CHUYEN_BAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chuyenBan = true;
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtTienNhan.Text == CONST.TRONG || txtTienNhan.Text == CONST.KYTUZERO) return;

            txtTienNhan.Text = ConvertToMoney(txtTienNhan.Text);
            txtTienNhan.SelectionStart = txtTienNhan.Text.Length;

            try
            {
                double td = CONST.ZERO;

                double tn = Convert.ToInt64(txtTienNhan.Text.Replace(CONST.DAUPHAY, CONST.TRONG));

                double tt = Convert.ToInt64(txtTongTien.Text.Replace(CONST.DAUPHAY, CONST.TRONG));

                td = tt - tn;

                if (td >= CONST.ZERO)
                {
                    txtTienDu.Text = CONST.KYTUZERO;
                    return;
                }
                else
                    td = -td;
                
                txtTienDu.Text = ConvertToMoney(td.ToString());
            }
            catch
            {
                txtTienDu.Text = CONST.KYTUZERO;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTienNhan.Text))
            {
                MessageBox.Show(CONST.YEU_CAU_NHAP_TIEN_NHAN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show(CONST.XAC_NHAN_THANH_TOAN, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No) return;

            double tn = Convert.ToInt64(txtTienNhan.Text.Replace(CONST.DAUPHAY,CONST.TRONG));

            double tt = Convert.ToInt64(txtTongTien.Text.Replace(CONST.DAUPHAY, CONST.TRONG));

            double td = tt - tn;

            if (td > 0)
            {
                MessageBox.Show(CONST.TBKHONGDUTIEN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dialog == DialogResult.Yes)
            {
                string maHD = null;

                foreach (var item in hdEF)
                {
                    maHD = item.MAHD;
                }

                HOADON_DTO hd = new HOADON_DTO
                {
                    MAHD = maHD,
                    MABAN = bAn,
                    MANVLAPDON = MaNV,
                    NGAYLAP = DateTime.Now,
                    TONGTIEN = Convert.ToInt64(txtTongTien.Text.Replace(CONST.DAUPHAY, CONST.TRONG)),
                    THANHTOAN = true
                };

                if (trangchuBUS.ThanhToan(hd))
                {
                    frmBaoCao bc = new frmBaoCao(maHD);
                    bc.ShowDialog();
                    LoadDSBan();
                    LoadDSMonAn();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(CONST.THANHTOANTB, CONST.THONGBAO);
                }
            }
        }

        private void lvwDanhSachBan_MouseClick(object sender, MouseEventArgs e)
        {
            bAn = null;

            for (int i = CONST.ZERO; i < lvwDanhSachBan.Items.Count; i++)
            {
                lvwDanhSachBan.Items[i].ImageKey = lvwDanhSachBan.Items[i].SubItems[CONST.HAI].Text == CONST.TRUE ? CONST.RED_HOT_POT : CONST.GREEN_HOT_POT;
            }

            if (lvwDanhSachBan.SelectedItems.Count > CONST.ZERO)
            {
                LamMoi();

                bAn = lvwDanhSachBan.SelectedItems[CONST.ZERO].SubItems[CONST.MOT].Text;

                lvwDanhSachBan.SelectedItems[CONST.ZERO].ImageKey = CONST.BLUE_HOT_POT;

                if (chuyenBan)
                {
                    DialogResult dia = MessageBox.Show(CONST.XACNHANCHUYENBAN, CONST.THONGBAO, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dia == DialogResult.Yes)
                    {
                        string maHD = null;

                        foreach (var item in hdEF)
                        {
                            maHD = item.MAHD;
                        }

                        HOADON_DTO hd1 = new HOADON_DTO
                        {
                            MAHD = maHD,
                            MABAN = bAn,
                            MANVLAPDON = MaNV,
                            NGAYLAP = DateTime.Now,
                            TONGTIEN = CONST.ZERO,
                            THANHTOAN = false
                        };

                        if (!trangchuBUS.KTBanConTrong(bAn))
                        {
                            hdEF = trangchuBUS.LayHoaDonTheoBan(bAn);

                            foreach (var item in hdEF)
                            {
                                maHD = item.MAHD;
                            }

                            HOADON_DTO hd2 = new HOADON_DTO
                            {
                                MAHD = maHD,
                                MABAN = bAn,
                                MANVLAPDON = MaNV,
                                NGAYLAP = DateTime.Now,
                                TONGTIEN = CONST.ZERO,
                                THANHTOAN = false
                            };

                            if (trangchuBUS.DaoBan(hd1, hd2))
                            {
                                MessageBox.Show(CONST.CHUYENBANTC, CONST.THONGBAO);
                                chuyenBan = false;
                                LoadDSMonAn();
                                LoadTrangThaiBanAn();
                                btnLamMoi_Click(sender, e);
                                return;
                            }
                            else
                            {
                                MessageBox.Show(CONST.CHUYENBANTB, CONST.THONGBAO);
                                return;
                            }
                        }

                        if (trangchuBUS.ChuyenBan(hd1))
                        {
                            MessageBox.Show(CONST.CHUYENBANTC, CONST.THONGBAO);
                            chuyenBan = false;
                            LoadDSMonAn();
                            LoadTrangThaiBanAn();
                            btnLamMoi_Click(sender, e);
                            return;
                        }
                        else
                        {
                            MessageBox.Show(CONST.CHUYENBANTB, CONST.THONGBAO);
                            return;
                        }
                    }

                    if (dia == DialogResult.No)
                    {
                        LoadTrangThaiBanAn();
                        dia = DialogResult.None;
                        return;
                    }

                    if (dia == DialogResult.Cancel)
                    {
                        btnLamMoi_Click(sender, e);
                        return;
                    }
                }
            }

            if (bAn != null)
            {
                txtTienNhan.Enabled = false;
                btnThanhToan.Enabled = false;

                LoadDSMonAn();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssTimer.Text = DateTime.Now.ToString(CONST.TIMER);
        }

        private string ConvertToMoney(string tt)
        {
            decimal number;
            number = decimal.Parse(tt, System.Globalization.NumberStyles.Currency);
            tt = number.ToString(CONST.DINHDANGMONEY);
            return tt;
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text == CONST.TRONG || txtGia.Text == CONST.KYTUZERO) return;

            txtGia.Text = ConvertToMoney(txtGia.Text);
            txtThanhTien.Text = ConvertToMoney(txtGia.Text);
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (txtThanhTien.Text == CONST.TRONG || txtThanhTien.Text == CONST.KYTUZERO) return;

            txtThanhTien.Text = ConvertToMoney(txtThanhTien.Text);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text == CONST.TRONG || txtThanhTien.Text == CONST.KYTUZERO) return;

            txtTongTien.Text = ConvertToMoney(txtTongTien.Text);
        }

        private void txtTienDu_TextChanged(object sender, EventArgs e)
        {
            if (txtTienDu.Text == CONST.TRONG || txtThanhTien.Text == CONST.KYTUZERO) return;

            txtTienDu.Text = ConvertToMoney(txtTienDu.Text);
        }
    }
}
