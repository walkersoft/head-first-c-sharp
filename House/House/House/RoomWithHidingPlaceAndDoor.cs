using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class RoomWithHidingPlaceAndDoor : Room, IHidingPlace, IHasExteriorDoor
    {
        private string hidingPlace;
        private string doorDesc;
        private Location location;

        public RoomWithHidingPlaceAndDoor(string name, string decoration, string doorDesc, string hidingPlace)
            : base(name, decoration)
        {
            this.hidingPlace = hidingPlace;
            this.doorDesc = doorDesc;
        }

        public string HidingPlace
        {
            get { return this.hidingPlace; }
        }

        public string DoorDescription
        {
            get { return this.doorDesc; }
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
