using System;

namespace upggift_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två heltal:");
            Console.WriteLine($"{AREA(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))}");
        }
        static int AREA(int tal1, int tal2)
        {
            int a = tal1 * tal2;
            return a;
        }
    }
}