using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyTaiKhoanBUS
    {
        QuanLyTaiKhoanDAO TKDAO = new QuanLyTaiKhoanDAO();

        public List<TAIKHOAN_DTO> LayDSTaiKhoan()
        {
            return TKDAO.LayDSTaiKhoan();
        }
        public bool ThemTK(TAIKHOAN_DTO newTK)
        {
            if (TKDAO.KTNV(newTK) || TKDAO.KTTenTK(newTK))
                return false;

            return TKDAO.ThemTK(newTK);
        }
        public bool Xoa(TAIKHOAN_DTO XoaTK, string MaNV)
        {
            return TKDAO.XoaTaiKhoan(XoaTK, MaNV);
        }
        public bool Sua(TAIKHOAN_DTO SuaTK)
        {
            return TKDAO.SuaTK(SuaTK);
        }
    }
}
