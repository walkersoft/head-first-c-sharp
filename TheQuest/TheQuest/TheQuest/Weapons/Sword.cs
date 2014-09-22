using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest.Weapons
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        {
            radius = 10;
            damage = 3;
        }
        public override string Name
        {
            get { return "Sword"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, radius, damage, random))
            {
                if (!DamageEnemy(ClockWiseDirection(direction), radius, damage, random))
                {
                    DamageEnemy(CounterClockWiseDirection(direction), radius, damage, random);
                }
            }
        }
    }
}
