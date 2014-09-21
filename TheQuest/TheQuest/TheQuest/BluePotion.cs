using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class BluePotion : Weapon, IPotion
    {
        private string name = "Blue Potion";
        private bool used = false;
        public override string Name
        {
            get { return this.name; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            this.used = true;
        }

        public bool Used
        {
            get { return this.used; }
        }
    }
}
