using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownAround
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private string funnyThingIHave;
        private int numberOfScaryThings;

        public ScaryScary(string funnyThing, int scaryThings) : base(funnyThing)
        {
            funnyThingIHave = funnyThing;
            numberOfScaryThings = scaryThings;
        }

        public string ScaryThingIHave
        {
            get { return numberOfScaryThings + " spiders!"; }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }

        public string FunnyThingIHave
        {
            get { return funnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine("Hi Kids! I Have a " + funnyThingIHave);
        }
    }
}
