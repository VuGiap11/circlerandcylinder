using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lopcicler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(20);
            Console.WriteLine(circle.ToString());
            Cylinder c = new Cylinder(20, 4);
            Console.WriteLine(c.ToString());
        }
    }
}
