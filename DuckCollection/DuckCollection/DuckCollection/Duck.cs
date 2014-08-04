using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCollection
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck compareTo)
        {
            if (this.Size > compareTo.Size)
                return 1;
            else if (this.Size < compareTo.Size)
                return -1;
            else
                return 0;
        }
    }
}
