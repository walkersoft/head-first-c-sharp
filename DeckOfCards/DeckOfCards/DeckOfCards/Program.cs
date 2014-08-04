using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            CardSorter cardSorter = new CardSorter();


            while (Console.OpenStandardInput() != null)
            {
                MakeFiveCards(cards);
                PrintCards(cards);
                cards.Sort(cardSorter);
                PrintCards(cards);
                Console.ReadKey();
            }
        }

        public static void MakeFiveCards(List<Card> list)
        {
            list.Clear();
            Random random = new Random();
            for (int i = 0; i < 5; i++) 
            { 
                Card card = new Card((Suit)random.Next(4), (Value)random.Next(1, 14));
                list.Add(card);
            }
        }

        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }
            Console.WriteLine("There's your hand!");
            Console.WriteLine("");
        }
    }
}
