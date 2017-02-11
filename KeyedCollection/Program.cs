using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //var primeMinisters = new Dictionary<int, PrimeMinister>
            var primeMinisters = new PrimeMinistersByYearDictionary() 
                                { 
                                    {new PrimeMinister("James Callaghan", 1976)},
                                    {new PrimeMinister("Margaret Thacher", 1979)},
                                    {new PrimeMinister("Tony Blair",1997)}
                                };
            primeMinisters.Add(new PrimeMinister("John Major", 1990));

            var list = (IList<PrimeMinister>)primeMinisters;
            Console.WriteLine("First prime minister in the list is {0}",list[0]);

            Console.WriteLine("Tony is {0}",primeMinisters[1997]);
            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }

        }
    }

    class PrimeMinistersByYearDictionary : KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item)
        {
            return item.YearElected;
        }
    }
}
