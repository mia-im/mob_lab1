using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMyT
{
    class Program
    {
        /// <summary>
        /// Calling the library method T (h, g) from MyT.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите h - высоту здания");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите g - ускорение свободного падения");
            double g = double.Parse(Console.ReadLine());
            // Call the method for calculating t from the library
            double t = MyLib.MyT.T(h, g);
            Console.WriteLine("h={0}, g={1}, t={2}", h, g, t);
            Console.ReadKey();
        }
    }
}

