﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberFlapJacks
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
                meal.Push(food);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine(Name + "'s eating flapjacks");
            while (FlapjackCount > 0)
                Console.WriteLine(Name + " ate a " + meal.Pop().ToString().ToLower() + " flapjack");
        }
    }
}
