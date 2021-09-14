using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyLib
{
    /// Calculation of mathematical functions
    public class MyP
    {
        /// <summary>
        /// P
        /// </summary>
        /// <param name="n">Argument of function P</param>
        /// <returns>Returns the value of the P function for a given argument</returns>
        public static double P(int n)
        {
            double result = 1;
            for (double i = 1; i <= n; i++)
            {
                result = result * (1-1/(2*i));
            }
            return result;
        }
    }
}