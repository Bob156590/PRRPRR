using System;
namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 21:an!");
            Random rand = new Random();
            int player = 0;
            int comp = 0;
            int qween = 10;
            int king = 10;
            int knight = 10;
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, king, qween, knight};
            bool con = true;
            while (con)
            {
                Console.WriteLine("Välj ett alternativ\n1. Spela 21:an\n2. Visa senaste vinnaren\n3. Spelets regler\n4. Avsluta programmet");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        player = rand.Next(cards.Length) + rand.Next(cards.Length);
                        comp = rand.Next(cards.Length) + rand.Next(cards.Length);
                        Console.WriteLine($"Nu kommer två kort dras per spelare\nDin poäng: {player} \nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");
                        string cho = Console.ReadLine().ToLower();
                        
                        while ( cho == "j")
                        {
                            Console.WriteLine($"Ditt nya kort är värt 8 poäng\nDin totalpoäng är 12\nDin poäng: 12\nDatorns poäng: 15\nVill du ha ett till kort? (j/n)");
                        }
                        break;
                }
                con = false;
            }

        }
    }
}