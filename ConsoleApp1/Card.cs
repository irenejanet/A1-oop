using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private int _value_ { get; set; } //feild 
        private int _suit_ { get; set; }  //feild
        public int Value
        {
            get { return _value_; }
            set
            {
                if (value >= 1 && value <= 13)
                {
                    _value_ = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
        }
        public int Suit
        {
            get { return _suit_; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    _suit_ = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
        }
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

    }
}
