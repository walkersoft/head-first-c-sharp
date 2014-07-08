using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer((int)numericUpDown1.Value, 20);
            farmer.NumberOfCows = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateFeed();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
            calculateFeed();
        }

        private void calculateFeed()
        {
            Console.WriteLine("Takes {0} bags of feed to satiate {1} cows.", farmer.BagsOfFeed, farmer.NumberOfCows);
        }
    }
}
