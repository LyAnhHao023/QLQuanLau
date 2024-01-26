using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QLNHANVIEN_DAO
    {
        QLQuanLauEntities1 quanLauEntities=new QLQuanLauEntities1();

        public List<NHANVIEN_DTO> Load_DSNV()
        {
            return quanLauEntities.NHANVIENs.Where(o=>o.XOA==false).Select(v=>new NHANVIEN_DTO
            {
                MANV=v.MANV,
                HOTEN=v.HOTEN,
                NGAYSINH=v.NGAYSINH,
                CMND=v.CMND,
                TENCHUCVU = v.CHUCVU ?"Boss":"Nhân viên",
                CHUCVU=v.CHUCVU,
                XOA=v.XOA,
            }).ToList();
        }

        public List<NHANVIEN_DTO> rp_dsnvALL()
        {
            return quanLauEntities.NHANVIENs.OrderBy(u => u.XOA).Select(v => new NHANVIEN_DTO
            {
                MANV = v.MANV,
                HOTEN = v.HOTEN,
                NGAYSINH = v.NGAYSINH,
                CMND = v.CMND,
                TENCHUCVU = v.CHUCVU ? "Boss" : "Nhân viên",
                CHUCVU = v.CHUCVU,
                XOA = v.XOA,
                XOATXT = v.XOA ? "Đã thôi việc" : "Còn làm việc"
            }).ToList();
        }
        public List<NHANVIEN_DTO> rp_dsnv()
        {
            return quanLauEntities.NHANVIENs.OrderBy(u=>u.XOA).Where(o=>o.XOA==false).Select(v => new NHANVIEN_DTO
            {
                MANV = v.MANV,
                HOTEN = v.HOTEN,
                NGAYSINH = v.NGAYSINH,
                CMND = v.CMND,
                TENCHUCVU = v.CHUCVU ? "Boss" : "Nhân viên",
                CHUCVU = v.CHUCVU,
                XOA = v.XOA,
                XOATXT= v.XOA ?"Đã thôi việc":"Còn làm việc"
            }).ToList();
        }

        public bool Them_NV(NHANVIEN_DTO themNV)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN
                {
                    MANV = themNV.MANV,
                    HOTEN = themNV.HOTEN,
                    NGAYSINH = themNV.NGAYSINH,
                    CMND = themNV.CMND,
                    CHUCVU = themNV.CHUCVU,
                    XOA = false
                };
                quanLauEntities.NHANVIENs.Add(nv);
                if (quanLauEntities.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool IsExist(NHANVIEN_DTO themNV)
        {
            NHANVIEN nv=quanLauEntities.NHANVIENs.SingleOrDefault(u=>u.CMND==themNV.CMND);
            return nv!=null;
        }

        public bool Sua_NV(NHANVIEN_DTO suaNV)
        {
            try
            {
                NHANVIEN nv =quanLauEntities.NHANVIENs.SingleOrDefault(u=>u.MANV==suaNV.MANV);
                if(nv==null)
                {
                    return false;
                }
                nv.CMND = suaNV.CMND;
                nv.CHUCVU = suaNV.CHUCVU;
                nv.HOTEN = suaNV.HOTEN;
                nv.NGAYSINH= suaNV.NGAYSINH;
                if (quanLauEntities.SaveChanges() > 0)
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
        public bool Xoa_NV(string manv)
        {
            try
            {
                NHANVIEN nv = quanLauEntities.NHANVIENs.SingleOrDefault(u => u.MANV == manv);
                if (nv == null)
                {
                    return false;
                }
                nv.XOA = true;
                if (quanLauEntities.SaveChanges() > 0)
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
        public int SoLuong_NV()
        {
            return quanLauEntities.NHANVIENs.Select(u => new NHANVIEN_DTO {
                MANV=u.MANV 
            }).Count();
        }
    }
}
