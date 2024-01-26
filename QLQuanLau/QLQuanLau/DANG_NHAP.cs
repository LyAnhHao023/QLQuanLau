using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRANG_CHU;
using BUS;
using DTO;

namespace QLQuanLau
{
    public partial class frmDangNhap : Form
    {
        DANGNHAP_BUS _dangnhapBUS = new DANGNHAP_BUS();

        private frmTrangChu frm = new frmTrangChu();

        private bool role;

        private string tnv;

        private string manv;

        public bool Role { get { return role; } set { role = value; } }

        public string TenNV { get { return tnv; } set { tnv = value; } }

        public string MaNV { get { return manv; } set { manv = value; } }

        public frmDangNhap()
        {
            InitializeComponent();

            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) && string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(CONST.TBDANGNHAP, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) == false && string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(CONST.TBNHAPMK, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) && string.IsNullOrEmpty(txtMatKhau.Text) == false)
            {
                MessageBox.Show(CONST.TBNHAPTK, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtTaiKhoan.Text == CONST.TKAN && txtMatKhau.Text == CONST.MKAN)
            {
                Role = CONST.QUYEN;
                MaNV = CONST.MAAN;
                TenNV = CONST.TENAN;

                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            TAIKHOAN_DTO tk = new TAIKHOAN_DTO
            {
                TENDANGNHAP = txtTaiKhoan.Text,
                MATKHAU = Utils.GetMD5(txtMatKhau.Text)
            };

            List<TAIKHOAN_DTO> tkEF = _dangnhapBUS.DangNhap(tk);

            List<NHANVIEN_DTO> nvEF = new List<NHANVIEN_DTO>();

            if(tkEF.Count != 0)
            {
                foreach(var item in tkEF)
                {
                    string nv = item.MANV;

                    nvEF = _dangnhapBUS.LayThongTinTK(nv);
                }

                foreach(var item in nvEF)
                {
                    Role = item.CHUCVU;
                    TenNV = item.HOTEN;
                    MaNV = item.MANV;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(CONST.TBDANGNHAPTB, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(CONST.XACNHANTHOAT, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
