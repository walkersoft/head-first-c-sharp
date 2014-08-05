using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() 
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 }
            };
            IEnumerable<Bird> upcastDucks = ducks;

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "George" });

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            Console.ReadKey();
        }
    }
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }


    public class Bird
    {
        public string Name { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Flap, flap");
        }

        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly");
        }

        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }



    class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck compareTo)
        {
            if (this.Size > compareTo.Size)
                return 1;
            else if (this.Size < compareTo.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return Size + "-inch " + Kind;
        }
    }
}
