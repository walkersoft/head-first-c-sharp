using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public class Game
    {
        private List<Player> players;
        private Dictionary<Value, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach(string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Value, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            /* This is where the game starts - this method's only called at the beginning
             * of the game.  Shuffle the stock, deal five cards to each player, then use a 
             * foreach loop to call each player's PullOutBooks() method
             */
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                    player.TakeCard(stock.Deal());
            }
            foreach (Player player in players)
                PullOutBooks(player);
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            /* Play one round of the game.  The parameter is the card the player selected
             * from his hand - get its value.  Then go through all of the players and call
             * each one's AskForACard() methods, starting with the human player (who's
             * at index zero in the Players list - make sure he asks for the selected 
             * card's value).  Then call PullOutBooks() - if it returns true, then the 
             * player ran out of cards and needs to draw a new hand.  After all the palyers
             * have gone, sort the human' player's hand (so it looks nice in the form).
             * Then check the stock to see if it's out of cards. If it is, reset the 
             * TextBox on the form to say, "The stock is out of cards. Game Over!" and return
             * true. Otherwise, the game isn't over yet, so retn false.
             */
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                {
                    Card card = players[i].Peek(selectedPlayerCard);
                    players[i].AskForACard(players, i, stock, card.Value);
                }
                else
                {
                    players[i].AskForACard(players, i, stock);
                }
                if (PullOutBooks(players[i]))
                {
                    for (int j = 0; j < 5; j++)
                        if(stock.Count > 0) 
                            players[i].TakeCard(stock.Deal());
                }
            }
            players[0].SortHand();
            if (stock.Count == 0)
            {
                textBoxOnForm.Text += "The stock is out of cards. Game Over!" + Environment.NewLine;
                return true;
            }
            return false;
        }

        public bool PullOutBooks(Player player)
        {
            /* Pull out a player's books.  Return true if the player ran out of cards, otherwise
             * return false.  Each book is added to the Books dectionary.  A player runs out of 
             * cards when he's used all of his cards to make book - and he wins the game.
             */
            foreach (Value value in player.PullOutBooks())
                books.Add(value, player);
            if (player.CardCount == 0)
            {
                return true;
            }
            return false;
        }

        public string DescribeBooks()
        {
            /* Return a long string that describes everyone's books by looking at the Books
             * dictionary: "Joe has a book of sixes. (line break) Ed has a book of Aces."
             */
            string description = "";
            foreach (Value value in books.Keys)
            {
                description += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
            }
            return description;
        }

        public string GetWinnerName()
        {
            /* This mehtod is called at the end of the game.  It uses its own dictionary
             * (Dictionary<string, int> winners) to keep track of how many books each player
             * ended up with in the books dictionary.  First it uses a forach loop
             * on books.Keys - foreach(Value value in books.Keys) - to populate
             * its winners dictionary with the number of books each player ended up with.
             * Then it loops through that dictionary to find the largetst number of books
             * any winner has.  And finally it makes on last pass through winners to come
             * up witha list of winders in a string ("Joe and Ed"). If there's one winner,
             * it returns a string like this: "Ed with 3 books".  Otherwise it returns a 
             * stirng like this: "A tie between Joe and Bob with 2 books."
             */
            string winner = "";
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Value value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }
            int mostBooks = 0;
            foreach (string player in winners.Keys)
                if (winners[player] > mostBooks)
                    mostBooks = winners[player];
            bool tie = false;
            string winnerList = "";
            foreach (string player in winners.Keys)
            {
                if (winners[player] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += player;
                }
            }
            if (tie)
                winnerList = "A tie between " + winnerList + " with " + mostBooks + " books";
            else
                winnerList = winnerList + " with " + mostBooks + " books";
            return winnerList;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++) 
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }
    }
}
