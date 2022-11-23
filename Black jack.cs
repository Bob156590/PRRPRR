using System;
namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 21:an!");
            Random rand = new Random();
            string winner = "";
            int player = 0;
            int comp = 0;
            int qween = 10;
            int king = 10;
            int knight = 10;
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, king, qween, knight };
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

                        while (cho == "j" && player < 22)
                        {
                            int card = rand.Next(cards.Length);
                            player += card;
                            Console.WriteLine($"Ditt nya kort är värt {card}\nDin totalpoäng är {player}\nDin poäng: 12\nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");
                            cho = Console.ReadLine().ToLower();
                        }
                        while (comp < player && comp < 22 && player < 22)
                        {
                            int card = rand.Next(cards.Length);
                            comp += card;
                            Console.WriteLine($"Ditt nya kort är värt {card}\nDin totalpoäng är {player}\nDin poäng: 12\nDatorns poäng: {comp}");
                        }
                        if (player > comp && player < 22 || comp > 21)
                        {
                            Console.WriteLine("\nDu har vunnit!\nSkriv in ditt namn");
                            winner = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Du har förlorat");
                        }
                        break;

                    case 2:
                        if (winner == "")
                        {
                            Console.WriteLine("ingen har vunnit än.\n");
                        }
                        else
                        {
                            Console.WriteLine($"Den sista vinnaren är: {winner}\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nMålet i Blackjack är att få en bättre hand än dealern." +
                            "\nFör att göra det, måste du ha en hand som är högre än dealerns, utan att handens totala värde överstiger 21." +
                            "\nDu kan även vinna genom att ha ett totalt värde under 22 när det totala värdet på dealerns hand överstiger 21.\n");
                        break;
                    case 4:
                        con = false;
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
