using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DANGNHAP_BUS
    {
        DANGNHAP_DAO _dangnhapDAO = new DANGNHAP_DAO();

        public List<NHANVIEN_DTO> LayThongTinTK(string maNV)
        {
            return _dangnhapDAO.LayThongTinTK(maNV);
        }

        public List<TAIKHOAN_DTO> DangNhap(TAIKHOAN_DTO tk)
        {
            return _dangnhapDAO.DangNhap(tk);
        }
    }
}
