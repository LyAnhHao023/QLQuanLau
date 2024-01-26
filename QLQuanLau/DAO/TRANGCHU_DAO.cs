using System.Configuration;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAO;

namespace DAO
{
    public class TRANGCHU_DAO
    {
        QLQuanLauEntities1 qLQuanLauEntities1 = new QLQuanLauEntities1();

        public List<BANAN_DTO> LayDSBanAn()
        {
            return qLQuanLauEntities1.BANANs.Where(u => u.XOA == false).Select(v => new BANAN_DTO
            {
                MABAN = v.MABAN,
                TENBAN = v.TENBAN,
                COKHACH = v.COKHACH
            }).ToList();
        }

        public List<HOADON_DTO> LayHoaDonTheoBan(string mb)
        {
            return qLQuanLauEntities1.HOADONs.Where(u => u.MABAN == mb && u.THANHTOAN == false).Select(v => new HOADON_DTO
            {
                MAHD = v.MAHD,
                MABAN = v.MABAN,
                MANVLAPDON = v.MANVLAPDON,
                NGAYLAP = v.NGAYLAP,
                TONGTIEN = v.TONGTIEN,
                THANHTOAN = v.THANHTOAN
            }).ToList();
        }

        public List<CTHOADON_DTO> LayDSMonAnTheoBan(string mhd)
        {
            return qLQuanLauEntities1.CTHOADONs.Where(u => u.XOA == false && u.MAHD == mhd).Select(v => new CTHOADON_DTO
            {
                MAHD = v.MAHD,
                MAMONAN = v.MAMONAN,
                TENMON = v.TENMON,
                KICHTHUOC = v.KICHTHUOC,
                SOLUONG = v.SOLUONG,
                GIA = v.GIA,
                THANHTIEN = v.THANHTIEN
            }).ToList();
        }

        public List<MONAN_DTO> LayDSMonAn()
        {
            return qLQuanLauEntities1.MONANs.Where(u => u.XOA == false && u.TRANGTHAI == true).Select(v => new MONAN_DTO
            {
                MAMONAN = v.MAMONAN,
                TENMON = v.TENMON,
                GIA = v.GIA,
                KICHTHUOC = v.KICHTHUOC,
                SOLUONG = v.SOLUONG,
                LOAIMONAN = v.LOAIMONAN
            }).ToList();
        }

