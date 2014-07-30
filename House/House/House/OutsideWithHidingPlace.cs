using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        private string hidingPlace;

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace)
            : base(name, hot)
        {
            this.hidingPlace = hidingPlace;
        }

        public string HidingPlace
        {
            get { return hidingPlace; }
        }
    }
}
