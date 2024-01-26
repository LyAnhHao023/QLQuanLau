using Microsoft.Reporting.WinForms;
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
using System.Reflection;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace QLQuanLau
{
    public partial class frmBaoCao : Form
    {
        QLHOADON_BUS HDbus = new QLHOADON_BUS();
        QLHOADON_BUS CTHDbus = new QLHOADON_BUS();
        QLHOADON_BUS MONANbus = new QLHOADON_BUS();
        QLNHANVIEN_BUS NVbus = new QLNHANVIEN_BUS();
        public int LoaiRP = CONST.MOT;
        public DateTime date1, date2;
        public string mahd;
        public int cbbindex = CONST.MOT;
        public frmBaoCao()
        {
            InitializeComponent();
        }

        public frmBaoCao(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.date1 = date1;
            this.date2 = date2;
            this.LoaiRP = CONST.MOT;
        }

        public frmBaoCao(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
            this.LoaiRP = CONST.HAI;
        }
        public frmBaoCao(int LoaiRP, int cbbindex)
        {
            InitializeComponent();
            this.LoaiRP = LoaiRP;
            this.cbbindex = cbbindex;
        }

        private void rpvBaoCao_Load(object sender, EventArgs e)
        {
            rpvBaoCao.SetDisplayMode(DisplayMode.PrintLayout);
            rpvBaoCao.ZoomMode = ZoomMode.PageWidth;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            if (LoaiRP == CONST.MOT)
            {
                rpvBaoCao.LocalReport.ReportPath = CONST.rp_TatCaHoaDon;
                var source = new ReportDataSource(CONST.DataSetHoaDonDTO, HDbus.Load_DSHD(date1, date2));
                ReportParameter[] par = new ReportParameter[CONST.HAI];
                par[CONST.ZERO] = new ReportParameter(CONST.parTuNgay, this.date1.ToString(CONST.DINHDANGDATE));
                par[CONST.MOT] = new ReportParameter(CONST.parDenNgay, this.date2.ToString(CONST.DINHDANGDATE));
                rpvBaoCao.LocalReport.DataSources.Clear();
                rpvBaoCao.LocalReport.SetParameters(par);
                rpvBaoCao.LocalReport.DataSources.Add(source);
                this.rpvBaoCao.RefreshReport();
            }
            else if (LoaiRP == CONST.HAI)
            {
                HOADON_DTO hd = HDbus.Load_1HD(this.mahd);
                rpvBaoCao.LocalReport.ReportPath = CONST.rp_HoaDonThanhToan;
                var source = new ReportDataSource(CONST.DataSetChiTietHoaDonDTO, CTHDbus.Load_DSCTHD(this.mahd));
                ReportParameter[] par = new ReportParameter[CONST.BON];
                par[CONST.ZERO] = new ReportParameter(CONST.parTenBan, hd.TENBAN);
                par[CONST.MOT] = new ReportParameter(CONST.parNgayLap, hd.NGAYLAP.ToString());
                par[CONST.HAI] = new ReportParameter(CONST.parMaHD, hd.MAHD);
                par[CONST.BA] = new ReportParameter(CONST.parTenNV, hd.TENNV);
                rpvBaoCao.LocalReport.DataSources.Clear();
                rpvBaoCao.LocalReport.SetParameters(par);
                rpvBaoCao.LocalReport.DataSources.Add(source);
                this.rpvBaoCao.RefreshReport();

            }
            else if (LoaiRP == CONST.BA)
            {
                if (cbbindex == CONST.ZERO)
                {
                    rpvBaoCao.LocalReport.ReportPath = CONST.rp_TatCaMonAn;
                    var source1 = new ReportDataSource(CONST.DataSetDSMonChinh, MONANbus.RP_dsmonanALL(true));
                    var source2 = new ReportDataSource(CONST.DataSetDSMonPhu, MONANbus.RP_dsmonanALL(false));
                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(source1);
                    rpvBaoCao.LocalReport.DataSources.Add(source2);
                    this.rpvBaoCao.RefreshReport();
                }
                else
                {
                    rpvBaoCao.LocalReport.ReportPath = CONST.rp_TatCaMonAn;
                    var source1 = new ReportDataSource(CONST.DataSetDSMonChinh, MONANbus.RP_dsmonan(true));
                    var source2 = new ReportDataSource(CONST.DataSetDSMonPhu, MONANbus.RP_dsmonan(false));
                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(source1);
                    rpvBaoCao.LocalReport.DataSources.Add(source2);
                    this.rpvBaoCao.RefreshReport();
                }
            }
            else if (LoaiRP == CONST.BON)
            {
                if (cbbindex == CONST.ZERO)
                {
                    rpvBaoCao.LocalReport.ReportPath = CONST.rp_TatCaNhanVien;
                    var source = new ReportDataSource(CONST.DataSetNhanVienDTO, NVbus.rp_dsnvALL());
                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(source);
                    this.rpvBaoCao.RefreshReport();
                }
                else
                {
                    rpvBaoCao.LocalReport.ReportPath = CONST.rp_TatCaNhanVien;
                    var source = new ReportDataSource(CONST.DataSetNhanVienDTO, NVbus.rp_dsnv());
                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(source);
                    this.rpvBaoCao.RefreshReport();
                }
            }
        }
    }
}
