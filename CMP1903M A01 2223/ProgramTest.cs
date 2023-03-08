using CMP1903M_A01_2223;
using System.Collections.Generic;
using System;

class ProgramTest
{
    public static void RunTests()
    {
        Pack pack = new Pack();

        // Test shuffling the pack with each shuffle type
        bool success = pack.ShuffleCardPack(1); // Fisher-Yates Shuffle
        Console.WriteLine("Fisher-Yates shuffle test: " + (success ? "Passed" : "Failed"));
        success = pack.ShuffleCardPack(2); // Riffle Shuffle
        Console.WriteLine("Riffle shuffle test: " + (success ? "Passed" : "Failed"));
        success = pack.ShuffleCardPack(3); // No Shuffle
        Console.WriteLine("No shuffle test: " + (success ? "Passed" : "Failed"));

        // Test dealing one card
        Card dealtCard = pack.DealCard();
        Console.WriteLine("Dealing one card test: " + (dealtCard != null ? "Passed" : "Failed"));

        // Test dealing five cards
        List<Card> dealtCards = pack.DealCard(5);
        Console.WriteLine("Dealing five cards test: " + (dealtCards.Count == 5 ? "Passed" : "Failed"));

        // Test dealing more cards than are left in the pack
        pack.ShuffleCardPack(1); // Fisher-Yates Shuffle
        int initialPackSize = pack.GetPack().Count;
        dealtCards = pack.DealCard(initialPackSize + 5);
        Console.WriteLine("Dealing more cards than are left in the pack test: " + (dealtCards.Count == initialPackSize ? "Passed" : "Failed"));


        // Test shuffling an empty pack
        pack.GetPack().Clear();
        success = pack.ShuffleCardPack(1); // Fisher-Yates Shuffle
        Console.WriteLine("Shuffling an empty pack test: " + (success ? "Passed" : "Failed"));
    }
}
