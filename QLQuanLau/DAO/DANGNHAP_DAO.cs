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
    public class DANGNHAP_DAO
    {
        QLQuanLauEntities1 qLQuanLauEntities1 = new QLQuanLauEntities1();
        public List<NHANVIEN_DTO> LayThongTinTK(string maNV)
        {
            return qLQuanLauEntities1.NHANVIENs.Where(u => u.XOA == false && u.MANV == maNV).Select(v => new NHANVIEN_DTO
            {
                MANV = v.MANV,
                CHUCVU = v.CHUCVU,
                CMND = v.CMND,
                HOTEN = v.HOTEN,
                NGAYSINH = v.NGAYSINH
            }).ToList();
        }

        public List<TAIKHOAN_DTO> DangNhap(TAIKHOAN_DTO tk)
        {
            var tkEF = qLQuanLauEntities1.TAIKHOANs.Where(u => u.XOA == false && u.TENDANGNHAP == tk.TENDANGNHAP && u.MATKHAU == tk.MATKHAU).Select(v => new TAIKHOAN_DTO
            {
                TENDANGNHAP = v.TENDANGNHAP,
                MATKHAU = v.MATKHAU,
                MANV = v.MANV
            }).ToList();

            return tkEF;
        }
    }
}
