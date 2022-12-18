using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.Services;

namespace QuanLyHangHoa.Pages
{
    public class MH_DangNhapModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string TenDangNhap { get; set; }
        [BindProperty]
        public string MatKhau { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            NguoiDung? ten = XuLyNguoiDung.DangNhap(TenDangNhap, MatKhau);
            if (ten != null)
            {
                HttpContext.Session.SetString("ten", ten.Value.tenDangNhap);
                Response.Redirect("/MH_DanhSachHangHoa");
            }
            else
            {
                Chuoi = "Đăng nhập không thành công";
            }
        }
    }
}
