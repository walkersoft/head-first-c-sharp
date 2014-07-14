using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsSafe
{
    class Owner
    {
        private Jewel returnedContents;
        public void ReceiveContents(Jewel safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + returnedContents.Sparkle());
        }
    }
}
