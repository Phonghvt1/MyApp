using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDung1.Model
{
    class NhanVien
    {
        public static NhanVien SuaNhanVien { get; internal set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string GetContentFileNhanVien() 
        {
            return File.ReadAllText("Data/NhanVien.json");
        }
        public List<NhanVien> GetNhanVien()
        {
            List<NhanVien> dsNhanVien =
            JsonConvert.DeserializeObject<List<NhanVien>>(GetContentFileNhanVien());
            return dsNhanVien;
        }

        internal void PutNhanVien(NhanVien nv)
        {
            List<NhanVien> nhanViens = GetNhanVien();
            nhanViens.RemoveAll(item => item.Username == nv.Username);
            nhanViens.Add(nv);
            string path = "Data/NhanVien.json";
            string content = JsonConvert.SerializeObject(nhanViens);
            File.WriteAllText(path, content);

        }

        internal void XoaNhanVien(string text)
        {
            List<NhanVien> nhanViens = GetNhanVien();
            nhanViens.RemoveAll(item => item.Username == text);
            string path = "Data/NhanVien.json";
            string content = JsonConvert.SerializeObject(nhanViens);
            File.WriteAllText(path, content);
        }
    }
}
