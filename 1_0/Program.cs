using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMySin
{
    class Program
    {
        /// <summary>
        /// Calling the library method Sin (x, n) from MySin.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х - угол в радианах");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите показатель степени n");
            int n = int.Parse(Console.ReadLine());
            // call the sin (x) calculation method from the library
            double my_sinus = MyLib.MySin.Sin(x, n);
            // call a method from the class Math
            double sinus = Math.Sin(x);
            double delta = sinus - my_sinus;
            Console.WriteLine("my_sinus={0}, sin={1}, delta={2}", my_sinus, sinus, delta);
            Console.ReadKey();
        }
    }
}
