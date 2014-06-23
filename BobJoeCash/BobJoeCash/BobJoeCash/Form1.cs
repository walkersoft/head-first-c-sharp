using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobJoeCash
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { name = "Joe", cash = 50 };

            bob = new Guy() { name = "Bob", cash = 100 };

            this.UpdateForm();
        }

        public void UpdateForm()
        {
            bobCash.Text = bob.name + " has $" + bob.cash;
            joeCash.Text = joe.name + " has $" + joe.cash;
            bankCash.Text = "Bank has $" + bank;
        }

        private void giveCash_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                this.UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank needs at least $10 to function.");
            }
        }

        private void receiveCash_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            this.UpdateForm();
        }

        private void joeToBob_Click(object sender, EventArgs e)
        {
            joe.GiveCash(bob.ReceiveCash(10));
            this.UpdateForm();
        }

        private void bobToJoe_Click(object sender, EventArgs e)
        {
            bob.GiveCash(joe.ReceiveCash(5));
            this.UpdateForm();
        }

    }
}
