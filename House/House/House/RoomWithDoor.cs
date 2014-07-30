using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        private string doorDesc;
        private Location location;

        public RoomWithDoor(string name, string decoration, string doorDesc)
            : base(name, decoration)
        {
            this.doorDesc = doorDesc;
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
    }
}
