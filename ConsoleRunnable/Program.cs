using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vectors;
using Vectors.VectorClasses;

namespace ConsoleRunnable
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = VectorOperation3D.ScalarMultiply(E(9.523, -11), Vector(-3, 4, -4));
            Vector b = VectorOperation3D.ScalarMultiply(E(1.9876, -10), Vector(4, -2, 5));

            Console.WriteLine(VectorOperation3D.ScalarMultiply(8987742438, VectorOperation3D.Add(a, b)));

            Console.ReadLine();
        }

        static decimal E(double a, double b)
        {
            return (decimal)(a * Math.Pow(10, b));
        }

        static Vector Vector(decimal x, decimal y, decimal z)
        {
            return new Vectors.VectorClasses.Vector(x, y, z);
        }
    }
}
