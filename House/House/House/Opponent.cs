using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public class Opponent
    {
        public Location myLocation;
        private Random random;

        public Opponent(Location location)
        {
            this.myLocation = location;
            this.random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor nextLocation = myLocation as IHasExteriorDoor;
                int goThroughDoor = random.Next(2);
                if (goThroughDoor == 1)
                    myLocation = nextLocation.DoorLocation;
            }
            int rand = random.Next(myLocation.Exits.Length);
            myLocation = myLocation.Exits[rand];
            IHidingPlace myLocTest = myLocation as IHidingPlace;
            if (myLocTest == null)
            {
                Move(); 
            }
        }

        public bool Check(Location currentLocation)
        {
            if (currentLocation == myLocation)
                return true;
            else
                MessageBox.Show("He's not in the " + currentLocation.Name + ".");
            return false;
        }
    }
}
