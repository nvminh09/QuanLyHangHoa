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
    public class MH_DanhSachHangHoaModel : PageModel
    {
        public List<HangHoa> dsHangHoa;
        [BindProperty]
        public string tuKhoa { get; set; }
        public void OnGet()
        {
            dsHangHoa = XuLyHangHoa.TimKiem(string.Empty);
        }
        public void OnPost()
        {
            dsHangHoa = XuLyHangHoa.TimKiem(tuKhoa);
        }
    }
}