using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zadanie_1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sphere sphereFirst = new Sphere(0, 0, 0, 10);
            Radius r1 = new Radius(0, 0, -20, 0, 0, 0);
            Radius r2 = new Radius(0, 0, -20, 0, 100, 0);
        }
    }
}
