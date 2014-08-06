using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadedCards
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards form = new DeckOfCards();
            Application.EnableVisualStyles();
            Application.Run(form);
        }
    }
}
