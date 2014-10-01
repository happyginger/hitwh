using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi
{
    class Program
    {
        public void Get(out int result,params int[] numbers)
        {
            result = 1;
            foreach (int number in numbers )
            {
                result *= number;
            }
        }
        static void Main(string[] args)
        {
            int numbeer1 = int.Parse(Console.ReadLine());
            int numbeer2 = int.Parse(Console.ReadLine());
            int numbeer3 = int.Parse(Console.ReadLine());
            Program p = new Program();
            int result;
            p.Get(out result, numbeer1, numbeer2, numbeer3);
            Console.WriteLine("{0}", result);
            Console.ReadKey();
            
        }
    }
}
