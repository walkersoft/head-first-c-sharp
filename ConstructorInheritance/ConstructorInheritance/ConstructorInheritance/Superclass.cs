using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorInheritance
{
    class Superclass
    {
        public Superclass(string needThis)
        {
            Console.WriteLine("Base class needs this: " + needThis);
        }
    }
}
