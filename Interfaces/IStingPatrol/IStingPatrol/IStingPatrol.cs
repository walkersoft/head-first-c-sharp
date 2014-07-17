﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStingPatrol
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerSize { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
