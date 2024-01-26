using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQuanLau
{
    public partial class frmQLNhanVien : Form
    {
        private string maNV;

        public string MaNV { get { return maNV; } set { maNV = value; } }

        static DataView dvDSNV = new DataView();
        public QLNHANVIEN_BUS NVbus = new QLNHANVIEN_BUS();
        public frmQLNhanVien()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDSNSS.AutoGenerateColumns = false;
            cbbChucVu.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show(CONST.TBXACNHANSUA, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtHoTenNV.Text) || string.IsNullOrEmpty(txtCMNDNV.Text))
            {
                MessageBox.Show(CONST.NHAPTTSUA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NHANVIEN_DTO suanv = new NHANVIEN_DTO
            {
                MANV = txtMaNV.Text,
                HOTEN = txtHoTenNV.Text,
                NGAYSINH = Convert.ToDateTime(dtpNgaySinhNV.Value.ToString(CONST.DINHDANGDATE)),
                CMND = txtCMNDNV.Text,
                CHUCVU = Convert.ToBoolean(cbbChucVu.SelectedIndex),
                XOA = false
            };
            if (NVbus.Sua_NV(suanv))
            {
                MessageBox.Show(CONST.SUATC, CONST.THONGBAO);
                frmQLNhanVien_Load(sender, e);
                btnLamMoi_Click(sender, e);
                return;
            }
            else
            {
                MessageBox.Show(CONST.SUATB, CONST.THONGBAO);
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            cbbChucVu.SelectedIndex = 0;
            txtCMNDNV.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            dtpNgaySinhNV.Text = string.Empty;
            txtMaNV.Enabled = true;
            btnThemMoiMaNV.Enabled = true;
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            dvDSNV.Table = Utils.ConvertListOjbectToDataTable(NVbus.Load_DSNV(), CONST.DSNV);
            dgvDSNSS.DataSource = dvDSNV;
        }

        private void btnTimKiemMaNV_Click(object sender, EventArgs e)
        {
            dvDSNV.RowFilter = CONST.TKMANV + txtMaNV.Text + CONST.DONG_NHAY_PHAN_TRAM;
            btnLamMoi_Click(sender, e);
        }

        private void btnTimKiemHoTenNV_Click(object sender, EventArgs e)
        {
            dvDSNV.RowFilter = CONST.TKTENNV + txtHoTenNV.Text + CONST.DONG_NHAY_PHAN_TRAM;
            btnLamMoi_Click(sender, e);
        }

        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSNSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
            txtMaNV.Enabled = false;
            btnThemMoiMaNV.Enabled = false;
            if (e.RowIndex == -CONST.MOT) { return; }
            if (dgvDSNSS.SelectedRows.Count > CONST.ZERO && e.RowIndex < dgvDSNSS.RowCount - CONST.MOT)
            {
                txtMaNV.Text = dgvDSNSS.SelectedRows[0].Cells[CONST.cMaNV].Value.ToString();
                txtHoTenNV.Text = dgvDSNSS.SelectedRows[0].Cells[CONST.cHOTEN].Value.ToString();
                dtpNgaySinhNV.Text = dgvDSNSS.SelectedRows[0].Cells[CONST.cNGAYSINH].Value.ToString();
                txtCMNDNV.Text = dgvDSNSS.SelectedRows[0].Cells[CONST.cCMND].Value.ToString();
                cbbChucVu.SelectedIndex = dgvDSNSS.SelectedRows[0].Cells[CONST.CHUCVU].Value.ToString().Equals(CONST.TRUE) ? 1 : 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtHoTenNV.Text) || string.IsNullOrEmpty(txtCMNDNV.Text))
            {
                MessageBox.Show(CONST.NHAPTTTHEM, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NHANVIEN_DTO themnv = new NHANVIEN_DTO
            {
                MANV = txtMaNV.Text,
                HOTEN = txtHoTenNV.Text,
                NGAYSINH = Convert.ToDateTime(dtpNgaySinhNV.Value.ToString(CONST.DINHDANGDATE)),
                CMND = txtCMNDNV.Text,
                CHUCVU = Convert.ToBoolean(cbbChucVu.SelectedIndex),
                XOA = false
            };
            if (NVbus.Them_NV(themnv))
            {
                MessageBox.Show(CONST.THEMTC, CONST.THONGBAO);
                frmQLNhanVien_Load(sender, e);
                btnLamMoi_Click(sender, e);
                return;
            }
            else
            {
                MessageBox.Show(CONST.THEMTB, CONST.THONGBAO);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show(CONST.NHAPTTXOA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dia = MessageBox.Show(CONST.TBXACNHANXOA, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
                return;
            }
            string manv = txtMaNV.Text;
            if (manv == MaNV)
            {
                MessageBox.Show(CONST.XOATB, CONST.THONGBAO);
                return;
            }
            if (NVbus.Xoa_NV(manv))
            {
                MessageBox.Show(CONST.XOATC, CONST.THONGBAO);
                frmQLNhanVien_Load(sender, e);
                btnLamMoi_Click(sender, e);
                return;
            }
            else
            {
                MessageBox.Show(CONST.XOATB, CONST.THONGBAO);
                return;
            }
        }

        private void txtCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoiMaNV_Click(object sender, EventArgs e)
        {
            int soluong = NVbus.SoLuong_NV()+1;
            txtMaNV.Text = String.Format(CONST.NV, soluong.ToString());
        }
    }
}
