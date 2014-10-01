using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Animal : byte
        {
            Dog=0,
            Cat=1,
            Mouse=2
        }
        static void Main(string[] args)
        {
            Animal anamal=Animal .Cat ;
            switch (anamal )
            {
                case Animal.Dog:
                    Console.WriteLine("狗");
                    break;
                case Animal.Cat:
                    Console.WriteLine("猫");
                    break;
                case Animal.Mouse:
                    Console.WriteLine("老鼠");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
