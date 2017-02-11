using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new SortedSet<string>(StringComparer.InvariantCultureIgnoreCase) { "New York", "Manchester", "Sheffield", "Paris" };
            bigCities.Add("SHEFFIELD");
            bigCities.Add("BEIJING");

            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
