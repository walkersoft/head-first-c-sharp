using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty__fixed_
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public Party(int people, bool fancy)
        {
            NumberOfPeople = people;
            FancyDecorations = fancy;
        }

        virtual protected decimal CalculateCostOfDecorations()
        {
            decimal cost = 0.0M;
            if (FancyDecorations)
                cost = (NumberOfPeople * 15.00M) + 50.00M;
            else
                cost = (NumberOfPeople * 7.50M) + 30.00M;
            return cost;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = 0;
                totalCost += CalculateCostOfDecorations();
                totalCost += NumberOfPeople * CostOfFoodPerPerson; 
                if (NumberOfPeople > 12)
                    totalCost += 100M;
                return totalCost;
            }
        }
    }
}
