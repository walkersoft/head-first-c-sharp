using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typing_Game
{
    class Stats
    {
        public int Total;
        public int Correct;
        public int Missed;
        public int Accuracy;

        public void Update(bool hit)
        {
            Total++;
            if (hit)
            {
                Correct++;
            }
            else
            {
                Missed++;
            }
            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }
}
