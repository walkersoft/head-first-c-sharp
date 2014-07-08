using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    public class Party
    {
        private const int FoodCostPerPerson = 25;
        private int NumberOfPeople;
        public decimal DrinkCostPerPeson;
        public decimal DecorationsCost;
        public decimal SubTotal;

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            SetDecorationsCost(fancy);
        }

        public void SetDrinkCost(bool healthy)
        {
            if (healthy)
            {
                //Healthy option (10 people = $50)
                DrinkCostPerPeson = 5.00M;
            }
            else
            {
                //Alcoholic option (10 people = $200)
                DrinkCostPerPeson = 20.00M;
            }
        }

        public void SetDecorationsCost(bool fancy) 
        {
            if (fancy)
            {
                //Fancy decorations (10 people = $150 + $50 fee = $200)
                DecorationsCost = (NumberOfPeople * 15.00M) + 50;
            }
            else
            {
                //Regular decorations (10 people = $75 + $30 fee = 105)
                DecorationsCost = (NumberOfPeople * 7.50M) + 30;
            }
        }

        public decimal GetSubTotal(bool healthy) 
        {
            SubTotal = (FoodCostPerPerson + DrinkCostPerPeson) * NumberOfPeople;
            SubTotal += DecorationsCost;
            if (healthy)
            {
                SubTotal = SubTotal * 0.95M;
            }
            return SubTotal;
        }

    }
}
