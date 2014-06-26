using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public string Name;
        public int Ears;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + Ears + " inches tall.", Name + " says...");
        }
    }
}
