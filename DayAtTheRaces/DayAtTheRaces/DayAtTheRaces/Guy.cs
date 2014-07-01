using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DayAtTheRaces
{
    public class Guy
    {
        public int Cash;
        public Bet Bet;
        public string Name;
        public RadioButton MyRadio;
        public Label MyLabel;
        public Label MyCash;

        public void Update() 
        {
            if (Bet == null)
            {
                MyLabel.Text = Name + " has not placed a bet!";
            }
            else
            {
                MyLabel.Text = Bet.GetBetDescription();
            }
            MyCash.Text = "Cash: " + Cash;
        }

        public void PlaceBet(int amount, Greyhound dog) 
        {
            if (Cash >= amount)
            {
                Bet = new Bet()
                {
                    Amount = amount,
                    Dog = dog,
                    Bettor = this
                };
            }
            else
            {
                MessageBox.Show(Name + " doesn't have enough to bet that amount.", "Can't place bet!");
            }
        }

        public void ClearBet() 
        {
            Bet = null;
        }

        public void Collect(int amount)
        {
            if (amount > 0)
            {
                MyLabel.Text = Name + " earned " + amount;
            } 
            else 
            {
                MyLabel.Text = Name + " lost " + (amount * -1);
            }
            Cash += amount;
        }
    }
}
