using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedList<string, PrimeMinister>
                                { 
                                    {"JC", new PrimeMinister("James Callaghan", 1976)},
                                    {"MT", new PrimeMinister("Margaret Thacher", 1979)},
                                    {"TB", new PrimeMinister("Tony Blair",1997)}
                                };

            primeMinisters.Add("JM", new PrimeMinister("John Major", 1990));

            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }

        }
    }
}
