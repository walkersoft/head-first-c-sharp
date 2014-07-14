using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorInheritance
{
    class Subclass : Superclass
    {
        public Subclass(string needThisAlso) : base(needThisAlso)
        {
            Console.WriteLine("Did the superclass box show?");
            Console.ReadKey();
        }
    }
}
