using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        private string doorDesc;
        private Location location;
        public OutsideWithDoor(string name, string door, bool hot)
            : base(name, hot)
        {
            doorDesc = door;
        }

        public string DoorDescription
        {
            get { return doorDesc; }
        }

        public Location DoorLocation
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public override string Description
        {
            get
            {
                return base.Description + "The door is " + DoorDescription + ". That door leads to the " + DoorLocation.Name + ".";
            }
        }
    }
}
