using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        public Greyhound[] greyhounds = new Greyhound[4];
        public Guy[] guys = new Guy[3];
        public Greyhound winner;
        public PictureBox Track;
        public Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            int StartPos = 20;
            Track = pictureBox1;
            
            guys[0] = new Guy()
            {
                Name = "Joe",
                Cash = 45,
                MyRadio = joeButton,
                MyLabel = joeBet,
                MyCash = joeCash
            };

            guys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadio = bobButton,
                MyLabel = bobBet,
                MyCash = bobCash
            };

            guys[2] = new Guy()
            {
                Name = "Al",
                Cash = 55,
                MyRadio = alButton,
                MyLabel = alBet,
                MyCash = alCash
            };

            greyhounds[0] = new Greyhound()
            {
                Id = 1,
                StartPosition = StartPos,
                MyPicBox = greyhoundBox1,
                Randomizer = randomizer,
                TrackLength = Track.Width
            };

            greyhounds[1] = new Greyhound()
            {
                Id = 2,
                StartPosition = StartPos,
                MyPicBox = greyhoundBox2,
                Randomizer = randomizer,
                TrackLength = Track.Width
            };

            greyhounds[2] = new Greyhound()
            {
                Id = 3,
                StartPosition = StartPos,
                MyPicBox = greyhoundBox3,
                Randomizer = randomizer,
                TrackLength = Track.Width
            };

            greyhounds[3] = new Greyhound()
            {
                Id = 4,
                StartPosition = StartPos,
                MyPicBox = greyhoundBox4,
                Randomizer = randomizer,
                TrackLength = Track.Width
            };

            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].Update();
            }
        }

        private void placeBet_Click(object sender, EventArgs e)
        {
            int bet = (int)betAmount.Value;
            int dog = (int)betGreyhound.Value;
            if (joeButton.Checked)
            {
                guys[0].PlaceBet(bet, greyhounds[dog - 1]);
            }
            if (bobButton.Checked)
            {
                guys[1].PlaceBet(bet, greyhounds[dog - 1]);
            }
            if (alButton.Checked)
            {
                guys[2].PlaceBet(bet, greyhounds[dog - 1]);
            }
            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].Update();
            }
        }

        private void race_Click(object sender, EventArgs e)
        {
            RaceStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int farthest = 0;
            Greyhound winning;
            for (int i = 0; i < greyhounds.Length; i++)
            {
                greyhounds[i].Run();
                if (greyhounds[i].Location > farthest)
                {
                    farthest = greyhounds[i].Location;
                    winning = greyhounds[i];
                    raceStatus.Text = "Greyhound #" + winning.Id + " is in the lead!";
                }
                if (greyhounds[i].Location >= greyhounds[i].TrackLength - greyhounds[i].MyPicBox.Width)
                {
                    winner = greyhounds[i];
                    break;
                }
            }
            if (winner != null)
            {
                RaceOver();
            }
        }

        private void RaceStart()
        {
            winner = null;
            for (int i = 0; i < greyhounds.Length; i++)
            {
                greyhounds[i].GetReady();
            }
            for (int i = 3; i > 0; i--) 
            {
                raceStatus.Text = "The race will begin in " + i;
                Application.DoEvents();
                Thread.Sleep(1000);
            }
            timer1.Enabled = true;
            race.Enabled = false;
            placeBet.Enabled = false;
        }

        private void RaceOver()
        {
            timer1.Enabled = false;
            for (int i = 0; i < guys.Length; i++)
            {
                if (guys[i].Bet != null)
                {
                    guys[i].Bet.PayOut(winner.Id);
                    guys[i].Bet = null;
                }
            }
            raceStatus.Text = "The winner is greyhound #" + winner.Id + ". Place your bets for the next race.";
            Application.DoEvents();
            Thread.Sleep(5000); 
            for (int i = 0; i < guys.Length; i++)
            {
                if (guys[i].Bet == null)
                {
                    guys[i].Update();
                }
            }
            race.Enabled = true;
            placeBet.Enabled = true;
        }

        private void joeButton_CheckedChanged(object sender, EventArgs e)
        {
            bettor.Text = "Joe bets";
        }

        private void bobButton_CheckedChanged(object sender, EventArgs e)
        {
            bettor.Text = "Bob bets";
        }

        private void alButton_CheckedChanged(object sender, EventArgs e)
        {
            bettor.Text = "Al Bets";
        }

    }
}
