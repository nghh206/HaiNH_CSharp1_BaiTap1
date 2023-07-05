using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class SERVICE
    {
        // Sử dụng List<SinhVien> để lưu trữ một danh sách các sinh viên
        List<SinhVien> _lstSinhVien = new List<SinhVien>();
        public void NhapThongTin()
        {
            string nhapTiep; // khai báo biến để dùng cho người dùng muốn nhập tiếp
            do
            {
                SinhVien sv = new SinhVien(); // Khởi tạo đối tượng
                Console.Write("Mời bạn nhập vào mã sinh viên: ");
                sv.maSV = Console.ReadLine();
                Console.Write("Mời bạn nhập vào tên sinh viên: ");
                sv.ten = Console.ReadLine();
                Console.Write("Mời bạn nhập vào năm sinh của sinh viên: ");
                sv.namSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập vào điểm của sinh viên: ");
                sv.diem = Convert.ToDouble(Console.ReadLine());
                _lstSinhVien.Add(sv); // Thêm vào danh sách sau khi nhập vào
                Console.WriteLine("Bạn có muốn nhập tiếp không?");
                Console.WriteLine("Phím bất kỳ: Có     N: Không");
                nhapTiep = Console.ReadLine();
            } while (nhapTiep.ToUpper() != "N"); // Kiểm tra điều kiện xem người dùng muốn nhập nữa không
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var item in _lstSinhVien) 
            {
                item.InThongTin();
            }
        }
        public void VeVip()
        {
            Console.WriteLine("Danh sách các sinh viên được tặng vé vip Happy Bee(Điểm >=8)");
            foreach (var item in _lstSinhVien)  
            {
                if (item.diem >= 8) // Điểm phải >= 8 mới in ra 
                {
                    item.InThongTin();
                }
            }
        }
        public void XoaSinhVien()
        {
            Console.WriteLine("Xóa những sinh viên không được tham gia Happy Bee nếu không được tặng vé(Tuổi > 25)");
            List<SinhVien> sinhVienCanXoa = new List<SinhVien>(); // Khai báo danh sách tạm để lưu trữ sinh viên cần xóa
                
            for (int i = 0; i < _lstSinhVien.Count; i++) // Duyệt từng phần tử trong _lstSinhVien
            {
                if (_lstSinhVien[i].namSinh < 1997 || _lstSinhVien[i].diem <= 8)// Nếu tuổi > 25 và không được tặng vé 
                {
                        sinhVienCanXoa.Add(_lstSinhVien[i]); // Sẽ được thêm vào danh sách tạm
                }
            }

            _lstSinhVien.RemoveAll(x => sinhVienCanXoa.Contains(x)); //Xóa tất cả phần tử trong danh sách tạm khỏi _lstSinhVien

            foreach (var item in sinhVienCanXoa) // Duyệt mảng
            {
                Console.WriteLine("Đã xóa sinh viên: " + item.ten); // In ra các sinh viên đã bị xóa
            }

            foreach (var item in _lstSinhVien) //In ra danh sách 
            {
                item.InThongTin();
            }
        }
        public void KeThua(string KeThua) // Constructor có tham số
        {
            Console.WriteLine(KeThua);// In ra tham số truyền vào
            SinhVienUD sinhVienUD = new SinhVienUD();
            Console.Write("Mời bạn nhập vào mã sinh viên: ");
            sinhVienUD.maSV = Console.ReadLine();
            Console.Write("Mời bạn nhập vào tên sinh viên: ");
            sinhVienUD.ten = Console.ReadLine();
            Console.Write("Mời bạn nhập vào năm sinh của sinh viên: ");
            sinhVienUD.namSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập vào điểm của sinh viên: ");
            sinhVienUD.diem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mời bạn nhập vào kì học hiện tại của sinh viên: ");
            sinhVienUD.KiHoc = Convert.ToInt32(Console.ReadLine());
            sinhVienUD.InThongTin();
        }
    }
}
