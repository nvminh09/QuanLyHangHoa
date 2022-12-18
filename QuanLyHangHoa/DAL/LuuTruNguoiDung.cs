using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuanLyHangHoa.Entities;

namespace QuanLyHangHoa.DAL
{ 
    public class LuuTruNguoiDung
    {
        public static bool LuuNguoiDung(NguoiDung h)
        {
            List<NguoiDung> dSNguoiDung = DocDanhSachNguoiDung();
            dSNguoiDung.Add(h);
            LuuDanhSachNguoiDung(dSNguoiDung);
            return true;
        }
        public static bool LuuDanhSachNguoiDung(List<NguoiDung> dSHH)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\Minh\\VB2 CNTT\\Ky thuat lap trinh\\KTLT_VisualStudio\\NguoiDung.json");
            string jsonString = JsonConvert.SerializeObject(dSHH);
            writer.Write(jsonString);
            writer.Close();
            return true;
        }

        public static List<NguoiDung> DocDanhSachNguoiDung()
        {
            StreamReader reader = new StreamReader("C:\\Users\\Minh\\VB2 CNTT\\Ky thuat lap trinh\\KTLT_VisualStudio\\NguoiDung.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<NguoiDung> danhSachNguoiDung = JsonConvert.DeserializeObject<List<NguoiDung>>(jsonString);
            return danhSachNguoiDung;
        }
        public static bool ThemNguoiDung(NguoiDung nd)
        {
            List<NguoiDung> danhSachNguoiDung = DocDanhSachNguoiDung();
            danhSachNguoiDung.Add(nd);
            LuuDanhSachNguoiDung(danhSachNguoiDung);
            return true;
        }
        public static NguoiDung? TimNguoiDung(string tenNguoiDung)
        {
            List<NguoiDung> dsnd = DocDanhSachNguoiDung();
            for (int i = 0; i < dsnd.Count; i++)
            {
                if (dsnd[i].tenDangNhap == tenNguoiDung)
                {
                    return dsnd[i];
                }
            }
            return null;
        }
        public static bool XoaNguoiDung(string tenCanXoa)
        {
            List<NguoiDung> dsND = DocDanhSachNguoiDung();
            for (int i = 0; i < dsND.Count; i++)
            {
                if (dsND[i].tenDangNhap == tenCanXoa)
                {
                    dsND.RemoveAt(i);
                    LuuDanhSachNguoiDung(dsND);
                    return true;
                }
            }
            return false;
        }
        
    }
}
