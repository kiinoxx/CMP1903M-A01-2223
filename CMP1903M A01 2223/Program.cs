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
            Pack pack = new Pack();

            Console.WriteLine("Welcome to the card shuffling and dealing application!");
            Console.WriteLine("The pack contains {0} cards.", pack.GetPack().Count);
            Console.WriteLine();

            ProgramTest.RunTests();

            bool exit = false;
            while (!exit)
            {
                bool validInput = false;
                int shuffleType = 0;
                while (!validInput)
                {
                    Console.WriteLine("Please select a shuffle type:");
                    Console.WriteLine("1: Fisher-Yates Shuffle");
                    Console.WriteLine("2: Riffle Shuffle");
                    Console.WriteLine("3: No Shuffle");
                    Console.WriteLine("4: Exit");
                    Console.Write("Enter your choice: ");

                    string input = Console.ReadLine();
                    if (int.TryParse(input, out shuffleType) && shuffleType >= 1 && shuffleType <= 4)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    }
                }

                if (shuffleType == 4)
                {
                    Console.WriteLine("Exiting the application...");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Shuffling the pack...");
                    bool success = pack.ShuffleCardPack(shuffleType);
                    if (success)
                    {
                        Console.WriteLine("The pack has been shuffled.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to shuffle the pack.");
                    }

                    Console.WriteLine("Dealing one card:");
                    Card dealtCard = pack.DealCard();
                    if (dealtCard != null)
                    {
                        Console.WriteLine("The card dealt is: {0}", dealtCard.GetCard());
                    }
                    else
                    {
                        Console.WriteLine("Failed to deal a card.");
                    }

                    Console.WriteLine("Dealing five cards:");
                    List<Card> dealtCards = pack.DealCard(5);
                    if (dealtCards.Count > 0)
                    {
                        Console.WriteLine("The cards dealt are:");
                        foreach (Card card in dealtCards)
                        {
                            Console.WriteLine(card.GetCard());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed to deal any cards.");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
