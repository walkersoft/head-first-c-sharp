using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedCards
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

        public static bool CardDoesMatch(Card card, Suit suit)
        {
            if (card.Suit == suit)
            {
                return true;
            }
            return false;
        }

        public static bool CardDoesMatch(Card card, Value value)
        {
            if (card.Value == value)
            {
                return true;
            }
            return false;
        }
    }
}
