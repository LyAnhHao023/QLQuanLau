using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QLMONAN_BUS
    {
        QLMONAN_DAO _monanDAO = new QLMONAN_DAO();

        public List<MONAN_DTO> LayDSMonAn()
        {
            return _monanDAO.LayDSMonAn();
        }

        public bool ThemMonAn(MONAN_DTO newMA)
        {
            if (_monanDAO.CoTonTai(newMA)) return false;

            return _monanDAO.ThemMonAn(newMA);
        }

        public bool SuaMonAn(MONAN_DTO updMA)
        {
            if (_monanDAO.CoTonTai(updMA)) return _monanDAO.SuaMonAn(updMA);

            return false;
        }

        public bool XoaMonAn(MONAN_DTO delMA)
        {
            if (_monanDAO.CoTonTai(delMA)) return _monanDAO.XoaMonAn(delMA);

            return false;
        }

        public bool TenDaTonTai(MONAN_DTO ma)
        {
            return _monanDAO.TenDaTonTai(ma);
        }

        public bool MonAnDaTonTai(MONAN_DTO ma)
        {
            return _monanDAO.MonAnDaTonTai(ma);
        }

        public int SoLuongML()
        {
            return _monanDAO.SoLuongML();
        }

        public int SoLuongMK()
        {
            return _monanDAO.SoLuongMK();
        }
    }
}
