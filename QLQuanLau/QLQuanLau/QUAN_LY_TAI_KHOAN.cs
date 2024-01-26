using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanLau
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        private string maNV;

        public string MaNV { get { return maNV; } set { maNV = value; } }

        QuanLyTaiKhoanBUS TKBUS = new QuanLyTaiKhoanBUS();
        DataView dvTK = new DataView();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            dgvQLTK.AutoGenerateColumns = false;
        }
        private void load_DSTK()
        {
            dvTK.Table = Utils.ConvertListOjbectToDataTable(TKBUS.LayDSTaiKhoan(), CONST.DSTK);
            dgvQLTK.DataSource = dvTK;
        }
        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            load_DSTK();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtTenTK.ResetText();
            txtMatKhau.ResetText();
            load_DSTK();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text) || string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(CONST.NHAPTTXOA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult dia = MessageBox.Show(CONST.TBXACNHANXOA, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No) return;

            TAIKHOAN_DTO DelTK = new TAIKHOAN_DTO
            {
                TENDANGNHAP = txtTenTK.Text
            };

            if (TKBUS.Xoa(DelTK, MaNV))
            {
                MessageBox.Show(CONST.XOATC, CONST.THONGBAO);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.XOATB, CONST.THONGBAO);
            }
        }

        private void dgvQLTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLTK.SelectedRows.Count > CONST.ZERO)
            {
                txtMaNV.Text = dgvQLTK.SelectedRows[0].Cells[CONST.colMaNV].Value?.ToString();
                txtTenTK.Text = dgvQLTK.SelectedRows[0].Cells[CONST.colTenDN].Value?.ToString();
                txtMatKhau.Text = dgvQLTK.SelectedRows[0].Cells[CONST.colMatKhau].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(CONST.NHAPTTSUA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TAIKHOAN_DTO SuaTK = new TAIKHOAN_DTO
            {
                TENDANGNHAP = txtTenTK.Text,
                MATKHAU = Utils.GetMD5(txtMatKhau.Text),
            };
            if (TKBUS.Sua(SuaTK))
            {
                MessageBox.Show(CONST.SUATC, CONST.THONGBAO);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.SUATB, CONST.THONGBAO);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text) || string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(CONST.NHAPTTTHEM, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TAIKHOAN_DTO newTK = new TAIKHOAN_DTO
            {
                TENDANGNHAP = txtTenTK.Text,
                MANV = txtMaNV.Text,
                MATKHAU = Utils.GetMD5(txtMatKhau.Text),
                XOA = false
            };

            if (TKBUS.ThemTK(newTK))
            {
                MessageBox.Show(CONST.THEMTC, CONST.THONGBAO);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.THEMTB, CONST.THONGBAO);
            }
        }

        private void btnTimKiemMaNV_Click(object sender, EventArgs e)
        {
            dvTK.RowFilter = CONST.TKMANV + txtMaNV.Text + CONST.DONG_NHAY_PHAN_TRAM;
        }

        private void btnTimKiemTenTK_Click(object sender, EventArgs e)
        {
            dvTK.RowFilter = CONST.TKTENDN + txtTenTK.Text + CONST.DONG_NHAY_PHAN_TRAM;
        }

    }
}
