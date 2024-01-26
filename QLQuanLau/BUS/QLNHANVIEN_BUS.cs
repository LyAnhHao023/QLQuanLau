using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QLNHANVIEN_BUS
    {
        QLNHANVIEN_DAO NVdao= new QLNHANVIEN_DAO();
        public List<NHANVIEN_DTO> Load_DSNV()
        {
            return NVdao.Load_DSNV();
        }
        public List<NHANVIEN_DTO> rp_dsnv()
        {
            return NVdao.rp_dsnv();
        }
        public List<NHANVIEN_DTO> rp_dsnvALL()
        {
            return NVdao.rp_dsnvALL();
        }
        public bool Them_NV(NHANVIEN_DTO themNV)
        {
            if(NVdao.IsExist(themNV)) { return false; }
            return NVdao.Them_NV(themNV);
        }
        public bool Xoa_NV(string manv)
        {
            return NVdao.Xoa_NV(manv);
        }
        public bool Sua_NV(NHANVIEN_DTO suaNV)
        {
            return NVdao.Sua_NV(suaNV);
        }
        public int SoLuong_NV()
        {
            return NVdao.SoLuong_NV();
        }
    }
}
