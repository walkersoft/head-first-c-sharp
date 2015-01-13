using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WPFSloppyJoe
{
    class MenuMaker
    {
        //Sandwich goodies
        private List<String> meats = new List<String>()
        {
            "Roast beef", "Turkey", "Salami", "Honey ham", "Pastrami", "Bologna"
        };

        private List<String> breads = new List<String>()
        {
            "white", "wheat", "rye", "honey oats", "italian", "flatbread", "sour dough"
        };

        private List<String> condiments = new List<String>()
        {
            "onion", "mayo", "mustard", "pickle", "olives", "lettuce", "tomato", "cheese"
        };

        private Random random = new Random();

        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; set; }
        public int NumberOfItems { get; set; }

        public MenuMaker()
        {
            this.Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }

        public MenuItem CreateMenuItem()
        {
            return new MenuItem(meats[random.Next(meats.Count)], condiments[random.Next(condiments.Count)], breads[random.Next(breads.Count)]);
        }
    }
}
