using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest.Weapons
{
    class Bow : Weapon
    {

        public Bow(Game game, Point location)
            : base(game, location)
        {
            radius = 150;
            damage = 1;
        }
        public override string Name
        {
            get { return "Bow"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, radius, damage, random);
        }
    }
}
