using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    abstract class Location
    {
        public string Name { get; set; }
        public Location[] Exits { get; set; }
        public string Description { get; set; }

    }
}
