using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyLib
{
    /// Calculation of mathematical functions
    public class MySin
    {
        /// <summary>
        /// Sin(x)
        /// </summary>
        /// <param name="x">the angle in radians - the first argument of the Sin function</param>
        /// <param name="n">the exponent - the second argument of the Sin function</param>
        /// <returns>Returns the value of the Sin function for a given angle</returns>
        public static double Sin(double x, int n)
        {
            double result = 0;
            for (int i=0; i<n; i++)
            {
                result = result + (Math.Pow((-1), i) * Math.Pow(x, (2 * i + 1))) / F(2 * i + 1);
            }
            return result;
        }
        static double F(int n)
        {
            double tmp = 1;
            for(int i=1; i<=n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }

    }
}
