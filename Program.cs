using System;

namespace övning
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"15+20+13={Addera(15,20,13)}");
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int a = tal1 + tal2 + tal3;
            return a;
        }
    }
}