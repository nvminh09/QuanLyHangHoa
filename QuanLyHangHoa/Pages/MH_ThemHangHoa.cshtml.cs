using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.Services;

namespace QuanLyHangHoa.Pages
{
    public class MH_ThemHangHoaModel : PageModel
    {
        public HangHoa h;
        public string Chuoi;
        [BindProperty]
        public string MaHang { get; set; }
        [BindProperty]
        public string TenHang { get; set; }
        [BindProperty]
        public string loaiHang { get; set; }
        [BindProperty]
        public string CongTySX { get; set; }
        [BindProperty]
        public int NamSX { get; set; }
        [BindProperty]
        public int HanDung { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            HangHoa h;
            h.maHang = MaHang;
            h.tenHang = TenHang;
            h.loaiHang = loaiHang;
            h.congTySX = CongTySX;
            h.namSX = NamSX;
            h.hanDung = HanDung;
            bool kq = XuLyHangHoa.ThemHangHoa(h);
            Chuoi = $"Kết quả là {kq}";
        }
    }
}