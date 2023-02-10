using System;

namespace Uppgift_6._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write two texts and this program will show which one is bigger");
            Console.WriteLine(Längst(Console.ReadLine(), Console.ReadLine()));
        }
        static string Längst(string text1, string text2)
        {
            if (text1.Length > text2.Length)
            {
                return text1;
            }
            else if(text1.Length < text2.Length)
            {
                return text2;
            }
            else
            {
                return text1;
            }
        }
    }
}