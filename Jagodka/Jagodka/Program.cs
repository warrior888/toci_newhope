using System;

namespace Jagodka
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Tablica = new[] { "ABBA", "KAWA", "ANNA", "RADAR", };
            for (int i = 0; i < Tablica.Length; i++)
            {
                //Console.WriteLine(Tablica[i]);
                if (isPalindrome(Tablica[i]))
                {
                    Console.WriteLine(Tablica[i] + " Jest palindromem");

                }


            }
            Console.ReadLine();

        }
        static bool isPalindrome(string candidate)
        {
            for (int i = 0, j = candidate.Length - 1; i < j; i++, j--)
            {
                if (candidate[i] != candidate[j])
                    return false;
            }

            return true;

        }
        

    }

}
