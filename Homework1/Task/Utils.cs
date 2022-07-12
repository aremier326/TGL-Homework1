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

        /// <summary>
        /// Generates a Fibonacci sequence with given length.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<long> GetFibonacci(int length)
        {
            var seq = new List<long>();
            Enumerable.Range(0, length)
                .ToList()
                .ForEach(num => 
                    seq.Add(num <= 1 ? 1 : seq[num - 1] + seq[num - 2]));
            return seq;
        }
    }
}
