using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.Services;

namespace QuanLyHangHoa.Pages
{
    public class MH_XoaLoaiHangModel : PageModel
    {
        public HangHoa HangHoa;
        public string Chuoi;
        public bool coHangHoa;
        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            bool kq = XuLyHangHoa.XoaHangHoa(ID);
            Chuoi = $"Kết quả là {kq}";
            Response.Redirect("/MH_DanhSachHangHoa");
        }
    }
}