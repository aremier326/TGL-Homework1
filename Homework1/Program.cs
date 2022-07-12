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
                Console.WriteLine(Utils.GetFactorial(9));
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
