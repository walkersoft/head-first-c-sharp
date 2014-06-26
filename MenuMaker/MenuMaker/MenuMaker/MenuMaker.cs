using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    class MenuMaker
    {

        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Chicken", "Bologna", "Pepperoni" };
        string[] Condiments = { "Mayo", "Ketchup", "Mustard", "Pickles", "Onions", "Horse radish" };
        string[] Breads = { "White", "Wheat", "Rye", "Italian", "Honey Oats" };
        public Random Randomizer;

        public string MakeSandwich()
        {
            string meat = Meats[Randomizer.Next(Meats.Length)];
            string condiment = Condiments[Randomizer.Next(Condiments.Length)];
            string bread = Breads[Randomizer.Next(Breads.Length)];
            return "Made a " + meat + " sandwich with " + condiment + " on " + bread + " bread.";
        }
    }
}
