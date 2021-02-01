using System;

namespace SzkolaDotneta_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pętla WHILE - nie wiemy ile razy dokładnie dane instrukcje będą wykonywane
            {
                /*
                int a = 0;
                while (a < 10)
                {
                    Console.WriteLine("Liczba a ma wartość: " + a);
                    a++;
                }
            */
            }
            
            Console.WriteLine("");

            // Pętla nieskończona - nie ma warunku wyjścia z pętli
            {
                /*
                while (a % 2 == 0)
                {
                    Console.WriteLine("Liczba a: " + a);
                    a += 2;
                }
                */
            }

            // Pętla DO WHILE - zawsze przynajmniej 1 przejście pętli, bo warunek spr. na końcu
            {
            /*
            int b = 0;
            do
            {
                Console.WriteLine($"Liczba b wynosi: {b}");
                b++;
            }
            while (b < 10);
                */
            }

            // Pętla FOR - określona ilość razy wykonania
            {
                for (int i = 0; i < 10; i ++)
                {
                    Console.WriteLine($"Liczba i: {i}");
                }    
            }
        }
    }
}
