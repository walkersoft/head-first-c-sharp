using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        {

        }
        public override void Move(Random random)
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if (HitPoints > 1)
            {
                if (random.Next(3) == 1)
                {
                    this.location = Move(direction, game.Boundaries);
                }
            }

            if (NearPlayer() && !Dead)
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
