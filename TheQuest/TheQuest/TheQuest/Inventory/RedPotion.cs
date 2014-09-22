using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location)
            : base(game, location)
        {

        }
        private string name = "Red Potion";
        private bool used = false;
        public override string Name
        {
            get { return this.name; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            this.used = true;
        }

        public bool Used
        {
            get { return this.used; }
        }
    }
}
