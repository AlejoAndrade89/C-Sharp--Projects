﻿using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            deck.Shuffle();


            foreach (Card card in deck.Cards)
                {
                    Console.WriteLine(card.Face + " of " + card.Suit);

                }  
                Console.WriteLine(deck.Cards.Count);
                Console.ReadLine();
            }

        }
    }
