﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    interface IHasExteriorDoor
    {
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }

    }
}
