using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class RoomWithHidingPlace : Room, IHidingPlace
    {
        private string hidingPlace;

        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration) 
        {
            this.hidingPlace = hidingPlace;
        }

        public string HidingPlace
        {
            get { return hidingPlace; }
        }
    }
}
