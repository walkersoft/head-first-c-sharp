using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

            label1.Text = menu.MakeSandwich();
            label2.Text = menu.MakeSandwich();
            label3.Text = menu.MakeSandwich();
            label4.Text = menu.MakeSandwich();
            label5.Text = menu.MakeSandwich();
            label6.Text = menu.MakeSandwich();
        }
    }
}
