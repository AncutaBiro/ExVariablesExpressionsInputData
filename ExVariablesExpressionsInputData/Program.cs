// check if a number is positive or negative

using System;

namespace ExVariablesExpressionsInputData
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDataA = Console.ReadLine();
            int a = Convert.ToInt32(inputDataA);

            if (a == 0)
            {
                Console.WriteLine("0");
                Console.Read();
            }
            else if (a > 0)
            {
                Console.WriteLine("True");
                Console.Read();
            }
            else if (a < 0)
            {
                Console.WriteLine("False");
                Console.Read();
            }
        }
    }
}
