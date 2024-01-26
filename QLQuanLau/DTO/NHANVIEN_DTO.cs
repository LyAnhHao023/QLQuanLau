using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHANVIEN_DTO
    {
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string CMND { get; set; }
        public bool CHUCVU { get; set; }
        public bool XOA { get; set; }
        public string TENCHUCVU { get; set; }
        public string XOATXT { get; set; }
    }
}
