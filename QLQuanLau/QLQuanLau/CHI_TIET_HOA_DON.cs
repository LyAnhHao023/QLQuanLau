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

namespace QLQuanLau
{
    public partial class frmChiTietHoaDon : Form
    {
        QLHOADON_BUS CTHDbus=new QLHOADON_BUS();
        string mahd;
        public frmChiTietHoaDon(string mahd)
        {
            InitializeComponent();
            dgvChiTietHoaDon.AutoGenerateColumns= false;
            this.mahd = mahd;
        }

        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = CTHDbus.Load_DSCTHD(mahd);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!CTHDbus.KTThanhToan(mahd))
            {
                MessageBox.Show(CONST.TBKHONGTHEIN, CONST.THONGBAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmBaoCao frmBaoCao= new frmBaoCao(this.mahd);
            frmBaoCao.ShowDialog();
        }
    }
}
