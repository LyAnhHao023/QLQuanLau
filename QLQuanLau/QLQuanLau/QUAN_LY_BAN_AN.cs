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
    public partial class frmQLBanAn : Form
    {
        QuanLyBanAnBUS BanAnBUS = new QuanLyBanAnBUS();
        DataView dvBanAn = new DataView();
        public frmQLBanAn()
        {
            InitializeComponent();
            dgvQuanLyBanAn.AutoGenerateColumns = false;
        }
        private void load_DSBanAn()
        {
            dvBanAn.Table = Utils.ConvertListOjbectToDataTable(BanAnBUS.LayDSBanAn(), CONST.DSBA);
            dgvQuanLyBanAn.DataSource = dvBanAn;
        }
        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLBanAn_Load(object sender, EventArgs e)
        {
            load_DSBanAn();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBan.ResetText();
            txtTenBan.ResetText();
            load_DSBanAn();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text) || string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show(CONST.NHAPTTTHEM, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BANAN_DTO newBanAn = new BANAN_DTO
            {
                TENBAN = txtTenBan.Text,
                MABAN = txtMaBan.Text,
                COKHACH = false,
                XOA = false
            };

            if (BanAnBUS.ThemBanAn(newBanAn))
            {
                MessageBox.Show(CONST.THEMTC,CONST.THONGBAO);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.THEMTB,CONST.THONGBAO);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show(CONST.NHAPTTXOA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(dgvQuanLyBanAn.SelectedRows.Count == CONST.ZERO)
            {
                MessageBox.Show(CONST.CHONBANXOA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dia = MessageBox.Show(CONST.TBXACNHANXOA, CONST.THONGBAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
                return;
            }

            BANAN_DTO DelBanAn = new BANAN_DTO
            {
                MABAN = dgvQuanLyBanAn.SelectedRows[CONST.ZERO].Cells[CONST.colMaBan].Value.ToString(),
                COKHACH = (bool)dgvQuanLyBanAn.SelectedRows[CONST.ZERO].Cells[CONST.colCOKHACH].Value
            };

            if (BanAnBUS.Xoa(DelBanAn))
            {
                MessageBox.Show(CONST.XOATC,CONST.THONGBAO);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.XOATB,CONST.THONGBAO);
            }
        }

        private void dgvQuanLyBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyBanAn.SelectedRows.Count > CONST.ZERO)
            {
                txtMaBan.Text = dgvQuanLyBanAn.SelectedRows[CONST.ZERO].Cells[CONST.colMaBan].Value?.ToString();
                txtTenBan.Text = dgvQuanLyBanAn.SelectedRows[CONST.ZERO].Cells[CONST.colTenBan].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text) || string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show(CONST.NHAPTTSUA, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BANAN_DTO SuaBanAn = new BANAN_DTO
            {
                MABAN = txtMaBan.Text,
                TENBAN = txtTenBan.Text,
            };

            if (BanAnBUS.Sua(SuaBanAn))
            {
                MessageBox.Show(CONST.SUATC,CONST.THONGBAO);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.SUATB, CONST.THONGBAO);
            }
        }

        private void btnTimKiemMaBan_Click(object sender, EventArgs e)
        {
                dvBanAn.RowFilter = CONST.TKMABAN + txtMaBan.Text + CONST.DONG_NHAY_PHAN_TRAM;
        }

        private void btnTimKiemTenBan_Click(object sender, EventArgs e)
        {
                dvBanAn.RowFilter = CONST.TKTENBAN + txtTenBan.Text + CONST.DONG_NHAY_PHAN_TRAM;
        }
    }
}
