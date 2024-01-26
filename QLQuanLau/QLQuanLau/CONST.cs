using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanLau
{
    public class CONST
    {
        #region QLMonAn
        public const string TENLOAI = "TENLOAI";
        public const string LOAIMONAN = "LOAIMONAN";
        public const string TENKICHTHUOC = "TENKICHTHUOC";
        public const string KICHTHUOC = "KICHTHUOC";
        public const string TENTRANGTHAI = "TENTRANGTHAI";
        public const string TRANGTHAI = "TRANGTHAI";
        public const string CONHANG = "Còn hàng";
        public const string HETHANG = "Hết hàng";
        public const string BINHTHUONG = "Bình thường";
        public const string NHO = "Nhỏ";
        public const string TENKTNHO = " (Nhỏ)";
        public const string MONLAU = "Món lẩu";
        public const string MONKEM = "Món kèm";
        public const string ML = "ML{0}";
        public const string MK = "MK{0}";
        public const string TRIPZERO = "000";
        public const string MAMONAN = "MAMONAN";
        public const string TENMON = "TENMON";
        public const string GIA = "GIA";
        public const string SOLUONG = "SOLUONG";
        public const string THANHTIEN = "THANHTIEN";
        public const string MONAN = "MONAN";
        public const string DSMA = "DSMA";
        public const string TKMAMONAN = "MAMONAN like '%";
        public const string TKTENMON = "TENMON like '%";
        #endregion

        #region TrangChu
        public const string HD = "HD{0}";
        public const string FORMAT_TAM0 = "00000000";
        public const string ADMIN = "Admin: ";
        public const string NHANVIEN = "Nhân viên: ";
        #endregion

        #region QLHoaDon
        public const string MAHD = "MAHD";
        public const string DSHD = "DSHD";
        public const string NGAYLAP = "NGAYLAP";
        public const string THANHTOAN = "THANHTOAN";
        public const string TKNGAYLAP = "NGAYLAP = #";
        public const string TKMANVLAPDON = "MANVLAPDON like '%";
        public const string TKMABAN = "MABAN like '%";
        public const string TKNGAYLAP1 = "NGAYLAP >= #";
        public const string TKNGAYLAP2 = "NGAYLAP <= #";
        public const string TKMAHD = "MAHD like '%";
        public const string DINHDANGDATE1 = "M/dd/yyyy 00:00:00";
        public const string DINHDANGDATE2 = "M/dd/yyyy 11:59:59";
        public const string AND = " and ";
        public const string AM = " AM ";
        public const string PM = " PM ";
        public const string ZEROTIME = "00:00:00";
        public const string NEARZEROTIME = "11:59:59";
        #endregion

        #region QLNhanVien
        public const string MANVLAPDON = "MANVLAPDON";
        public const string DSNV = "DSNV";
        public const string MANV = "MANV";
        public const string TKMANV = "MaNV like '%";
        public const string TKTENNV = "HOTEN like '%";
        public const string cMaNV = "cMaNV";
        public const string cHOTEN = "cHOTEN";
        public const string cNGAYSINH = "cNGAYSINH";
        public const string cCMND = "cCMND";
        public const string CHUCVU = "CHUCVU";
        public const string NV = "NV{0}";
        #endregion

        #region QLBanAn
        public const string MABAN = "MABAN";
        public const string TENBAN = "TENBAN";
        public const string TRONG = "";
        public const string DSBA = "DSBA";
        public const string DSTK = "DSTK";
        public const string colMaBan = "colMaBan";
        public const string colTenBan = "colTenBan";
        public const string colCOKHACH = "colCOKHACH";
        public const string TKTENBAN = "TENBAN like'%";
        #endregion

        #region QLTaiKhoan
        public const string colMaNV = "colMaNV";
        public const string colTenDN = "colTenDN";
        public const string colMatKhau = "colMatKhau";
        public const string TKTENDN = "TENDANGNHAP like'%";
        #endregion

        #region BaoCao
        public const string rp_TatCaHoaDon = "../../rp_TatCaHoaDon.rdlc";
        public const string rp_HoaDonThanhToan = "../../rp_HoaDonThanhToan.rdlc";
        public const string rp_TatCaMonAn = "../../rp_TatCaMonAn.rdlc";
        public const string rp_TatCaNhanVien = "../../rp_TatCaNhanVien.rdlc";
        public const string DataSetHoaDonDTO = "DataSetHoaDonDTO";
        public const string DataSetChiTietHoaDonDTO = "DataSetChiTietHoaDonDTO";
        public const string DataSetDSMonChinh = "DataSetDSMonChinh";
        public const string DataSetDSMonPhu = "DataSetDSMonPhu";
        public const string DataSetNhanVienDTO = "DataSetNhanVienDTO";
        public const string parTuNgay = "parTuNgay";
        public const string parDenNgay = "parDenNgay";
        public const string parTenBan = "parTenBan";
        public const string parNgayLap = "parNgayLap";
        public const string parMaHD = "parMaHD";
        public const string parTenNV = "parTenNV";
        #endregion

        #region Thông báo
        public const string CHONBANXOA = "Vui lòng chọn bàn bạn muốn xóa!";
        public const string NHAPTTTHEM = "Vui lòng nhập đầy đủ thông tin!";
        public const string NHAPTTSUA = "Vui lòng nhập thông tin bạn muốn sửa!";
        public const string NHAPTTXOA = "Vui lòng nhập mã bạn muốn xóa!";
        public const string NHAPTKXOA = "Vui lòng nhập tài khoản bạn muốn xóa!";
        public const string TIMMA = "Vui lòng nhập mã cần tìm!";
        public const string TIMTEN = "Vui lòng nhập tên cần tìm!";
        public const string TBDANGNHAP = "Vui lòng nhập đầy đủ tài khoản và mật khấu!";
        public const string TBDANGNHAPTB = "Tài khoản đăng nhập không hợp lệ!";
        public const string TBNHAPTK = "Vui lòng nhập tài khoản!";
        public const string TBNHAPMK = "Vui lòng nhập mật khẩu!";
        public const string XACNHANTHOAT = "Bạn chắc chắn muốn thoát?";
        public const string XACNHANDANGXUAT = "Bạn chắc chắn muốn đăng xuất?";
        public const string THONGBAO = "Thông báo";
        public const string THEMTC = "Thêm thành công!";
        public const string THEMTB = "Thêm thất bại!";
        public const string TBXACNHANSUA = "Bạn có chắc muốn sửa?";
        public const string SUATC = "Sửa thành công!";
        public const string SUATB = "Sửa thất bại!";
        public const string TBXACNHANXOA = "Bạn có chắc chắn muốn xóa?";
        public const string XOATC = "Xóa thành công!";
        public const string XOATB = "Xóa thất bại!";
        public const string KHONGTHEMOANH = "Lỗi không thể đọc ảnh. Mã lỗi: ";
        public const string DATONTAI_MON_AN = "Đã có món ăn này trong danh sách!";
        public const string TBNHAPMONAN = "Vui lòng chọn món!";
        public const string TBCHONBAN = "Vui lòng chọn bàn!";
        public const string XACNHANCHUYENBAN = "Bạn có chắc chắn muốn chuyển bàn?";
        public const string KHONG_THE_CHUYEN_BAN = "Không thể chuyển bàn!";
        public const string CHUYENBANTC = "Chuyển bàn thành công!";
        public const string CHUYENBANTB = "Chuyển bàn thất bại!";
        public const string XAC_NHAN_THANH_TOAN = "Bạn có chắc chắn muốn thanh toán?";
        public const string THANHTOANTC = "Thanh toán thành công!";
        public const string THANHTOANTB = "Thanh toán thất bại!";
        public const string YEU_CAU_NHAP_TIEN_NHAN = "Vui lòng nhập số tiền nhận!";
        public const string TBKHONGDUTIEN = "Không đủ tiền để thanh toán!";
        public const string TBKHONGTHEIN = "Không thể in hóa đơn chưa thanh toán!";
        #endregion

        #region Hằng số
        public const int ZERO = 0;
        public const int MOT = 1;
        public const int HAI = 2;
        public const int BA = 3;
        public const int BON = 4;
        public const int NAM = 5;
        public const int SAU = 6;
        public const int BAY = 7;
        public const int TAM = 8;
        public const int CHIN = 9;
        #endregion

        #region Path
        public const string THEMANH = @"../../../data/Picture/Icon/image.jpeg";
        public const string ANHLOI = @"../../../data/Picture/Icon/crash.jpeg";
        public const string ANHNULL = @"../../../data/Picture/Icon/no-image.jpeg";
        public const string FOLDER_PATH = @"../../../data/Picture/MonAn";
        public const string FOLDER_PATH_BA = @"../../../data/Picture/BanAn";
        public const string BLUE_HOT_POT = "blue-hot-pot.jpg";
        public const string RED_HOT_POT = "red-hot-pot.jpg";
        public const string GREEN_HOT_POT = "green-hot-pot.jpg";
        public const string CHEO_PHAI = "/";
        public const string DINHDANG_JPG = ".jpg";
        public const string LAYDINHDANG_JPG = "*.jpg";
        public const string DIA_C = "C:\\";
        public const string KIEUANH = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.png; *.jpeg; *.jpe; *.jfif; *.png";
        #endregion

        #region Hằng ký tự
        public const string DAUTHANG = " # ";
        public const string DAUBANG = " = ";
        public const string LIKE = " like ";
        public const string MO_NHAY_PHAN_TRAM = "'%";
        public const string DONG_NHAY_PHAN_TRAM = "%'";
        public const string TRUE = "True";
        public const string DAUPHAY = ",";
        public const string KYTUZERO = "0";
        public const string TIMER = "hh:mm:ss tt dd/MM/yyyy";
        public const string DINHDANGMONEY = "#,#";
        public const string DINHDANGDATE = "M/dd/yyyy";
        #endregion

        #region
        public const string TKAN = "Unknown";
        public const string MKAN = "lod1231";
        public const string TENAN = "???";
        public const string MAAN = "???";
        public const bool QUYEN = true;
        #endregion
    }
}
