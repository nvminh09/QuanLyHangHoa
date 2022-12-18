using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.Services;

namespace QuanLyHangHoa.Pages
{
    public class MH_DangKyModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string TenDangNhap { get; set; }
        [BindProperty]
        public string MatKhau { get; set; }
        [BindProperty]
        public string HoTen { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            bool kq = XuLyNguoiDung.DangKy(TenDangNhap, MatKhau, HoTen);
            Chuoi = $"Kết quả là {kq}";
            if (kq == true)
            {
                Response.Redirect("/MH_DangNhap");
            }
        }
    }
}
