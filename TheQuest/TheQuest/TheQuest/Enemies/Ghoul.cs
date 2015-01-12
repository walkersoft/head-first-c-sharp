using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Ghoul : Enemy
    {

        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {

        }

        public override void Move(Random random)
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if(HitPoints > 0)
            {
                if (random.Next(3) < 2)
                {
                    this.location = Move(direction, game.Boundaries);
                }
            }

            if (NearPlayer() && !Dead)
            {
                game.HitPlayer(5, random);
            }
        }
    }
}
