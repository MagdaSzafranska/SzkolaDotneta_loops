using System;

namespace SzkolaDotneta_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            // Pętla WHILE - nie wiemy ile razy dokładnie dane instrukcje będą wykonywane
            while (a < 10)
            {
                Console.WriteLine("Liczba a ma wartość: " + a);
                a++;
            }
        }
    }
}
