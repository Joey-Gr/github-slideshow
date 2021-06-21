using System;
using System.IO;

namespace ex_1_carre
{
    class Program
    {
        static void Main(string[] args)
        {
            //the algo version I wrote on paper

            int nb;
            int x;

            Console.WriteLine("Saisir un nombre a calculer en carre: ");
            nb = Convert.ToInt32(Console.ReadLine()); //Allows user to convert a given number to the "nb" variable

            x = nb * nb;
            Console.WriteLine(x);
        }
    }
}
