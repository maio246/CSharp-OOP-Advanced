using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static Card winningCard;
    public static string winner;

    public static void Main()
    {
        CardGame();
    }

    private static void CardGame()
    {
        var deck = FillDeck();

        var firstPlayer = Console.ReadLine();
        var secondPlayer = Console.ReadLine();

        var firstPlayerHand = new List<Card>();
        var secondPlayerHand = new List<Card>();


        FillPlayerHand(firstPlayerHand, deck, firstPlayer);
        FillPlayerHand(secondPlayerHand, deck, secondPlayer);

        Console.WriteLine($"{winner} wins with {winningCard.Rank} of {winningCard.Suit}.");
    }

    public static void FillPlayerHand(List<Card> playerHand, List<Card> deck, string playerName)
    {
        while (playerHand.Count != 5)
        {
            var inputCard = Console.ReadLine().Split();
            try
            {
                var rank = inputCard[0];
                var suit = inputCard[2];

                var card = new Card(rank, suit);

                if (deck.Contains(card))
                {
                    if (card.CompareTo(winningCard) > 0)
                    {
                        winningCard = card;
                        winner = playerName;
                    }
                    playerHand.Add(card);
                    deck.Remove(card);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("No such card exists.");
            }
        }

    }

    private static List<Card> FillDeck()
    {
        var deck = new List<Card>();

        foreach (var cardSuit in Enum.GetNames(typeof(Suit)))
        {
            foreach (var cardRank in Enum.GetNames(typeof(Rank)))
            {
                deck.Add(new Card(cardRank, cardSuit));
            }
        }
        return deck;
    }

    private static void PrintTypeAttribute()
    {
        var input = Console.ReadLine();
        if (input == "Rank")
        {
            PrintTypeAttributes(typeof(Rank));
        }
        else
        {
            PrintTypeAttributes(typeof(Suit));
        }
    }

    private static void PrintTypeAttributes(Type type)
    {
        var attributes = type.GetCustomAttributes(false);
        Console.WriteLine(attributes[0]);
    }

    private static void GetAndPrintCard()
    {
        var rank = Console.ReadLine();
        var suit = Console.ReadLine();

        Card card = new Card(rank, suit);

        var rank1 = Console.ReadLine();
        var suit1 = Console.ReadLine();

        Card card1 = new Card(rank1, suit1);

        //if (card.CompareTo(card1) > 0)
        //{
        //    Console.WriteLine(card);
        //}
        //else
        //{
        //    Console.WriteLine(card1);
        //}
    }

    private static void PrintSuits()
    {
        Console.WriteLine(Console.ReadLine() + ":");

        foreach (var cardSuit in Enum.GetValues(typeof(Suit)))
        {
            Console.WriteLine($"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
        }
    }

    private static void PrintRanks()
    {
        Console.WriteLine(Console.ReadLine() + ":");

        foreach (var cardSuit in Enum.GetValues(typeof(Rank)))
        {
            Console.WriteLine($"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
        }
    }
}