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
            Vector a = new Vector(5, 10, 15);
            Vector b = new Vector(1, 2, 5);
            Console.WriteLine( VectorOperation.Cross3D(a, b).ToString());

            Console.ReadLine();
        }
    }
}
