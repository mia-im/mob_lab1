using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyLib
{
    /// Calculation of a line
    public class MyF
    {
        /// <summary>
        /// F
        /// </summary>
        /// <param name="z">an argument of the function</param>
        /// <param name="e">calculation accuracy</param>
        /// <returns>Returns the value of the F function for a given angle</returns>
        public static double F(double z, double e)
        {
            double fact = 1; 
            double result = 0; 
            double a = 1; 
            int i = 1; 
            while (a>=e)
            {
                result = result + a; //the sum of the line
                a = (2 * i + 1) * Math.Pow(z, 2 * i) / fact; //the member of the line
                fact = fact * (i + 1); // calculate the factorial
                i++;
            }
            return result;
        }
    }
}
