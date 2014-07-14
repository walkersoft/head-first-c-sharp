using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsSafe
{
    class JewelThief : Locksmith
    {
        private Jewel stolenJewels = null;

        public override void ReturnContents(Jewel safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Hahaha, I'm stealing your Jewels! " + stolenJewels.Sparkle());
        }
    }
}
