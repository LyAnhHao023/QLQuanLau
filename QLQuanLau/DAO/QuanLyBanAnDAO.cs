using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyBanAnDAO
    {
        QLQuanLauEntities1 QLQL = new QLQuanLauEntities1();

        public List<BANAN_DTO> LayDSBanAn()
        {
            var lst = QLQL.BANANs.ToList();

            return lst.Where(v => v.XOA == false).Select(u => new BANAN_DTO
            {
                TENBAN = u.TENBAN,
                MABAN = u.MABAN,
                TRANGTHAITXT = u.COKHACH ? "Đã có khách" : "Trống",
                COKHACH = u.COKHACH,
                XOA = u.XOA
            }).ToList();
        }
        public bool ThemBanAn(BANAN_DTO newBanAn)
        {
            try
            {
                BANAN BanAnEF = new BANAN
                {
                    TENBAN = newBanAn.TENBAN,
                    MABAN = newBanAn.MABAN,
                    COKHACH = newBanAn.COKHACH,
                    XOA = newBanAn.XOA
                };

                QLQL.BANANs.Add(BanAnEF);
                QLQL.SaveChanges();

                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool IsExisted(BANAN_DTO newBanAn)
        {
            var BanAnEF = QLQL.BANANs.SingleOrDefault(u => u.MABAN == newBanAn.MABAN);

            return BanAnEF != null;
        }
        public bool XoaBan(BANAN_DTO XoaBANAN)
        {
            try
            {
                BANAN XoaBanan = QLQL.BANANs.SingleOrDefault(u => u.MABAN == XoaBANAN.MABAN && u.COKHACH == false);
                if(XoaBanan == null)
                {
                    return false;
                }

                XoaBanan.XOA = true;
                QLQL.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaBanAn(BANAN_DTO SuaBanAn)
        {
            try
            {
                BANAN b = QLQL.BANANs.SingleOrDefault(u => u.MABAN == SuaBanAn.MABAN);
                b.TENBAN = SuaBanAn.TENBAN;

                QLQL.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
