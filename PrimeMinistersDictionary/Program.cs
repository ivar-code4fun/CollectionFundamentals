using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinistersDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string,PrimeMinister>
                                { 
                                    {"JC", new PrimeMinister("James Callaghan", 1976)},
                                    {"MT", new PrimeMinister("Margaret Thacher", 1979)},
                                    {"TB", new PrimeMinister("Tony Blair",1997)}
                                };

            //PrimeMinister pm = primeMinisters["JC"];
            //Console.WriteLine("Value is : " + pm.ToString());
            primeMinisters["JC"] = new PrimeMinister("Jim Callahan", 1976);
            primeMinisters.Remove("JC");
            primeMinisters["JM"] = new PrimeMinister("John Major", 1990);
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));

            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }

            //PrimeMinister pm;
            //bool found = primeMinisters.TryGetValue("JC", out pm);
            //if (found)
            //    Console.WriteLine("value is :" + pm.ToString());
            //else
            //    Console.WriteLine("value is not found in dictionary!");

            //foreach (var pm in primeMinisters.Keys)
            //{
            //    Console.WriteLine(pm);
            //}

        }
    }
}
