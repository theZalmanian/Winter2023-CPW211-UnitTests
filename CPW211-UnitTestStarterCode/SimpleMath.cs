using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        /// <summary>
        /// Calculates and returns the sum of the given numbers when added together
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <returns>The sum of both numbers when added together</returns>
        public static double Add(double a, double b)
        {
            // Calculate and return the sum            
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            throw new NotImplementedException();
        }

        public static double Multiply(double a, double b)
        {
            throw new NotImplementedException();
        }

        public static double Divide(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
