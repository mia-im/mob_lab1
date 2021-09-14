using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMyP
{
    class Program
    {
        /// <summary>
        /// Calling the library method P (n) from MyP.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            int n = int.Parse(Console.ReadLine());
            // Call the method for calculating P from the library
            double P = MyLib.MyP.P(n);
            Console.WriteLine("n={0}, P={1}", n, P);
            Console.ReadKey();
        }
    }
}
