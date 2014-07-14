using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            Locksmith locksmith = new Locksmith();
            locksmith.OpenSafe(safe, owner);
            JewelThief thief = new JewelThief();
            thief.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}
