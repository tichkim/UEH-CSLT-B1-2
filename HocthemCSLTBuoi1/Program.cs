using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocthemCSLT
{
    class Program
    {
        static void BainhaB1_1()
        {
            Console.WriteLine("BANG CUU CHUONG");
            Console.WriteLine("========================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(8, 3);
            Console.WriteLine("|1\t|2\t|3\t|4\t|5\t|6\t|7\t|8\t|9\t|10");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("========================================================================================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("1:\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|1\t|2\t|3\t|4\t|5\t|6\t|7\t|8\t|9\t|10");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("2:\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|2\t|4\t|6\t|8\t|10\t|12\t|14\t|16\t|18\t|20");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("3:\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|3\t|6\t|9\t|12\t|15\t|18\t|21\t|24\t|27\t|30");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("4:\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|4\t|8\t|12\t|16\t|20\t|24\t|28\t|32\t|36\t|40");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("5:\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|5\t|10\t|15\t|20\t|25\t|30\t|35\t|40\t|45\t|50");
            Console.WriteLine("========================================================================================");

        }
        static void BainhaB1_2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HAY TRA LOI NHUNG THONG TIN SAU DAY: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------==========----------");
            Console.WriteLine("Hay nhap ho va ten cua ban: ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hay nhap chi so dien cu cua ban: ");
            uint chisocu = uint.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Hay nhap chi so dien moi cua ban: ");
            uint chisomoi = uint.Parse(Console.ReadLine());
            Console.Clear();

            uint tieuthu, tiendien;
            tieuthu = chisomoi - chisocu;
            tiendien = tieuthu * 3000;
            
            Console.WriteLine("----------==========----------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HOA DON TIEN DIEN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Khach hang: < " + name + " > ");
            Console.WriteLine("Chi so cu: < " + chisocu + " > ");
            Console.WriteLine("Chi so moi: < " + chisomoi + " > ");
            Console.WriteLine("Tieu thu: " + tieuthu);
            Console.WriteLine("Tien dien: " + tiendien);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YEU CAU TIET KIEM DIEN !!! ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------==========----------");
        }
        static void BaiB2_1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.Write(Math.Max(a, Math.Max(b, Math.Max(c, d))));
        }
        static void BaiB2_2()
        {
            string S = "Hello woRld";
            string u = S.ToUpper();
            char c = S[1];
            int l = S.Substring(0, 4).Length;
            Console.WriteLine(S);
        }
        static void BaiB2_3()
        {
            Console.Title = "Xin chao cac em !";
            Console.CursorSize = 80;
            Console.Clear();
            bool a = Console.CapsLock;
            string kq = a ? "bat" : "tat";
            Console.SetCursorPosition(15, 5);
            Console.WriteLine("Phim Capslock dang " + kq);
            Console.Beep(1000, 2000);
            Console.WriteLine("An 1 phim diii");
            ConsoleKeyInfo k = Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //BainhaB1_1();
            //BainhaB1_2();
            //BaiB2_1();
            //BaiB2_2();
            //BaiB2_3();
        }
    }
}
