using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStingPatrol
{
    class Bee : IStingPatrol
    {
        public int AlertLevel
        {
            get
            {
                return 5;
            }
        }

        public int StingerSize { get; set; }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int size)
        {
            return size + 1;
        }

    }
}
