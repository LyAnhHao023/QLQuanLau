using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QLHOADON_DAO
    {
        QLQuanLauEntities1 quanLauEntities= new QLQuanLauEntities1();

        public List<CTHOADON_DTO> Load_DSCTHD(string mahd)
        {
            return quanLauEntities.CTHOADONs.Where(u => u.MAHD.Equals(mahd) && u.XOA == false).Select(o => new CTHOADON_DTO
            {
                MAHD = o.MAHD,
                MAMONAN = o.MAMONAN,
                TENMON = o.TENMON,
                SOLUONG = o.SOLUONG,
                GIA = o.GIA,
                THANHTIEN = o.THANHTIEN,
                KICHTHUOC = o.KICHTHUOC,
                TENKICHTHUOC = o.KICHTHUOC ? "Cỡ thường" : "Cỡ nhỏ",
                XOA = o.XOA,

            }).ToList();
        }
        public List<HOADON_DTO> Load_DSHD(DateTime date1,DateTime date2)
        {
            return quanLauEntities.HOADONs.Where(u=>u.NGAYLAP>=date1 && u.NGAYLAP<=date2&&u.THANHTOAN==true).Select(o => new HOADON_DTO
            {
                MAHD = o.MAHD,
                NGAYLAP = o.NGAYLAP,
                MANVLAPDON = o.MANVLAPDON,
                MABAN = o.MABAN,
                TONGTIEN = o.TONGTIEN,
                THANHTOAN = o.THANHTOAN,
                TENBAN = o.BANAN.TENBAN,
                TINHTRANG = o.THANHTOAN ? "Đã thanh toán" : "Chưa thanh toán",
                TENNV = o.NHANVIEN.HOTEN
            }).ToList();
        }
        public List<HOADON_DTO> Load_DSHD()
        {
            return quanLauEntities.HOADONs.Select(o => new HOADON_DTO
            {
                MAHD = o.MAHD,
                NGAYLAP =o.NGAYLAP,
                MANVLAPDON = o.MANVLAPDON,
                MABAN = o.MABAN,
                TONGTIEN = o.TONGTIEN,
                THANHTOAN = o.THANHTOAN,
                TENBAN = o.BANAN.TENBAN,
                TINHTRANG=o.THANHTOAN ?"Đã thanh toán":"Chưa thanh toán",
                TENNV=o.NHANVIEN.HOTEN
            }).ToList();
        }

        public HOADON_DTO Load_1HD(string mahd)
        {
            HOADON hdEn=quanLauEntities.HOADONs.SingleOrDefault(u=>u.MAHD.Equals(mahd));
            HOADON_DTO hdDTO = new HOADON_DTO
            {
                MAHD = hdEn.MAHD,
                NGAYLAP = hdEn.NGAYLAP,
                MANVLAPDON = hdEn.MANVLAPDON,
                MABAN = hdEn.MABAN,
                TONGTIEN = hdEn.TONGTIEN,
                THANHTOAN = hdEn.THANHTOAN,
                TENBAN = hdEn.BANAN.TENBAN,
                TINHTRANG = hdEn.THANHTOAN ? "Đã thanh toán" : "Chưa thanh toán",
                TENNV = hdEn.NHANVIEN.HOTEN
            };
            return hdDTO;
        }
        public List<BANAN_DTO> Load_DSBA()
        {
            return quanLauEntities.BANANs.Where(u => u.XOA == false).Select(v => new BANAN_DTO
            {
                MABAN = v.MABAN,
                TENBAN = v.TENBAN,
                COKHACH = v.COKHACH
            }).ToList();
        }
        public List<MONAN_DTO> RP_dsmonanALL(bool loaimonan)
        {
            return quanLauEntities.MONANs.OrderBy(u => u.XOA).Where(x => x.LOAIMONAN == loaimonan).Select(o => new MONAN_DTO
            {
                MAMONAN = o.MAMONAN,
                TENMON = o.TENMON,
                LOAIMONAN = o.LOAIMONAN,
                KICHTHUOC = o.KICHTHUOC,
                KICHTHUOCTXT = o.KICHTHUOC ? "Cỡ thường" : "Cỡ nhỏ",
                SOLUONG = o.SOLUONG,
                GIA = o.GIA,
                TRANGTHAI = o.TRANGTHAI,
                TRANGTHAITXT = o.TRANGTHAI ? "Còn hàng" : "Hết hàng",
                XOATXT = o.XOA ? "Ngừng kinh doanh" : "Còn kinh doanh",
                XOA = o.XOA
            }).ToList();
        }
        public List<MONAN_DTO> RP_dsmonan(bool loaimonan)
        {
            return quanLauEntities.MONANs.OrderBy(u => u.XOA).Where(x => x.LOAIMONAN == loaimonan && x.XOA == false).Select(o => new MONAN_DTO
            {
                MAMONAN = o.MAMONAN,
                TENMON = o.TENMON,
                LOAIMONAN = o.LOAIMONAN,
                KICHTHUOC = o.KICHTHUOC,
                SOLUONG = o.SOLUONG,
                GIA = o.GIA,
                TRANGTHAI = o.TRANGTHAI,
                TRANGTHAITXT = o.TRANGTHAI ? "Còn hàng" : "Hết hàng",
                XOATXT = o.XOA ? "Ngừng kinh doanh" : "Còn kinh doanh",
                XOA = o.XOA
            }).ToList();
        }
        public bool KTThanhToan(string mahd)
        {
            var hdEF = quanLauEntities.HOADONs.SingleOrDefault(u => u.MAHD == mahd && u.THANHTOAN == true);

            return hdEF != null;
        }
    }
}
