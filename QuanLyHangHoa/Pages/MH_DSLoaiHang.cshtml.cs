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
        public List<HangHoa> dsLoaiHang;
        [BindProperty]
        public string tuKhoa { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            

        }
    }
}