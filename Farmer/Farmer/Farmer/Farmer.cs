using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {
        private int numberOfCows;
        private int feedMultiplier = 0;
        private int bagsOfFeed = 0;

        public Farmer (int numberOfCows, int feedMultiplier) 
        {
            NumberOfCows = numberOfCows;
            this.feedMultiplier = feedMultiplier;
        }

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                bagsOfFeed = numberOfCows * feedMultiplier;
            }
        }

        public int BagsOfFeed
        {
            get
            {
                return bagsOfFeed;
            }
        }
    }
}
