using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        public Party party;
        public decimal gtotal;
        public Form1()
        {
            InitializeComponent();
            party = new Party();
            party.SetPartyOptions((int)personCount.Value, fancyDecorations.Checked);
            party.SetDrinkCost(healthyOption.Checked);
            CalculatePartyCost();
        }

        public void CalculatePartyCost()
        {
            gtotal = party.GetSubTotal(healthyOption.Checked);
            costLabel.Text = gtotal.ToString("c");
        }

        private void personCount_ValueChanged(object sender, EventArgs e)
        {
            party.SetPartyOptions((int)personCount.Value, fancyDecorations.Checked);
            CalculatePartyCost();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            party.SetDrinkCost(healthyOption.Checked);
            CalculatePartyCost();
        }

        private void fancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            party.SetDecorationsCost(fancyDecorations.Checked);
            CalculatePartyCost();
        }
    }
}
