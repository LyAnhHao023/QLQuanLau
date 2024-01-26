using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQuanLau
{
    public partial class frmQLMonAn : Form
    {
        QLMONAN_BUS _monanBUS = new QLMONAN_BUS();

        DataView dv = new DataView();

        private bool SuaAnh = false;

        public frmQLMonAn()
        {
            InitializeComponent();

            dgvMonAn.AutoGenerateColumns = false;

            radBinhThuong.Checked = true;
            radMaMonAn.Checked = true;
            radMonLau.Checked = true;
        }

        private void frmQLMonAn_Load(object sender, EventArgs e)
        {
            LoadDSMonAn();

            LoadThemAnh();

            SuaAnh = false;
        }

        private void LoadDSMonAn()
        {
            dv.Table = Utils.ConvertListOjbectToDataTable(_monanBUS.LayDSMonAn(), CONST.DSMA);
            dgvMonAn.DataSource = dv;
        }

        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);

            if (radMonLau.Checked)
            {
                int rows = _monanBUS.SoLuongML() + 1;

                txtMaMonAn.Text = String.Format(CONST.ML, rows.ToString(CONST.TRIPZERO));
            }
            if (radMonKem.Checked)
            {
                int rows = _monanBUS.SoLuongMK() + 1;

                txtMaMonAn.Text = String.Format(CONST.MK, rows.ToString(CONST.TRIPZERO));
            }

            LoadThemAnh();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaMonAn.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show(CONST.NHAPTTTHEM, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MONAN_DTO newML = new MONAN_DTO
            {
                MAMONAN = txtMaMonAn.Text,
                GIA = Convert.ToInt64(txtGia.Text.Replace(CONST.DAUPHAY,CONST.TRONG)),
                KICHTHUOC = radBinhThuong.Checked ? true : false,
                SOLUONG = Convert.ToInt32(nudSoLuong.Value),
                TENMON = radBinhThuong.Checked ? txtTen.Text : txtTen.Text + CONST.TENKTNHO,
                TRANGTHAI = nudSoLuong.Value > 0 ? true : false,
                LOAIMONAN = radMonLau.Checked ? true : false
            };

            if (_monanBUS.TenDaTonTai(newML))
            {
                MessageBox.Show(CONST.DATONTAI_MON_AN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ptbMonAn.Image != null && SuaAnh)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG, FileMode.Create, FileAccess.ReadWrite))
                    {
                        byte[] bytes = ConvertImageToByteArray(ptbMonAn.Image);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
            }

            if (_monanBUS.ThemMonAn(newML))
            {
                MessageBox.Show(CONST.THEMTC, CONST.THONGBAO);

                btnLamMoi_Click(sender, e);

                frmQLMonAn_Load(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.THEMTB, CONST.THONGBAO);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                MessageBox.Show(CONST.NHAPTTXOA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dia = MessageBox.Show(CONST.TBXACNHANXOA, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No) return;

            MONAN_DTO delML = new MONAN_DTO
            {
                MAMONAN = txtMaMonAn.Text
            };

            if (ptbMonAn.Image != null && File.Exists(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG))
            {
                XoaFile(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG);
            }

            if (_monanBUS.XoaMonAn(delML))
            {
                MessageBox.Show(CONST.XOATC, CONST.THONGBAO);

                btnLamMoi_Click(sender, e);

                frmQLMonAn_Load(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.XOATB, CONST.THONGBAO);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtTimMaMonAn.Text = string.Empty;
            txtTimTenMonAn.Text = string.Empty;
            radMaMonAn.Checked = true;
            radBinhThuong.Checked = true;
            nudSoLuong.Value = 0;

            LoadThemAnh();
            LoadDSMonAn();

            SuaAnh = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show(CONST.NHAPTTSUA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MONAN_DTO updMA = new MONAN_DTO
            {
                MAMONAN = txtMaMonAn.Text,
                GIA = Convert.ToInt64(txtGia.Text.Replace(CONST.DAUPHAY, CONST.TRONG)),
                KICHTHUOC = radBinhThuong.Checked ? true : false,
                SOLUONG = Convert.ToInt32(nudSoLuong.Value),
                TENMON = radBinhThuong.Checked ? txtTen.Text : txtTen.Text + CONST.TENKTNHO,
                TRANGTHAI = nudSoLuong.Value > 0 ? true : false,
                LOAIMONAN = radMonLau.Checked ? true : false
            };

            if (!_monanBUS.TenDaTonTai(updMA) && _monanBUS.MonAnDaTonTai(updMA))
            {
                MessageBox.Show(CONST.DATONTAI_MON_AN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SuaAnh)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG, FileMode.Create, FileAccess.ReadWrite))
                    {
                        byte[] bytes = ConvertImageToByteArray(ptbMonAn.Image);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
            }

            if (_monanBUS.SuaMonAn(updMA))
            {
                MessageBox.Show(CONST.SUATC, CONST.THONGBAO);

                btnLamMoi_Click(sender, e);

                frmQLMonAn_Load(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.SUATB, CONST.THONGBAO);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radMaMonAn.Checked)
            {
                if (string.IsNullOrEmpty(txtTimMaMonAn.Text))
                {
                    MessageBox.Show(CONST.TIMMA, CONST.THONGBAO);
                    return;
                }

                dv.RowFilter = CONST.TKMAMONAN + txtTimMaMonAn.Text + CONST.DONG_NHAY_PHAN_TRAM;
            }
            if (radTenMonAn.Checked)
            {
                if (string.IsNullOrEmpty(txtTimTenMonAn.Text))
                {
                    MessageBox.Show(CONST.TIMTEN, CONST.THONGBAO);
                    return;
                }

                dv.RowFilter = CONST.TKTENMON + txtTimTenMonAn.Text + CONST.DONG_NHAY_PHAN_TRAM;
            }
            if (radTimMonLau.Checked)
            {
                dv.RowFilter = CONST.LOAIMONAN + CONST.DAUBANG + true;
            }
            if (radTimMonKem.Checked)
            {
                dv.RowFilter = CONST.LOAIMONAN + CONST.DAUBANG + false;
            }
        }

        private void radMonAn_CheckedChanged(object sender, EventArgs e)
        {
            if (radMonLau.Checked)
            {
                radBinhThuong.Enabled = true;
                radNho.Enabled = true;
            }
            if (radMonKem.Checked)
            {
                radBinhThuong.Checked = true;
                radBinhThuong.Enabled = false;
                radNho.Enabled = false;
            }

            txtMaMonAn.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGia.Text = string.Empty;
            nudSoLuong.Value = 0;

            LoadThemAnh();

            SuaAnh = false;
            btnThem.Enabled = false;
        }

        private void dgvMonAn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            int i = e.RowIndex;

            txtMaMonAn.Text = dgvMonAn.Rows[i].Cells[CONST.MAMONAN].Value.ToString();
            txtTen.Text = dgvMonAn.Rows[i].Cells[CONST.TENMON].Value.ToString();
            txtGia.Text = dgvMonAn.Rows[i].Cells[CONST.GIA].Value.ToString();
            nudSoLuong.Value = Convert.ToInt32(dgvMonAn.Rows[i].Cells[CONST.SOLUONG].Value);
            if ((bool)dgvMonAn.Rows[i].Cells[CONST.KICHTHUOC].Value)
                radBinhThuong.Checked = true;
            else
                radNho.Checked = true;
            if ((bool)dgvMonAn.Rows[i].Cells[CONST.LOAIMONAN].Value)
                radMonLau.Checked = true;
            else
                radMonKem.Checked = true;

            if (File.Exists(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG))
            {
                try
                {
                    byte[] byteHA = File.ReadAllBytes(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG);

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

            SuaAnh = false;
            txtMaMonAn.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            }
            catch
            {
                return;
            }
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;

                txtMaMonAn.Text = dgvMonAn.Rows[i].Cells[CONST.MAMONAN].Value.ToString();
                txtTen.Text = dgvMonAn.Rows[i].Cells[CONST.TENMON].Value.ToString();
                txtGia.Text = dgvMonAn.Rows[i].Cells[CONST.GIA].Value.ToString();
                nudSoLuong.Value = Convert.ToInt32(dgvMonAn.Rows[i].Cells[CONST.SOLUONG].Value);
                if ((bool)dgvMonAn.Rows[i].Cells[CONST.KICHTHUOC].Value)
                    radBinhThuong.Checked = true;
                else
                    radNho.Checked = true;
                if ((bool)dgvMonAn.Rows[i].Cells[CONST.LOAIMONAN].Value)
                    radMonLau.Checked = true;
                else
                    radMonKem.Checked = true;

                if (File.Exists(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG))
                {
                    try
                    {
                        byte[] byteHA = File.ReadAllBytes(CONST.FOLDER_PATH + CONST.CHEO_PHAI + txtMaMonAn.Text + CONST.DINHDANG_JPG);

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

                SuaAnh = false;
                txtMaMonAn.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;

            }
            catch
            {
                return;
            }
        }

        private void ptbMonAn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            ofdFile.InitialDirectory = CONST.DIA_C;

            ofdFile.Filter = CONST.KIEUANH;
            ofdFile.FilterIndex = CONST.HAI;
            ofdFile.RestoreDirectory = true;

            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofdFile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            ptbMonAn.Image = Image.FromStream(myStream);
                            SuaAnh = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(CONST.KHONGTHEMOANH + ex.Message, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                myStream.Close();
                myStream.Dispose();
                System.GC.Collect();
            }
        }

        private byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imageToConvert);

                bmp.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();
            }
        }

        private void LoadThemAnh()
        {
            byte[] byteHA = File.ReadAllBytes(CONST.THEMANH);

            MemoryStream mos = new MemoryStream(byteHA);

            ptbMonAn.Image = Image.FromStream(mos);
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

        private bool XoaFile(string filename)
        {
            try
            {
                File.Delete(filename);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text == CONST.TRONG || txtGia.Text == CONST.KYTUZERO) return;
            decimal number;
            number = decimal.Parse(txtGia.Text, System.Globalization.NumberStyles.Currency);
            txtGia.Text = number.ToString(CONST.DINHDANGMONEY);
            txtGia.SelectionStart = txtGia.Text.Length;
        }
    }
}
