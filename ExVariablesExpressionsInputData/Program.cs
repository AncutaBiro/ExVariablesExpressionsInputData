//După ploaie au răsărit mai multe ciuperci roșii și albe. Cele roșii sunt de X ori mai multe decât cele albe.
//Scrie o aplicație ce primește ca date de intrare numărul total de ciuperci și numărul X și întoarce numărul de ciuperci roși.
//Datele de intrare se vor citi de la tastatură, câte un număr pe linie.
//Exemplu:
//Pentru datele de intrare:
//10
//4
//La consolă se va afișa:
//8

using System;

namespace ExVariablesExpressionsInputData
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int totalMushrooms = Convert.ToInt32(inputData);

            inputData = Console.ReadLine();
            int timesWhiteMushrooms = Convert.ToInt32(inputData);

            int whiteMushrooms = totalMushrooms / (1 + timesWhiteMushrooms);
            int redMushrooms = timesWhiteMushrooms * whiteMushrooms;

            Console.WriteLine(redMushrooms);
            Console.Read();
        }
        }
    }
