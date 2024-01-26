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
using System.Collections;
using System.Reflection;

namespace QLQuanLau
{
    public partial class frmQuanLyHoaDon : Form
    {
        QLHOADON_BUS hdBUS = new QLHOADON_BUS();
        DataView dvDSHD = new DataView();
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            dgvHoaDon.AutoGenerateColumns = false;
            radTimTatCa.Checked = true;
            cbbTimTRANGTHAI.SelectedIndex = 0;
        }

        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dvDSHD.Table = Utils.ConvertListOjbectToDataTable(hdBUS.Load_DSHD(), CONST.DSHD);
            dgvHoaDon.DataSource = dvDSHD;
            cbbTimMABAN.DataSource = hdBUS.Load_DSBA();
            cbbTimMABAN.ValueMember = CONST.MABAN;
            cbbTimMABAN.DisplayMember = CONST.TENBAN;
        }

        public string Return_MaHD()
        {
            return dgvHoaDon.SelectedCells[0].Value.ToString();
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == dgvHoaDon.Rows.Count - 1) return;
            if (e.ColumnIndex > -1)
            {
                frmChiTietHoaDon cthd = new frmChiTietHoaDon(this.Return_MaHD());
                cthd.ShowDialog();
                this.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radTimTatCa.Checked) { dvDSHD.RowFilter = CONST.TRONG; }
            if (radTimMAHD.Checked) { dvDSHD.RowFilter = CONST.TKMAHD + txtTimMAHD.Text + CONST.DONG_NHAY_PHAN_TRAM; }
            if (radTimNgayLap.Checked) { dvDSHD.RowFilter = CONST.TKNGAYLAP1 + dtpTimNgayLap.Value.ToString(CONST.DINHDANGDATE1) + CONST.AM + CONST.DAUTHANG + CONST.AND + CONST.TKNGAYLAP2 + dtpTimNgayLap.Value.ToString(CONST.DINHDANGDATE2) + CONST.PM + CONST.DAUTHANG; }
            if (radTimMANVLAPDON.Checked) { dvDSHD.RowFilter = CONST.TKMANVLAPDON + txtTimMANV.Text + CONST.DONG_NHAY_PHAN_TRAM; }
            if (radTimMABAN.Checked) { dvDSHD.RowFilter = CONST.TKMABAN + cbbTimMABAN.SelectedValue + CONST.DONG_NHAY_PHAN_TRAM; }
            if (radTimTHANHTOAN.Checked) { dvDSHD.RowFilter = CONST.THANHTOAN + CONST.DAUBANG + cbbTimTRANGTHAI.SelectedIndex.ToString() + CONST.TRONG; }
        }
    }
}
