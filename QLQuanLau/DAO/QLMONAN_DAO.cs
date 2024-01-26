using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QLMONAN_DAO
    {
        QLQuanLauEntities1 qLQuanLauEntities1 = new QLQuanLauEntities1();
        public List<MONAN_DTO> LayDSMonAn()
        {
            return qLQuanLauEntities1.MONANs.Where(u => u.XOA == false).Select(v => new MONAN_DTO
            {
                MAMONAN = v.MAMONAN,
                TENMON = v.TENMON,
                GIA = v.GIA,
                KICHTHUOC = v.KICHTHUOC,
                KICHTHUOCTXT = v.KICHTHUOC ? "Bình thường" : "Nhỏ",
                SOLUONG = v.SOLUONG,
                TRANGTHAI = v.TRANGTHAI,
                TRANGTHAITXT = v.TRANGTHAI ? "Còn hàng" : "Hết hàng",
                LOAIMONAN = v.LOAIMONAN
            }).ToList();
        }

        public bool ThemMonAn(MONAN_DTO newMA)
        {
            try
            {
                MONAN maEF = new MONAN
                {
                    MAMONAN = newMA.MAMONAN,
                    TENMON = newMA.TENMON,
                    GIA = newMA.GIA,
                    KICHTHUOC = newMA.KICHTHUOC,
                    SOLUONG = newMA.SOLUONG,
                    TRANGTHAI = newMA.TRANGTHAI,
                    LOAIMONAN = newMA.LOAIMONAN,
                    XOA = false
                };

                qLQuanLauEntities1.MONANs.Add(maEF);
                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaMonAn(MONAN_DTO updMA)
        {
            try
            {
                var maEF = qLQuanLauEntities1.MONANs.SingleOrDefault(u => u.MAMONAN == updMA.MAMONAN);

                maEF.TENMON = updMA.TENMON;
                maEF.SOLUONG = updMA.SOLUONG;
                maEF.KICHTHUOC = updMA.KICHTHUOC;
                maEF.GIA = updMA.GIA;
                maEF.TRANGTHAI = updMA.SOLUONG > 0 ? true : false;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaMonAn(MONAN_DTO delMA)
        {
            try
            {
                var maEF = qLQuanLauEntities1.MONANs.SingleOrDefault(u => u.MAMONAN == delMA.MAMONAN);

                maEF.XOA = true;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CoTonTai(MONAN_DTO ma)
        {
            var maEF = qLQuanLauEntities1.MONANs.SingleOrDefault(u => u.MAMONAN == ma.MAMONAN);

            return maEF != null;
        }

        public bool TenDaTonTai(MONAN_DTO ma)
        {
            var maEF = qLQuanLauEntities1.MONANs.SingleOrDefault(u => u.TENMON == ma.TENMON && u.KICHTHUOC == ma.KICHTHUOC && u.XOA == false);

            return maEF != null;
        }

        public bool MonAnDaTonTai(MONAN_DTO ma)
        {
            var maEF = qLQuanLauEntities1.MONANs.SingleOrDefault(u => u.MAMONAN == ma.MAMONAN && u.TENMON == ma.TENMON && u.KICHTHUOC == ma.KICHTHUOC && u.XOA == false);

            return maEF != null;
        }

        public int SoLuongML()
        {
            return qLQuanLauEntities1.MONANs.Where(u => u.LOAIMONAN == true).Select(v => new MONAN_DTO
            {
                MAMONAN = v.MAMONAN
            }).ToList().Count;
        }

        public int SoLuongMK()
        {
            return qLQuanLauEntities1.MONANs.Where(u => u.LOAIMONAN == false).Select(v => new MONAN_DTO
            {
                MAMONAN = v.MAMONAN
            }).ToList().Count;
        }
    }
}
