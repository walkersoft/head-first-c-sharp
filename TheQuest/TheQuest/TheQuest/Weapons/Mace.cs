using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest.Weapons
{
    class Mace : Weapon
    {

        public Mace(Game game, Point location)
            : base(game, location)
        {
            radius = 40;
            damage = 6;
        }
        public override string Name
        {
            get { return "Mace"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, radius, damage, random))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (DamageEnemy(ClockWiseDirection(direction), radius, damage, random))
                    {
                        break;
                    }
                }
            }
        }
    }
}
