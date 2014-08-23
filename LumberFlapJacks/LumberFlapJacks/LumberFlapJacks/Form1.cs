using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberFlapJacks
{
    public partial class Form1 : Form
    {

        private Queue<Lumberjack> breakfastLine;
        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0)
                return;
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            int num = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(num + ". - " + lumberjack.Name);
                num++;
            }
            Lumberjack currentLumberjack = breakfastLine.Peek();
            nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks.";
            Application.DoEvents();
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(name.Text)) 
            {
                MessageBox.Show("You must enter a name for the lumberjack.", "Can't add lumberjack");
                return;
            }
            Lumberjack lumberjack = new Lumberjack(name.Text);
            breakfastLine.Enqueue(lumberjack);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack lumberjack = breakfastLine.Peek();
            lumberjack.EatFlapjacks();
            breakfastLine.Dequeue();
            RedrawList();
        }
    }
}
