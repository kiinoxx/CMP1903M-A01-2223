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
                    List<Card> topHalf = new List<Card>();
                    List<Card> bottomHalf = new List<Card>();
                    int cutPoint = rand.Next(1, pack.Count - 1);
                    for (int i = 0; i < cutPoint; i++)
                    {
                        topHalf.Add(pack[i]);
                    }
                    for (int i = cutPoint; i < pack.Count; i++)
                    {
                        bottomHalf.Add(pack[i]);
                    }
                    pack.Clear();
                    while (topHalf.Count > 0 || bottomHalf.Count > 0)
                    {
                        if (topHalf.Count > 0)
                        {
                            int takeCount = rand.Next(1, Math.Min(4, topHalf.Count + 1));
                            for (int i = 0; i < takeCount; i++)
                            {
                                pack.Add(topHalf[0]);
                                topHalf.RemoveAt(0);
                            }
                        }
                        if (bottomHalf.Count > 0)
                        {
                            int takeCount = rand.Next(1, Math.Min(4, bottomHalf.Count + 1));
                            for (int i = 0; i < takeCount; i++)
                            {
                                pack.Add(bottomHalf[0]);
                                bottomHalf.RemoveAt(0);
                            }
                        }
                    }
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
