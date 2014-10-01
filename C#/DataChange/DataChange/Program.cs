using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "数据转换";
            char next = 'y';
            do
            {
                Console.WriteLine("模式选择\n1.将字符串转换为Base64编码\n2.将Base64编码转换成字符串\n3.转换一个十进制数\n4.转换一个二进制数\n5.转换一个十六进制数");
                int mode = int.Parse(Console.ReadLine());
                switch (mode)
                {
                    case 1: Console.WriteLine("请输入一个字符串：");
                        string strings = Console.ReadLine();
                        byte[] bytestrings = Encoding.Default.GetBytes(strings);
                        string base64 = Convert.ToBase64String(bytestrings);
                        Console.WriteLine("{0}的Base64编码为{1}", strings, base64);
                        Console.WriteLine("是否继续？（y or n)");
                        next = char.Parse(Console.ReadLine());
                        break;
                    case 2: Console.WriteLine("请输入一个Base64编码：");
                        string base64_2 = Console.ReadLine();
                        byte[] base64_byte = Convert.FromBase64String(base64_2);
                        string strings2 = Encoding.Default.GetString(base64_byte);
                        Console.WriteLine("{0}对应的字符串为{1}", base64_2, strings2);
                        Console.WriteLine("是否继续？（y or n)");
                        next = char.Parse(Console.ReadLine());
                        break;
                    case 3: Console.WriteLine("请输入一个十进制数：");
                        int num10 = int.Parse(Console.ReadLine());
                        Console.WriteLine("十进制{0}的二进制为{1}\n十六进制为0x{2}", num10, Convert.ToString(num10, 2),Convert.ToString(num10 ,16));
                        Console.WriteLine("是否继续？（y or n)");
                        next = char.Parse(Console.ReadLine());
                        break;
                    case 4: Console.WriteLine("请输入一个二进制数：");
                        string num2 = Console.ReadLine();
                        Console.WriteLine("二进制{0}b的十进制为{1}\n十六进制为0x{2}", num2, Convert.ToInt32(num2,2),Convert .ToString (Convert.ToInt32 (num2 ,2),16));
                        Console.WriteLine("是否继续？（y or n)");
                        next = char.Parse(Console.ReadLine());
                        break;
                    case 5:Console.WriteLine("请输入一个十六进制数：");
                        string num16 = Console.ReadLine();
                        Console.WriteLine("十六进制0x{0}的十进制为{1}\n二进制为{2}b", num16 , Convert.ToInt32(num16 ,16),Convert .ToString (Convert.ToInt32 (num16 ,16),2));
                        Console.WriteLine("是否继续？（y or n)");
                        next = char.Parse(Console.ReadLine());
                        break;
                    default: Console.WriteLine("请选择正确的模式！\n");
                        Console.WriteLine("是否继续？（y or n)");
                        next = char.Parse(Console.ReadLine());
                        break;
                }

            } while (next == 'y');

        }
    }
}
