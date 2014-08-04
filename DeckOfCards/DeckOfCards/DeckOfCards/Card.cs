using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Card : IComparable<Card>
    {
        public Suit Suit;
        public Value Value;

        public int CompareTo(Card other)
        {
            if (this.Value < other.Value)
                return -1;
            else if (this.Value > other.Value)
                return 1;
            else
                return 0;
        }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
