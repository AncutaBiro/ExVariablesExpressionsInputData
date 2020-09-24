//a number raised to the power of 2

using System;

namespace ExVariablesExpressionsInputData
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDataA = Console.ReadLine();
            double a = Convert.ToDouble (inputDataA);

            Console.WriteLine(Math.Pow(a, 2));
            Console.Read();
 
        }
    }
}
