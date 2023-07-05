using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class SinhVienUD : SinhVien // Tạo lớp SinhVienUD kế thừa từ lớp SinhVien
    {
        int Kihoc; // Thêm thuộc tính mới
        public SinhVienUD() // Constructor không tham số
        {
            
        }

        // Constructor có tham số của lớp SinhVienUD dựa trên lớp constructor cha SinhVien
        public SinhVienUD(string maSV, string ten, int namSinh, double diem, int Kihoc) : base(maSV, ten, namSinh, diem)
        {
            KiHoc = Kihoc;
        }

        public int KiHoc { get => Kihoc; set => Kihoc = value; } 
        public override void InThongTin() // Phương thức ghi đè dựa trên InThongTin của lớp cha
        {
            base.InThongTin();
            Console.WriteLine($"| Kì học: {Kihoc}");
        }
    }
}
