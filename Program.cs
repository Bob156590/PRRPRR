using System;

namespace Uppgift_6._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en number för att potensa");
            Console.WriteLine(power(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }
        static double power(double tal1, double tal2)
        {
            return Math.Pow(tal1,tal2);
        }
    }
}