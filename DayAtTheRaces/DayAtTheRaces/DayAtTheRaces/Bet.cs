using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public Greyhound Dog;
        public Guy Bettor;

        public string GetBetDescription()
        {
            return Bettor.Name + " bets " + Amount + " on greyhound #" + Dog.Id;
        }

        public void PayOut(int winner)
        {
            if (Dog.Id == winner) //dog is the winner 
            {
                Bettor.Collect(Amount);
            }
            else //dog isn't the winner
            {
                Bettor.Collect(Amount * -1);
            }
        }
    }
}
