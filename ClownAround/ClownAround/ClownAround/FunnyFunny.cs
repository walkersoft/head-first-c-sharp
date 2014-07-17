using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownAround
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave;

        public FunnyFunny(string funnyThing)
        {
            funnyThingIHave = funnyThing;
        }
        
        public string FunnyThingIHave
        {
            get { return "Hi Kids! I Have a" + funnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
