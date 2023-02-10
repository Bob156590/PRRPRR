using System;

namespace Uppgift_6._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write two texts and this program will show which one is bigger");
            Längst();
        }
        static void Längst()
        {
            string taxt1 = Console.ReadLine();
            bool check = true;
            for (int i = 0; i < text1.Length; i++)
            {
                if (check)
                {
                    if (text1[i] == ' ')
                    {
                        check = false;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(text1.ToUpper()[i]);
                    }
                }
                if (check == false)
                {
                    if (text1[i] == ' ')
                    {
                        check = true;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(text1.ToLower()[i]);
                    }
                }
            }
        }
    }
}
