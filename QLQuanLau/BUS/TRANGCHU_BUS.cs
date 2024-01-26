using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TRANGCHU_BUS
    {
        TRANGCHU_DAO trangchuDAO = new TRANGCHU_DAO();
        public List<MONAN_DTO> LayDSMonAn()
        {
            return trangchuDAO.LayDSMonAn();
        }

        public List<HOADON_DTO> LayHoaDonTheoBan(string mb)
        {
            return trangchuDAO.LayHoaDonTheoBan(mb);
        }

        public List<CTHOADON_DTO> LayDSMonAnTheoBan(string mhd)
        {
            return trangchuDAO.LayDSMonAnTheoBan(mhd);
        }

        public List<BANAN_DTO> LayDSBanAn()
        {
            return trangchuDAO.LayDSBanAn();
        }

        public bool ThemHD(HOADON_DTO newHD)
        {
            return trangchuDAO.ThemHD(newHD);
        }

        public bool ChuyenBan(HOADON_DTO upHD)
        {
            return trangchuDAO.ChuyenBan(upHD);
        }

        public bool DaoBan(HOADON_DTO hd1, HOADON_DTO hd2)
        {
            return trangchuDAO.DaoBan(hd1, hd2);
        }

        public bool ThemCTHD(CTHOADON_DTO newCTHD)
        {
            return trangchuDAO.ThemCTHD(newCTHD);
        }

        public bool SuaCTHD(CTHOADON_DTO upCTHD)
        {
            return trangchuDAO.SuaCTHD(upCTHD);
        }

        public bool XoaCTHD(CTHOADON_DTO delCTHD)
        {
            return trangchuDAO.XoaCTHD(delCTHD);
        }

        public bool ThanhToan(HOADON_DTO hd)
        {
            return trangchuDAO.ThanhToan(hd);
        }

        public int DemSLHoaDon()
        {
            return trangchuDAO.DemSLHoaDon();
        }

        public bool LoadTrangThaiBanAn(string maba, bool thanhtoan)
        {
            return trangchuDAO.LoadTrangThaiBanAn(maba, thanhtoan);
        }

        public bool HDCoTonTai(string maHD)
        {
            return trangchuDAO.HDCoTonTai(maHD);
        }

        public bool KTBanConTrong(string mb)
        {
            return trangchuDAO.KTBanConTrong(mb);
        }
    }
}
