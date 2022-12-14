using System;
using System.Linq.Expressions;

namespace tba
{
    class program
    {

        static int Elva(int result, int card)
        {
            result += card;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 21:an!");
            Random rand = new Random();
            string winner = "";
            int player = 0;
            int comp = 0;
            bool cae = true;
            bool choose = true;
            bool con = true;
            bool name = true;
            int result = 11;
            while (con)
            {
                result = 0;
                try
                {
                    Console.WriteLine("Välj ett alternativ\n1. Spela 21:an\n2. Visa senaste vinnaren\n3. Spelets regler\n4. Avsluta programmet");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            player = rand.Next(1, 10) + rand.Next(1, 10);
                            comp = rand.Next(1, 10);
                            Console.WriteLine($"Nu kommer två kort dras per spelare\nDin poäng: {player}\nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");

                            while (choose && player < 22)
                            {
                                string cho = Console.ReadLine().ToLower();
                                Console.Clear();
                                if (cho == "j")
                                {
                                    int card = rand.Next(1, 10);
                                    player += card;
                                    if (card == 1 && player + 11 < 22 || !cae)
                                    {
                                        result = Elva(result, card);
                                        Console.WriteLine($"Ditt nya kort är värt {card}\nDin totalpoäng är {player} eller {result}\nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");
                                        cae = false;
                                        if (result > 21)
                                        {
                                            cae = true;
                                        }
                                    }
                                     else if (cae)
                                    {
                                        Console.WriteLine($"Ditt nya kort är värt {card}\nDin totalpoäng är {player}\nDatorns poäng: {comp}\nVill du ha ett till kort? (j/n)");
                                    }
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
                            if (player > comp && player < 22 || comp > 21 || comp < result)
                            {
                                Console.Clear();
                                Console.WriteLine($"Din totalpoäng är {player}\nDatorns poäng: {comp}\n");
                                Console.WriteLine("\nDu har vunnit!\nSkriv in ditt namn");
                                name = true;

                                while (name)
                                {
                                    winner = Console.ReadLine();
                                    if (winner == "")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Du måste skriva något.");
                                    }
                                    else
                                    {
                                        name = false;
                                    }
                                    Console.Clear();
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
                                Console.Clear();
                                Console.WriteLine("ingen har vunnit än.\n");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Den sista vinnaren är: {winner}\n");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\nMålet i Blackjack är att få en bättre hand än dealern." +
                                "\nFör att göra det, måste du ha en hand som är högre än dealerns, utan att handens totala värde överstiger 21." +
                                "\nDu kan även vinna genom att ha ett totalt värde under 22 när det totala värdet på dealerns hand överstiger 21.\n");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            con = false;
                            Console.WriteLine("Stänger ner");
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
