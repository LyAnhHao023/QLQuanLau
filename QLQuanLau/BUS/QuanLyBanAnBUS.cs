using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyBanAnBUS
    {
        QuanLyBanAnDAO BanAnDAO = new QuanLyBanAnDAO();

        public List<BANAN_DTO> LayDSBanAn()
        {
            return BanAnDAO.LayDSBanAn();
        }
        public bool ThemBanAn(BANAN_DTO newBanAn)
        {
            if (BanAnDAO.IsExisted(newBanAn)) return false;

            return BanAnDAO.ThemBanAn(newBanAn);
        }
        public bool Xoa(BANAN_DTO XoaBanAn)
        {
            return BanAnDAO.XoaBan(XoaBanAn);
        }
        public bool Sua(BANAN_DTO SuaBanAn)
        {
            return BanAnDAO.SuaBanAn(SuaBanAn);
        }
    }
}
