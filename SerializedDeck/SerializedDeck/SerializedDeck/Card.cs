using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializedDeck
{
    [Serializable]
    public class Card : IComparable<Card>
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

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
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

        public static string Plural(Value value) 
        {
            if (value == Value.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
