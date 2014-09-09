﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializedDeck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Deck deck;

        Random random = new Random();
        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card(
                    (Suit)random.Next(4),
                    (Value)random.Next(1, 14)
                ));
            }
            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("--------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deck = RandomDeck(random.Next(15));
            MessageBox.Show("Deck Created");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DealCards(deck, "Show Me The Deck!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Create("cards.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, deck);
            }
            DealCards(deck, "Deck that was serialized");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.OpenRead("cards.dat"))
            {
                BinaryFormatter br = new BinaryFormatter();
                deck = (Deck)br.Deserialize(stream);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("ManyDecks.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    bf.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Deck #" + i + " written");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("ManyDecks.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, "Deck #" + i + " read");
                }
            }
        }
    }
}