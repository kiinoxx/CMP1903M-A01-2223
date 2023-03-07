using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public string GetCard()
        {
            string valueString;
            switch (Value)
            {
                case 1:
                    valueString = "Ace";
                    break;
                case 11:
                    valueString = "Jack";
                    break;
                case 12:
                    valueString = "Queen";
                    break;
                case 13:
                    valueString = "King";
                    break;
                default:
                    valueString = Value.ToString();
                    break;
            }

            string suitString;
            switch (Suit)
            {
                case 1:
                    suitString = "Hearts";
                    break;
                case 2:
                    suitString = "Diamonds";
                    break;
                case 3:
                    suitString = "Clubs";
                    break;
                case 4:
                    suitString = "Spades";
                    break;
                default:
                    suitString = "";
                    break;
            }

            return valueString + " of " + suitString;
        }
    }
}
