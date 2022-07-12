using System;

using Homework1.Task;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Factorial of 9: " + Utils.GetFactorial(9) + "\n\n");

                Console.WriteLine("Fibonacci sequence length of 20: " + "\n");

                foreach (var num in Utils.GetFibonacci(20))
                {
                    Console.WriteLine(num);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message + "\nTry passing another argument!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\nSomething unexpected happened!");
            }
        }
    }
}
