using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", Ears = 40 };
            lucinda = new Elephant() { Name = "Lucinda", Ears = 33 };
        }

        private void lucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void lloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            Elephant swapper;
            swapper = lucinda;
            lucinda = lloyd;
            lloyd = swapper;
            MessageBox.Show("Lucinda and Lloyd have changed identities.", "Elephants Swapped");
        }
    }
}
