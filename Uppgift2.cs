using System;

namespace upggift_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Omvandla från Celsius till Fahrenheit\n2: Omvandla från Fahrenheit till Celsius\nVilken omvandling vill du göra? Skriv 1 eller 2:");
            switch (Console.ReadLine())
            {
                case "1":;
                    Console.Clear();
                    Console.WriteLine($"meta in Celsius för att få Fagrebgeit");
                    Console.WriteLine($"{FtillC(int.Parse(Console.ReadLine()))}F");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"meta in Fahrenheit för att få Celsius");
                    Console.WriteLine($"{FtillC(int.Parse(Console.ReadLine()))} C");
                    break;
            }
        }
        static double CtillF(double tal)
        {
            double a = 32 + tal * 1.8;
            return a;
        }
        static double FtillC(double tal)
        {
            double a = (tal-32)/1.8;
            return a;
        }
    }
}