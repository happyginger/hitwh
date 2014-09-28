using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        struct Rectangle
        {
            public int Width;
            public int Height;
            public bool IsSquare() { return Width == Height; }
        }
        static void Main(string[] args)
        {
            Rectangle rece = new Rectangle();
            rece.Width = 100;
            rece .Height =100;
            Console.WriteLine("矩形宽：{0}  矩形长：{1}", rece.Width, rece.Height);

            bool isSquare = rece.IsSquare();
            Console .WriteLine ("矩形是否为正方形：{0}",isSquare );
            Console.ReadKey();

        }
    }
}
