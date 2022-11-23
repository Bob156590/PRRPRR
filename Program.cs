using System;
using System.Globalization;

namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 21:an!");
            Random rand = new Random();
            int[] numbers = new int[5] { 32, 67, 88, 13, 50 };
            Random rd = new Random();
            int randomIndex = rd.Next(0, 5);
            int randomNumber = numbers[randomIndex];
            Console.WriteLine(randomNumber);
            int player = 0;
            int comp = 0;
            int qween = 10;
            int king = 10;
            int knight = 10;
            int[] cards = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, king, qween, knight };
            bool con = true;
            int j = 0;
            while (j > 5)
            {
                Console.WriteLine(rand.Next(cards[]));
                j++;
            }

        }
    }
}
