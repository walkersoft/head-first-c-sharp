using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) 
            : base(game, location, 6) 
        { }

        public override void Move(Random random)
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if (HitPoints > 1)
            {
                if (random.Next(2) == 1)
                {
                    this.location = Move(direction, game.Boundaries);
                }
                else
                {
                    direction = (Direction)random.Next(0, 5);
                    this.location = Move(direction, game.Boundaries);
                }
            }

            if(NearPlayer() && !Dead)
            {
                game.HitPlayer(2, random);
            }
        }

    }
}
