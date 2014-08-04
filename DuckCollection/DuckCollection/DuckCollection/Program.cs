using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCollection
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

            DuckComparerBySize duckSizeCompare = new DuckComparerBySize();
            DuckComparerByKind duckKindCompare = new DuckComparerByKind();

            PrintDucks(ducks);
            ducks.Sort(duckSizeCompare);
            PrintDucks(ducks);
            ducks.Sort(duckKindCompare);
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            }
            Console.WriteLine("End of Ducks!");
        }
    }
}
