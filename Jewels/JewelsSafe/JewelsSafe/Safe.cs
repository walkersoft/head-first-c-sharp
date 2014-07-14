using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsSafe
{
    class Safe
    {
        private Jewel contents = new Jewel();
        private string safeCombination = "12345";
        public Jewel Open(string combination)
        {
            if (combination == safeCombination)
                return contents;
            else
                return null;
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
