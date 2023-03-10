using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
       public List<string[]> Bloglista = new List<string[]>();

        public static void Mymethode1()
        {
            Console.Clear();
            Console.WriteLine("Skriv:\n1. För att skriva en blogg\n2. För att visa bloggen\n3. För söka efter bloggen\n4. För att avsluta programet");
        }

        public void Mymethode2()
        {
            int chose = int.Parse(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default
                    break;
            }
        }
        public string write()
        {

        }
    }
}
