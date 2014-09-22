using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        protected int radius;
        protected int damage;
        public bool PickedUp { get; private set; }
        public Weapon(Game game, Point location) 
            : base(game, location) 
        {
            PickedUp = false;
        }

        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random) 
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++) 
            {
                foreach (Enemy enemy in game.Enemies) 
                {
                    if (!enemy.Dead && Nearby(enemy.Location, target, distance)) 
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                //target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        public bool Nearby(Point enemy, Point player, int distance)
        {
            if (Math.Abs((player.X + spriteCenter) - (enemy.X + spriteCenter)) < distance
                && Math.Abs((player.Y + spriteCenter) - (enemy.Y + spriteCenter)) < distance)
            {
                return true;
            }
            return false;
        }

        public Direction ClockWiseDirection(Direction direction)
        {
            Direction nextDirection = direction;
            switch (direction)
            {
                case Direction.Up:
                    nextDirection = Direction.Right;
                    break;
                case Direction.Right:
                    nextDirection = Direction.Down;
                    break;
                case Direction.Down:
                    nextDirection = Direction.Left;
                    break;
                case Direction.Left:
                    nextDirection = Direction.Up;
                    break;
            }
            return nextDirection;
        }

        public Direction CounterClockWiseDirection(Direction direction)
        {
            Direction nextDirection = direction;
            switch (direction)
            {
                case Direction.Up:
                    nextDirection = Direction.Left;
                    break;
                case Direction.Right:
                    nextDirection = Direction.Up;
                    break;
                case Direction.Down:
                    nextDirection = Direction.Right;
                    break;
                case Direction.Left:
                    nextDirection = Direction.Down;
                    break;
            }
            return nextDirection;
        }
    }
}
