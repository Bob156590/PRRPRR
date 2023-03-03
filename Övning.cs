using System;
using System.Collections.Generic;

namespace övning
{
    class program
    {
        static void Main(string[] args)
        {
            car car1 = new car();

            Console.Write($"Tillvarkaren: ");
            car1.tilvarkare = Console.ReadLine();
            Console.Write($"Modell: ");
            car1.modell = Console.ReadLine();
            Console.Write($"Årsmodell: ");
            car1.år = int.Parse(Console.ReadLine());
            Console.Write($"Vikt: ");
            car1.vikt = int.Parse(Console.ReadLine());
            car1.Read();
        }
    }
    class car
    {
        public string tilvarkare;
        public string modell;
        public int år;
        public int vikt;

        public void Read()
        {
            Console.WriteLine($"\nTilvarkare: {tilvarkare}\nModell: {modell}\nÅrsmodell: {år}\nVikt: {vikt}kg");
        }
    }
}
