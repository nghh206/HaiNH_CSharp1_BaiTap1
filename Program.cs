using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Menu()
        {
            int choice;
            SERVICE service = new SERVICE();

            do
            {
                Console.WriteLine("-----------------------------Menu-----------------------------");
                Console.WriteLine("1. Nhập danh sách đối tượng");
                Console.WriteLine("2. Xuất danh sách đối tượng");
                Console.WriteLine("3. Xuất danh sách các SV được tặng vé vip HappyBee(điểm >= 8)");
                Console.WriteLine("4. Xóa những sinh viên không được tham gia HappyBee(Tuổi > 25)");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Mời bạn chọn chức năng ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bạn chọn Nhập danh sách đối tượng");
                        service.NhapThongTin();
                        break;
                    case 2:
                        Console.WriteLine("Bạn chọn Xuất danh sách đối tượng");
                        service.XuatThongTin();
                        break;
                    case 3:
                        Console.WriteLine("Bạn chọn Xuất danh sách sinh viên có vé vip");
                        service.VeVip();
                        break;
                    case 4:
                        Console.WriteLine("Bạn chọn Xóa sinh viên");
                        service.XoaSinhVien();
                        break;
                    case 5:
                        Console.WriteLine("Bạn chọn kế thừa");
                        service.KeThua("Kế thừa từ Class SinhVien");
                        break;
                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình");
                        break;
                    default:
                        Console.WriteLine("Hãy chọn chức năng có trong chương trình");
                        break;
                }
            } while (choice != 0);


        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
        }
    }
}
