using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> pack;

        public Pack()
        {
            pack = new List<Card>();
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    pack.Add(new Card(i, j));
                }
            }
        }

        public bool ShuffleCardPack(int typeOfShuffle)
        {
            Random rand = new Random();
            switch (typeOfShuffle)
            {
                case 1: // Fisher-Yates Shuffle
                    for (int i = pack.Count - 1; i > 0; i--)
                    {
                        int j = rand.Next(i + 1);
                        Card temp = pack[i];
                        pack[i] = pack[j];
                        pack[j] = temp;
                    }
                    return true;
                case 2: // Riffle Shuffle
                    // Implement Riffle Shuffle here
                    return true;
                case 3: // No Shuffle
                    return true;
                default:
                    return false;
            }
        }

        public Card DealCard()
        {
            if (pack.Count > 0)
            {
                Card card = pack[0];
                pack.RemoveAt(0);
                return card;
            }
            else
            {
                return null;
            }
        }

        public List<Card> DealCard(int amount)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                Card card = DealCard();
                if (card != null)
                {
                    cards.Add(card);
                }
                else
                {
                    break;
                }
            }
            return cards;
        }

        public List<Card> GetPack()
        {
            return pack;
        }
    }
}
