using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.DAL;

namespace QuanLyHangHoa.Services
{
    public class XuLyNguoiDung
    {
        public static bool DangKy(string tenNguoiDung, string matKhau, string hoTenNguoiDung)
        {
            if (string.IsNullOrWhiteSpace(tenNguoiDung) || 
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(hoTenNguoiDung))
            {
                return false;
            }

            NguoiDung? nguoiDung = LuuTruNguoiDung.TimNguoiDung(tenNguoiDung);
            if (nguoiDung != null)
            {
                return false;
            }
            else
            {
                NguoiDung nguoiDungMoi;
                nguoiDungMoi.tenDangNhap = tenNguoiDung;
                nguoiDungMoi.matKhau = matKhau;
                nguoiDungMoi.hoTen = hoTenNguoiDung;
                return LuuTruNguoiDung.ThemNguoiDung(nguoiDungMoi);
            }
        }
        public static NguoiDung? DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || 
                string.IsNullOrWhiteSpace(matKhau))
            {
                return null;
            }

            NguoiDung? nguoiCanTim = LuuTruNguoiDung.TimNguoiDung(tenDangNhap);
            if (tenDangNhap != null && nguoiCanTim.Value.matKhau == matKhau)
            {
                return nguoiCanTim;
            }
            return null;
        }
    }
}