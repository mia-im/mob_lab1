using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMyF
{
    class Program
    {
        /// <summary>
        /// Calling the library method F (z, e) from MyF.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите аргумент z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точность e");
            double e = double.Parse(Console.ReadLine());
            // call the F calculation method from the library
            double my_f = Math.Round(MyLib.MyF.F(z, e), 3);
            // calculating the exact value of the function
            double f = Math.Round((1-2*Math.Pow(z,2))*Math.Exp(Math.Pow(z, 2)),3);
            // calculation error
            double delta = Math.Round(Math.Abs(my_f - f) / f * 100, 3);
            Console.WriteLine("my_f={0}, f={1}, delta={2}%", my_f, f, delta);
            Console.ReadKey();
        }
    }
}
