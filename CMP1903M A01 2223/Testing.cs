using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();

            Console.WriteLine("Initial pack:");
            foreach (Card card in pack.GetPack())
            {
                Console.WriteLine(card.GetCard());
            }

            Console.WriteLine("Fisher-Yates Shuffle:");
            Pack.ShuffleCardPack(1);
            foreach (Card card in pack.GetPack())
            {
                Console.WriteLine(card.GetCard());
            }

            Console.WriteLine("Riffle Shuffle:");
            Pack.ShuffleCardPack(2);
            foreach (Card card in pack.GetPack())
            {
                Console.WriteLine(card.GetCard());
            }

            Console.WriteLine("No Shuffle:");
            Pack.ShuffleCardPack(3);
            foreach (Card card in pack.GetPack())
            {
                Console.WriteLine(card.GetCard());
            }

            Console.WriteLine("Deal one card:");
            Card dealtCard = Pack.DealCard();
            Console.WriteLine(dealtCard.GetCard());

            Console.WriteLine("Deal five cards:");
            List<Card> dealtCards = Pack.DealCard(5);
            foreach (Card card in dealtCards)
            {
                Console.WriteLine(card.GetCard());
            }

            Console.ReadLine();
        }
    }
}
