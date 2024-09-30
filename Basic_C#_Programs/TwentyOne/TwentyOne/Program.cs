using System;
using System.Collections.Generic;

namespace TwentyOne
{
     class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }  
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle (Deck deck) { 
        
            List<Card> Templist = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                Templist.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = Templist;
            return deck;
        }
    }
}
