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
    public class MH_SuaHangHoaModel : PageModel
    {
        public HangHoa HangHoa;
        public string Chuoi;
        public bool coHangHoa;
        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }
        [BindProperty]
        public string TenHang { get; set; }
        [BindProperty]
        public string LoaiHang { get; set; }
        [BindProperty]
        public string CongTySX { get; set; }
        [BindProperty]
        public int NamSX { get; set; }
        [BindProperty]
        public int HanDung { get; set; }
        public void OnGet()
        {
            HangHoa? hh = XuLyHangHoa.DocHangHoa(ID);
            if (hh != null)
            {
                HangHoa = hh.Value;
            }
            else
            {
                Chuoi = "Không tìm thấy thông tin hàng hóa";
            }
            coHangHoa = (hh != null);
        }
        public void OnPost()
        {
            //bool kq = XuLyHangHoa.SuaHangHoa(ID, TenHang, LoaiHang, CongTySX, NamSX, HanDung);
            //Chuoi = $"Ket qua la {kq}";
            Response.Redirect("/MH_DanhSachHangHoa");
        }
    }
}