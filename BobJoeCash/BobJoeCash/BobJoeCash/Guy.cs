using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobJoeCash
{
    class Guy
    {
        public string name;
        public int cash;

        public int GiveCash(int amount) 
        {
            if (amount <= cash && cash > 0)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(name + " says: I don't have enough money to give you " + amount + ".");
            }
            return 0;
        }

        public int ReceiveCash(int amount) 
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(name + " says: An amount of " + amount + "isn't an amount I'll take.");
            }
            return 0;
        }
    }
}
