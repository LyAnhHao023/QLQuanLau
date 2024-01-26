using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QuanLyTaiKhoanDAO
    {
        QLQuanLauEntities1 QLQL = new QLQuanLauEntities1();

        public List<TAIKHOAN_DTO> LayDSTaiKhoan()
        {
            var lst = QLQL.TAIKHOANs.ToList();

            return lst.Where(v => v.XOA == false).Select(u => new TAIKHOAN_DTO
            {
                TENDANGNHAP = u.TENDANGNHAP,
                MATKHAU = u.MATKHAU,
                MANV = u.MANV,
            }).ToList();
        }
        public bool ThemTK(TAIKHOAN_DTO newTK)
        {
            try
            {
                TAIKHOAN TKEF = new TAIKHOAN
                {
                    TENDANGNHAP = newTK.TENDANGNHAP,
                    MATKHAU = newTK.MATKHAU,
                    MANV = newTK.MANV,
                    XOA = newTK.XOA,
                };
                QLQL.TAIKHOANs.Add(TKEF);
                var lst = QLQL.TAIKHOANs.ToList();
                QLQL.SaveChanges();

                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool IsExisted(TAIKHOAN_DTO newTK)
        {
            var TKEF = QLQL.TAIKHOANs.SingleOrDefault(u => u.MANV == newTK.MANV && u.TENDANGNHAP == newTK.TENDANGNHAP);

            return TKEF != null;
        }
        public bool KTTenTK(TAIKHOAN_DTO tk)
        {
            var TKEF = QLQL.TAIKHOANs.SingleOrDefault(u => u.TENDANGNHAP == tk.TENDANGNHAP);

            return TKEF != null;
        }
        public bool KTNV(TAIKHOAN_DTO tk)
        {
            var TKEF = QLQL.TAIKHOANs.SingleOrDefault(u => u.MANV == tk.MANV);

            return TKEF != null;
        }
        public  bool XoaTaiKhoan(TAIKHOAN_DTO XoaTK, string MaNV)
        {
            try
            {
                TAIKHOAN XoaTk = QLQL.TAIKHOANs.SingleOrDefault(u => u.TENDANGNHAP == XoaTK.TENDANGNHAP && u.MANV != MaNV);
                if(XoaTk == null) return false;
                XoaTk.XOA = true;
                QLQL.SaveChanges();
                return true;
            }
            catch (Exception) 
            { 
                return false; 
            } 
        }
        public bool SuaTK(TAIKHOAN_DTO SuaTK)
        {
            try
            {
                TAIKHOAN a = QLQL.TAIKHOANs.SingleOrDefault(u => u.TENDANGNHAP == SuaTK.TENDANGNHAP);
                a.MATKHAU = SuaTK.MATKHAU;

                if(QLQL.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
