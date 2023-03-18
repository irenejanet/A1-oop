using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
        public static List<Card> Firsthalf = new List<Card>();
        public static List<Card> Secondhalf = new List<Card>();
       

        public Pack()
        {
            for (int Value = 1; Value < 14; Value++)
            {
                for (int Suit = 1; Suit < 5; Suit++)
                {
                    pack.Add(new Card(Value, Suit));
                }
            }

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1) //Fisher Yates Shuffle
            {
                LEN_OF_PACK = pack.Count();
                int last_index = LEN_OF_PACK - 1;
                while (last_index > 0)
                {
                    Random random_num = new Random();
                    for (int i = 0; i < last_index; i++)
                    {
                        int j = random_num.Next(i, last_index);
                        temp_var = pack[i];
                        pack[i] = pack[j];
                        pack[j] = temp_var;
                    }
                    return true;
                }
            }

            else if (typeOfShuffle == 2) //Riffle shuffle
            {

                //Dividing the deck of cards into two
                Left = GetRange(0, 26);
                Right = GetRange(26, 26);

                Firsthalf.AddRange(pack.Left); //First half of the deck
                Secondhalf.AddRange(pack.Right); //Second half of the deck

                // Adding the card alternatively from both the pile
                int i, j, k = 1, n = 25;
                for (i = 0; i < 26; i++)
                {
                    for (j = n; j >= k; j--)
                    {
                        Firsthalf[j + 1] = Firsthalf[j];
                    }
                    Firsthalf[k] = Secondhalf[i];
                    k = k + 2;
                    n = n + 1;
                }
                return true;

            }

            else if (typeOfShuffle == 3) //No shuffle
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public static Card deal()
        {
                if (pack.Count > 0)
                {
                    Card firstcard = pack[0];
                    pack.RemoveAt(0); //Removes the first card of the deck
                    return firstcard;
                }
                else
                {
                    return null;
                }
      
        }

        public static List<Card> dealCard(int amount)
        {
         //Deals the number of cards specified by 'amount'
          for (int i=1; i<=amount; i++)
          {
                if (pack.Count > 0)
                {
                    Card DesiredCards = pack[0];
                    pack.RemoveAt(0);
                    return DesiredCards;
                }
                else
                {
                    return null;
                }

          }

        }
    }
}
