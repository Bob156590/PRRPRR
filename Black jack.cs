using System;
using System.Linq.Expressions;

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
            bool choose = true;
            bool con = true;
            bool mmm = true;
            while (con)
            {
                choose = true;
                try
                {
                    Console.WriteLine("Välj ett alternativ\n1. Spela 21:an\n2. Visa senaste vinnaren\n3. Spelets regler\n4. Avsluta programmet");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            player = rand.Next(1, 10) + rand.Next(1, 10);
                            comp = rand.Next(1, 10) + rand.Next(1, 10);
                            Console.WriteLine($"Nu kommer två kort dras per spelare\nDin poäng: {player} \nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");

                            while (choose && player < 22)
                            {
                                string cho = Console.ReadLine().ToLower();
                                if (cho == "j")
                                {
                                    int card = rand.Next(1, 10);
                                    player += card;
                                    Console.Clear();
                                    Console.WriteLine($"Ditt nya kort är värt {card}\nDin totalpoäng är {player}\nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");
                                }
                                else if (cho == "n")
                                {
                                    choose = false;
                                }
                                else
                                {
                                    Console.WriteLine("Du kan bara skriva j/n");
                                }

                            }
                            while (comp < player && comp < 22 && player < 22)
                            {
                                int card = rand.Next(1, 10);
                                comp += card;
                            }
                            if (player > comp && player < 22 || comp > 21)
                            {
                                Console.Clear();
                                Console.WriteLine($"Din totalpoäng är {player}\nDatorns poäng: {comp}\n");
                                Console.WriteLine("\nDu har vunnit!\nSkriv in ditt namn");
                                mmm = true;

                                while (mmm)
                                {
                                    winner = Console.ReadLine();
                                    if (winner == "")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Du måste skriva något.");
                                    }
                                    else
                                    {
                                        mmm = false;
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Din totalpoäng är {player}\nDatorns poäng: {comp}\n");
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
                        default:
                            Console.Clear();
                            Console.WriteLine("Du kan bara välja mellan 1-4.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("Skriva bara tall snälla.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.ReadKey();

        }
    }
}
