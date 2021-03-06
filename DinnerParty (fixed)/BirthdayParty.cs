﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty__fixed_
{
    class BirthdayParty : Party
    {

        public string CakeWriting { get; set; }

        public BirthdayParty(int people, bool fancy, string writing) : base(people, fancy)
        {
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

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cake = 0.00M;
                if (CakeSize() == 8)
                {
                    cake = 40.00M + ActualLength * .25M;
                }
                else
                {
                    cake = 75.00M + ActualLength * .25M;
                }
                totalCost += cake;
                return totalCost;
            }
        }
    }
}
