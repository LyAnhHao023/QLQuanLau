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
    public partial class frmBaoCaoVaThongKe : Form
    {
        public frmBaoCaoVaThongKe()
        {
            InitializeComponent();
            radSanPham.Checked = true;
            cbbSanPham.SelectedIndex = CONST.ZERO;
            cbbNhanVien.SelectedIndex = CONST.ZERO;
        }

        private void btnQuayLaiTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (radHoaDon.Checked)
            {
                frmBaoCao frmRP = new frmBaoCao(dtpTuNgay.Value, dtpDenNgay.Value);
                frmRP.ShowDialog();
            }
            else if (radSanPham.Checked)
            {
                frmBaoCao frmRP = new frmBaoCao(CONST.BA, cbbSanPham.SelectedIndex);
                frmRP.ShowDialog();
            }
            else if (radNhanVien.Checked)
            {
                frmBaoCao frmRP = new frmBaoCao(CONST.BON, cbbNhanVien.SelectedIndex);
                frmRP.ShowDialog();
            }
        }
    }
}
