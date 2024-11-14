using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
namespace Upgift3_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("låten ska minst vara 2 minuter 45 sekunder lång");
            Console.WriteLine("och mäst vara 4 minuter och 20 sekunder lång");
            Console.WriteLine("skriv här nedan hur många minuter din låt är i heltal");
            int X = int.Parse(Console.ReadLine());
            if (X == 3)
            {
                Console.WriteLine("Okej vi spelar up din låt");
                Console.ReadKey();
            }
            else if (X == 2)
            {
                Console.WriteLine("hur många sekunder är låten");
                int Y = int.Parse(Console.ReadLine());
                if (Y <= 45)
                {
                    Console.WriteLine("låten får vara med");
                }
                else
                {
                    Console.WriteLine("Tyvär det är förkort");
                }
            
            }
            else if (X == 4)
            {
                Console.WriteLine("hur många sekunder är låten");
                int Z = int.Parse(Console.ReadLine());
                if (Z <= 20)
                {
                    Console.WriteLine("låten får vara med");
                }
                else
                {
                    Console.WriteLine("tyvär låten är för lång");
                }

            }
            else
            {
                Console.WriteLine("låten är altingen för lång eller för kort");
            }
        }
    }
}