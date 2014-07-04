using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int Id;
        public int StartPosition;
        public int TrackLength;
        public PictureBox MyPicBox;
        public int Location;
        public Random Randomizer;

        public void GetReady()
        {
            MyPicBox.Left = Location = StartPosition;
        }

        public void Run()
        {
            int chance = Randomizer.Next(1, 1000);
            if (chance > 900)
            {
                Location += Randomizer.Next(3, 10);
            }
            else
            {
                Location += Randomizer.Next(1, 5);
            }
            MyPicBox.Left = Location;
        }

    }
}
