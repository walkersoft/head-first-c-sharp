using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsSafe
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewel safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;

        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewel safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
