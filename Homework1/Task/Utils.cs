using System.Collections.Generic;
using System.Linq;

namespace Homework1.Task
{
    public static class Utils
    {

        /// <summary>
        /// Calculates factorial value for given number.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Final factorial value.</returns>
        public static long GetFactorial(int value)
        {
            return Enumerable.Range(1, value).Aggregate((a, b) => a * b);
        }
    }
}