        public bool ThemHD(HOADON_DTO newHD)
        {
            try
            {
                HOADON hd = new HOADON
                {
                    MAHD = newHD.MAHD,
                    MABAN = newHD.MABAN,
                    MANVLAPDON = newHD.MANVLAPDON,
                    NGAYLAP = newHD.NGAYLAP,
                    TONGTIEN = newHD.TONGTIEN,
                    THANHTOAN = newHD.THANHTOAN
                };

                qLQuanLauEntities1.HOADONs.Add(hd);
                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChuyenBan(HOADON_DTO upHD) //Sửa hóa đơn
        {
            try
            {
                var hdEF = qLQuanLauEntities1.HOADONs.SingleOrDefault(u => u.MAHD == upHD.MAHD);

                SuaTrangTHaiBan(hdEF.MABAN);

                hdEF.MABAN = upHD.MABAN;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DaoBan(HOADON_DTO hd1, HOADON_DTO hd2) //Sửa hóa đơn
        {
            try
            {
                var hdEF1 = qLQuanLauEntities1.HOADONs.SingleOrDefault(u => u.MAHD == hd1.MAHD);

                var hdEF2 = qLQuanLauEntities1.HOADONs.SingleOrDefault(u => u.MAHD == hd2.MAHD);

                var temp = hdEF1.MABAN;

                hdEF1.MABAN = hdEF2.MABAN;

                hdEF2.MABAN = temp;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SuaTrangTHaiBan(string maBan)
        {
            var baEF = qLQuanLauEntities1.BANANs.SingleOrDefault(u => u.MABAN == maBan);

            baEF.COKHACH = false;

            qLQuanLauEntities1.SaveChanges();
        }

        public bool ThemCTHD(CTHOADON_DTO newCTHD)
        {
            try
            {
                var cthdEF = qLQuanLauEntities1.CTHOADONs.SingleOrDefault(u => u.MAHD == newCTHD.MAHD && u.MAMONAN == newCTHD.MAMONAN);

                if( cthdEF != null )
                {
                    if (cthdEF.XOA)
                    {
                        cthdEF.XOA = false;
                        cthdEF.SOLUONG = newCTHD.SOLUONG;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    CTHOADON cthd = new CTHOADON
                    {
                        MAHD = newCTHD.MAHD,
                        GIA = newCTHD.GIA,
                        KICHTHUOC = newCTHD.KICHTHUOC,
                        MAMONAN = newCTHD.MAMONAN,
                        SOLUONG = newCTHD.SOLUONG,
                        TENMON = newCTHD.TENMON,
                        THANHTIEN = newCTHD.THANHTIEN,
                        XOA = false
                    };

                    qLQuanLauEntities1.CTHOADONs.Add(cthd);
                }

                qLQuanLauEntities1.SaveChanges();

                ThayDoiSoLuong(newCTHD.MAMONAN, newCTHD.SOLUONG);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaCTHD(CTHOADON_DTO upCTHD)
        {
            try
            {
                var cthdEF = qLQuanLauEntities1.CTHOADONs.SingleOrDefault(u => u.MAHD == upCTHD.MAHD && u.MAMONAN == upCTHD.MAMONAN);

                ThayDoiSoLuong(cthdEF.MAMONAN, upCTHD.SOLUONG - cthdEF.SOLUONG);

                cthdEF.SOLUONG = upCTHD.SOLUONG;
                cthdEF.KICHTHUOC = upCTHD.KICHTHUOC;
                cthdEF.GIA = upCTHD.GIA;
                cthdEF.MAMONAN = upCTHD.MAMONAN;
                cthdEF.THANHTIEN = upCTHD.THANHTIEN;
                cthdEF.TENMON = upCTHD.TENMON;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaCTHD(CTHOADON_DTO delCTHD)
        {
            try
            {
                var cthdEF = qLQuanLauEntities1.CTHOADONs.SingleOrDefault(u => u.MAHD == delCTHD.MAHD && u.MAMONAN == delCTHD.MAMONAN);

                ThayDoiSoLuong(cthdEF.MAMONAN, -cthdEF.SOLUONG);

                cthdEF.XOA = true;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ThayDoiSoLuong(string ma, int sl)
        {
            var maEF = qLQuanLauEntities1.MONANs.SingleOrDefault(u => u.MAMONAN == ma);

            maEF.SOLUONG -= sl;
            maEF.TRANGTHAI = maEF.SOLUONG > 0 ? true : false;

            qLQuanLauEntities1.SaveChanges();
        }

        public bool ThanhToan(HOADON_DTO hd)
        {
            try
            {
                var hdEF = qLQuanLauEntities1.HOADONs.SingleOrDefault(u => u.MAHD == hd.MAHD);

                hdEF.TONGTIEN = hd.TONGTIEN;
                hdEF.THANHTOAN = hd.THANHTOAN;

                qLQuanLauEntities1.SaveChanges();

                SuaTrangTHaiBan(hdEF.MABAN);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int DemSLHoaDon()
        {
            return qLQuanLauEntities1.HOADONs.Select(v => new HOADON_DTO
            {
                MAHD = v.MAHD,
                MABAN = v.MABAN,
                MANVLAPDON = v.MANVLAPDON,
                NGAYLAP = v.NGAYLAP,
                TONGTIEN = v.TONGTIEN,
                THANHTOAN = v.THANHTOAN
            }).Count();
        }

        public bool LoadTrangThaiBanAn(string maba, bool thanhtoan)
        {
            try
            {
                var baEF = qLQuanLauEntities1.BANANs.SingleOrDefault(u => u.MABAN == maba && u.XOA == false);

                baEF.COKHACH = thanhtoan ? false : true;

                qLQuanLauEntities1.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool HDCoTonTai(string maHD)
        {
            var hdEF = qLQuanLauEntities1.HOADONs.SingleOrDefault(u => u.MAHD == maHD);

            return hdEF != null;
        }

        public bool KTBanConTrong(string mb)
        {
            var hdEF = qLQuanLauEntities1.BANANs.SingleOrDefault(u => u.MABAN == mb && u.COKHACH == false);

            return hdEF != null;
        }
    }
}
