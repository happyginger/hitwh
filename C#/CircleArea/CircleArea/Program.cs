using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Circle
    {
        const double PI = 3.1215926f;
        public readonly int Radius = 1;
        public Circle(int radius) { Radius = radius; }
        public double Area() { return PI * Radius * Radius; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine("{0}", circle.Area());
            Console.ReadKey();
        }
    }
}
