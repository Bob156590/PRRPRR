using System;

namespace Uppgift_6._3
{
    class program
    {
        static void Main(string[] args)
        {
            bool mm = true;
            while (mm)
            {
                Console.WriteLine("1. Addera tre tal\n2. Största talet av två tal\n3. Avsluta programmet");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        MenyvalAddera();
                        break;
                    case "2":
                        Console.Clear();
                        MenyvalStörstaTalet();
                        break;
                    case "3":
                        mm = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("du kan bara skriva 1-3");
                        break;
                }
            }
        }
        static void MenyvalAddera()
        {
            Console.WriteLine("Write three numbers and we wil sort out the bigger one");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1}+{tal2}+{tal3}={tal1+tal2+tal3}");

        }
        static void MenyvalStörstaTalet()
        {
            Console.WriteLine("Write two numbers and we wil sort out the bigger one");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            if (tal1 == tal2)
            {
                Console.WriteLine(tal1);
            }
            else if (tal2 > tal1)
            {
                Console.WriteLine(tal2);
            }
            else
            {
                Console.WriteLine(tal1);
            }
        }
    }
}
