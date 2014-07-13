using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty__fixed_
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public string CakeWriting { get; set; }

        public BirthdayParty(int people, bool fancy, string writing)
        {
            NumberOfPeople = people;
            FancyDecorations = fancy;
            CakeWriting = writing;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal cost = 0.0M;
            if (FancyDecorations)
                cost = (NumberOfPeople * 15.00M) + 50.00M;
            else
                cost = (NumberOfPeople * 7.50M) + 30.00M;
            return cost;
        }

        public decimal TotalCost
        {
            get
            {
                decimal cost = CalculateCostOfDecorations();
                cost += NumberOfPeople * CostOfFoodPerPerson;
                decimal cake = 0.00M;
                if (CakeSize() == 8)
                {
                    cake = 40.00M + ActualLength * .25M;
                }
                else
                {
                    cake = 75.00M + ActualLength * .25M;
                }
                cost += cake;
                return cost;
            }
        }
    }
}
