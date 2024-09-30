using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }

        public Card ()
        {
            Suit = "Spades";
            Face = "Two";
        }
    }
}
