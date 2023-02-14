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
        /// Calculates and returns the sum of the given numbers when added
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <returns>The sum of both numbers when added</returns>
        public static double Add(double a, double b)
        {
            // Calculate and return the sum            
            return a + b;
        }

        /// <summary>
        /// Calculates and returns the sum of the given numbers when subtracted
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <returns>The sum of both numbers when subtracted</returns>
        public static double Subtract(double a, double b)
        {
            // Calculate and return the sum            
            return a - b;
        }

        /// <summary>
        /// Calculates and returns the product of the given numbers when multiplied
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <returns>The sum of both numbers when multiplied</returns>
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
