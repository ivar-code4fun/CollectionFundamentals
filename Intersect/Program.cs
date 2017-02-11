using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string> { "New York", "Manchester", "Sheffield", "Paris" };

            string[] citiesInUk = { "Sheffield", "Ripon", "Truro", "Manchester" };

            //hashset intersect
            //bigCities.IntersectWith(citiesInUk);
            //foreach (var city in bigCities)
            //{
            //    Console.WriteLine(city);
            //}

            //using linq
            //var newCities = bigCities.Intersect(citiesInUk);

            //foreach (var city in newCities)
            //{
            //    Console.WriteLine(city);
            //}

            //bigCities.UnionWith(citiesInUk);
            //foreach (var city in bigCities)
            //{
            //    Console.WriteLine(city);
            //}

            //bigCities.SymmetricExceptWith(citiesInUk);
            bigCities.ExceptWith(citiesInUk);
            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
