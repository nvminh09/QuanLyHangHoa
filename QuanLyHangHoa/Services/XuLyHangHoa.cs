using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.DAL;

namespace QuanLyHangHoa.Services
{
    public class XuLyHangHoa
    {
        public static bool ThemHangHoa(HangHoa h)
        {
            //Kiểm tra tính hợp lệ của hàng hóa
            if (string.IsNullOrWhiteSpace(h.maHang) ||
                string.IsNullOrWhiteSpace(h.tenHang) ||
                string.IsNullOrWhiteSpace(h.loaiHang) ||
                string.IsNullOrWhiteSpace(h.congTySX) ||
                h.namSX < 0 || h.hanDung < 0 )
            {
                return false;
            }
            return LuuTruHangHoa.LuuHangHoa(h);
        }
        public static List<HangHoa> TimKiem(string tuKhoa)
        {
            if (tuKhoa == null) tuKhoa = string.Empty;
            List<HangHoa> dshh = LuuTruHangHoa.DocDanhSachHangHoa();
            List<HangHoa> kq = new List<HangHoa>();
            foreach (HangHoa hh in dshh)
            {
                if (hh.tenHang.Contains(tuKhoa))
                {
                    kq.Add(hh);
                }
            }
            return kq;
        }
        public static HangHoa? DocHangHoa(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                return null;
            }
            List<HangHoa> dsHH = LuuTruHangHoa.DocDanhSachHangHoa();
            foreach (HangHoa hh in dsHH)
            {
                if (hh.maHang == ID)
                {
                    return hh;
                }
            }
            return null;
        }
        public static bool SuaHangHoa(string ID, string tenHang, string loaiHang, string congTySX, int namSX, int hanDung)
        {
            if (string.IsNullOrWhiteSpace(ID) ||
                string.IsNullOrWhiteSpace(tenHang) ||
                string.IsNullOrWhiteSpace(loaiHang) ||
                string.IsNullOrWhiteSpace(congTySX) ||
                namSX < 0 || hanDung < 0)
            {
                return false;
            }
            List<HangHoa> dshh = LuuTruHangHoa.DocDanhSachHangHoa();
            for (int i = 0; i < dshh.Count; i++)
            {
                if (dshh[i].maHang == ID)
                {
                    HangHoa hhmoi;
                    hhmoi.maHang = ID;
                    hhmoi.tenHang = tenHang;
                    hhmoi.loaiHang = loaiHang;
                    hhmoi.congTySX = congTySX;
                    hhmoi.namSX = namSX;
                    hhmoi.hanDung = hanDung;

                    dshh[i] = hhmoi;
                    LuuTruHangHoa.LuuDanhSachHangHoa(dshh);
                    return true;
                }
            }
            return false;
        }
        public static bool XoaHangHoa(string ID)
        {
            if (string.IsNullOrWhiteSpace(ID))
            {
                return false;
            }
            return LuuTruHangHoa.XoaHangHoa(ID);
        }
    }
}