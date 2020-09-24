using System;

namespace ExVariablesExpressionsInputData
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDataA = Console.ReadLine();
            int a = Convert.ToInt32(inputDataA);

            string inputDataB = Console.ReadLine();
            int b = Convert.ToInt32(inputDataB);

            Console.WriteLine(a+b);
            Console.Read();
       
        }
    }
}
