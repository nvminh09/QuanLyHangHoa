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
    public class MH_DSLoaiHangModel : PageModel
    {
        public List<LoaiHang> dsLoaiHang;
        [BindProperty]
        public string tuKhoa { get; set; }
        public void OnGet()
        {
            //dsLoaiHang = XuLyHangHoa.TimKiem(string.Empty);
            dsLoaiHang = new List<LoaiHang>();
        }
        public void OnPost()
        {
            //dsLoaiHang = XuLyHangHoa.TimKiem(string.Empty);
            //dsLoaiHang = new List<LoaiHang>();

        }
    }
}