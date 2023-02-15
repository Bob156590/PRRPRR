using System;

namespace Uppgift_6._6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write two texts and this program will show which one is bigger");
            Längst(Console.ReadLine());
        }
        static void Längst(string text1)
        {
            bool check = true;
            for (int i = 0; i < text1.Length; i++)
            {
                if (check == true)
                {
                    if (text1[i] == ' ')
                    {
                        check = false;
                        Console.Write(" ");
                        continue;
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
                        continue;
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
