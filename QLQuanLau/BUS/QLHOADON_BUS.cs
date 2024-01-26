using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QLHOADON_BUS
    {
        QLHOADON_DAO qlhdDAO= new QLHOADON_DAO();
        public List<HOADON_DTO> Load_DSHD()
        {
            return qlhdDAO.Load_DSHD();
        }
        public List<HOADON_DTO> Load_DSHD(DateTime date1, DateTime date2)
        {
            return qlhdDAO.Load_DSHD(date1, date2);
        }

        public List<BANAN_DTO> Load_DSBA()
        {
            return qlhdDAO.Load_DSBA();
        }
        public HOADON_DTO Load_1HD(string mahd)
        {
            return qlhdDAO.Load_1HD(mahd);
        }
        public List<MONAN_DTO> RP_dsmonan(bool loaimonan)
        {
            return qlhdDAO.RP_dsmonan(loaimonan);
        }
        public List<MONAN_DTO> RP_dsmonanALL(bool loaimonan)
        {
            return qlhdDAO.RP_dsmonanALL(loaimonan);
        }
        public List<CTHOADON_DTO> Load_DSCTHD(string mahd)
        {
            return qlhdDAO.Load_DSCTHD(mahd);
        }
        public bool KTThanhToan(string mahd)
        {
            return qlhdDAO.KTThanhToan(mahd);
        }
    }
}
