using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
            //listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys) random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over!");
                timer1.Stop();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If a key was pressed that was in the list box, remove it and up the difficulty.
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyBar.Value = 800 - timer1.Interval;
                //Update the stats class since the player press a correct key
                stats.Update(true);
            }
            else
            {
                //Player pressed the wrong key
                stats.Update(false);
            }

            //Update Stats bar
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
