using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuanLyHangHoa.Entities;

namespace QuanLyHangHoa.DAL
{
    public class LuuTruHangHoa
    {
        public static bool LuuHangHoa(HangHoa h)
        {
            List<HangHoa> dSHangHoa = DocDanhSachHangHoa();
            dSHangHoa.Add(h);
            LuuDanhSachHangHoa(dSHangHoa);
            return true;
        }
        public static bool LuuDanhSachHangHoa(List<HangHoa> dSHH)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\Minh\\VB2 CNTT\\Ky thuat lap trinh\\KTLT_VisualStudio\\HangHoa.json");
            string jsonString = JsonConvert.SerializeObject(dSHH);
            writer.Write(jsonString);

            //StreamWriter groupedList = groupedList(writer, "Loại hàng");
            writer.Close();
            return true;
        }
        public static List<HangHoa> DocDanhSachHangHoa()
        {
            StreamReader reader = new StreamReader("C:\\Users\\Minh\\VB2 CNTT\\Ky thuat lap trinh\\KTLT_VisualStudio\\HangHoa.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<HangHoa> danhSachHangHoa = JsonConvert.DeserializeObject<List<HangHoa>>(jsonString);
            return danhSachHangHoa;
        }
        public static List<LoaiHang> DocDanhSachLoaiHang()
        {
            StreamReader reader = new StreamReader("C:\\Users\\Minh\\VB2 CNTT\\Ky thuat lap trinh\\KTLT_VisualStudio\\HangHoa.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<LoaiHang> danhSachLoaiHang = JsonConvert.DeserializeObject<List<LoaiHang>>(jsonString);
            return danhSachLoaiHang;
        }
        public static bool XoaHangHoa(string ID)
        {
            List<HangHoa> dsHH = DocDanhSachHangHoa();
            for (int i = 0; i < dsHH.Count; i++)
            {
                if (dsHH[i].maHang == ID)
                {
                    dsHH.RemoveAt(i);
                    LuuDanhSachHangHoa(dsHH);
                    return true;
                }
            }
            return false;
        }
        
    }
}
