using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class SinhVien
    {
        string MaSV; 
        string Ten;
        int NamSinh;
        double Diem;

        public SinhVien() //Constructor không tham số
        {
            
        }
        public SinhVien(string maSV, string ten, int namSinh, double diem) //Constructor có tham số
        {
            MaSV = maSV;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }

        //Các property 
        public string maSV { get => MaSV; set => MaSV = value; } 
        public string ten { get => Ten; set => Ten = value; }
        public int namSinh { get => NamSinh; set => NamSinh = value; }
        public double diem { get => Diem; set => Diem = value; }

        public virtual void InThongTin() // Phương thức cho phép ghi đè 
        {
            Console.WriteLine($"Mã sinh viên: {MaSV} | Tên: {Ten} | Năm sinh:{NamSinh} | Điểm: {Diem}");
        }
    }
}
