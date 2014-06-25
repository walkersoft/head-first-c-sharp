using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage
{
    public partial class Form1 : Form
    {
        decimal rate = 0.39M;
        int start;
        int end;
        decimal reimburse;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcMileage_Click(object sender, EventArgs e)
        {
            start = (int) startMileage.Value;
            end = (int) endMileage.Value;

            if (end < start)
            {
                this.BadMilesEntered();
            }
            else
            {
                reimburse = (end - start) * rate;
                amountOwed.Text = "$" + reimburse.ToString();
            }
        }

        private void showMiles_Click(object sender, EventArgs e)
        {
            start = (int)startMileage.Value;
            end = (int)endMileage.Value;

            if (end < start)
            {
                this.BadMilesEntered();
            }
            else
            {
                int miles = end - start;
                MessageBox.Show((end - start) + " miles traveled", "Miles Traveled");
            }
        }

        private void BadMilesEntered()
        {
            //Can't calculate mileage
            MessageBox.Show("End mileage cannot be lower than starting mileage.", "Cannot Calculate Mileage");
        }
    }
}
