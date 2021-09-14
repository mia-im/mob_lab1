using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyLib
{
    /// Finding the brick fall time
    public class MyT
    {
        /// <summary>
        /// t
        /// </summary>
        /// <param name="h">Building height (meters)</param>
        /// <param name="g">Acceleration of gravity</param>
        /// <returns>Returns the value of the T function for the specified variables</returns>
        public static double T(double h, double g)
        {
            double result = Math.Sqrt(2 * h / g);
            return result;
        }
    }
}
