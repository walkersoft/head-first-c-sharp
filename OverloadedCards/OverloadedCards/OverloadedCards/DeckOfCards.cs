using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadedCards
{
    public partial class DeckOfCards : Form
    {
        private Deck deckOfCards1;
        private Deck deckOfCards2;
        private Random random = new Random();

        public DeckOfCards()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        public void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                deck1.Items.Clear();
                foreach (string cardName in deckOfCards1.GetCardNames())
                {
                    deck1.Items.Add(cardName);
                }
                deck1Label.Text = "Deck #1 (" + deckOfCards1.Count + " cards)";
            }
            else
            {
                deck2.Items.Clear();
                foreach (string cardName in deckOfCards2.GetCardNames())
                {
                    deck2.Items.Add(cardName);
                }
                deck2Label.Text = "Deck #2 (" + deckOfCards2.Count + " cards)";
            }
        }

        public void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deckOfCards1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deckOfCards1.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                }
                deckOfCards1.Sort();
            }
            if (deckNumber == 2)
            {
                deckOfCards2 = new Deck();
            }
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deckOfCards1.Shuffle();
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deckOfCards2.Shuffle();
            RedrawDeck(2);
        }

        private void moveCardRight_Click(object sender, EventArgs e)
        {
            if (deck1.SelectedIndex >= 0)
            {
                if (deckOfCards1.Count > 0)
                {
                    deckOfCards2.Add(deckOfCards1.Deal(deck1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveCardLeft_Click(object sender, EventArgs e)
        {
            if (deck2.SelectedIndex >= 0)
            {
                if (deckOfCards2.Count > 0)
                {
                    deckOfCards1.Add(deckOfCards2.Deal(deck2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}
