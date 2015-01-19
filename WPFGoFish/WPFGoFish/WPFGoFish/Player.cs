﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGoFish
{
    public class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private Game game;
        //private TextBox textBoxOnForm;

        public Player(string name, Random random, Game game) //, TextBox textBoxOnForm)
        {
            /* The constructor for the Player class initializes four private fields, and then
             * adds a line to the TextBox control on the form that says, "Joe has just
             * joined the game" - but use the name in the private field, don't forget to
             * add a line break at the end of every line you add ot the TextBox
             */
            this.name = name;
            this.random = random;
            this.game = game;
            //this.textBoxOnForm = textBoxOnForm;
            cards = new Deck(new List<Card>());
            game.AddProgress(Name + " has just joined the game.");
            //textBoxOnForm.Text += Name + " has just joined the game" + Environment.NewLine;
        }

        public IEnumerable<Value> PullOutBooks()
        {
            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Value GetRandomValue()
        {
            //This method gets a random value - but it has to be a value that's in the deck
            Card card = cards.Peek(random.Next(cards.Count));
            return card.Value;
        }

        public Deck DoYouHaveAny(Value value)
        {
            /* This is where an opponent asks if I have any cards of a certain value
             * Use Deck.PullOutValues() to pull out the values.  Add a line to the TextBox
             * that says, "Joe has 3 sixes " - use the new Card.Plural() static method
             */
            Deck found = cards.PullOutValues(value);
            game.AddProgress(Name + " has " + found.Count + " " + Card.Plural(value) + ".");
            //textBoxOnForm.Text += Name + " has " + found.Count + " " + Card.Plural(value) + "." + Environment.NewLine;
            return found;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            /* Overloaded method - choose a random value from the deck using GetRandomValue()
             * and then ask for it with AskForACard()
             */
            if (cards.Count > 0)
            {
                Value value = GetRandomValue();
                AskForACard(players, myIndex, stock, value);
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Value value)
        {
            /* Ask the other players for a value.  First add a line to the TextBox: "Joe asks
             * if anyone has a Queen". Then go therough the list of players that was passed in
             * as a parameter and ask each player if he has any of the value (using his
             * DoYouHaveAny() method.  He'll pass you a deck of cards - add them to my deck.
             * Keep track of how many cards were added. If there weren't any, you need to deal 
             * yourself a card from the stock (which was also passed as a parameter),
             * and you'll have to add a line to the TextBox: "Joe had to draw from the stock"
             */
            game.AddProgress(Name + " asks if anyone has a " + value + ".");
            //textBoxOnForm.Text += Name + " asks if anyone has a " + value + Environment.NewLine;
            int myCount = cards.Count;
            for(int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Deck found = players[i].DoYouHaveAny(value);
                    if (found.Count > 0)
                    {
                        for (int j = 0; j < found.Count; j++)
                            cards.Add(found.Deal());
                    }
                }
            }
            if (cards.Count == myCount)
            {
                if (stock.Count > 0)
                {
                    cards.Add(stock.Deal());
                    game.AddProgress(Name + " had to draw a card.");
                    //textBoxOnForm.Text += Name + " had to draw a card" + Environment.NewLine;
                }
            }
        }

        // Here's a property and a few short methods that were written for you

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

    }
}
