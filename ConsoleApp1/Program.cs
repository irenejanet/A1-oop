using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing();
        }

        static void Testing()
        {
          Pack packofcard = new Pack(); //Creating a pack object

         
          Console.Clear();
          Console.WriteLine("WELOME TO THE CARD GAME");
          Console.WriteLine("");
          Console.WriteLine("1. Fisher Yates Shuffle  ");
          Console.WriteLine("2. Riffle Shuffle");
          Console.WriteLine("3. No shuffle");
          Console.WriteLine("4. Deal one card ");
          Console.WriteLine("5. Deal multiple cards");
          Console.WriteLine("Please type (1, 2, 3, 4 or 5 ) ");
          string Choice;
          Choice = Console.Readline()
           switch(Choice)
           {
                case "1":
                    Pack.shuffleCardPack(1);
                    break;
                case "2":
                    Pack.shuffleCardPack(2);
                    break;
                case "3":
                    Pack.shuffleCardPack(3);
                    break;
                case "4":
                    Pack.deal();
                    break;
                case "5":
                    Pack.dealcard(7); // Deals 7 cards
                    break;


           }
        }

    }
}
