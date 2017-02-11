using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) { "New York", "Manchester", "Sheffield", "Paris" };

            var bigCities = new HashSet<string>(new UncasedStringEqualityComparer()) { "New York", "Manchester", "Sheffield", "Paris" };
            bool addSheffield = bigCities.Add("SHEFFIELD");
            bool addBeijing = bigCities.Add("Beijing");

            Console.WriteLine("Added sheffield : {0}",addSheffield);
            Console.WriteLine("Adding beijing : {0}",addBeijing);

            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class UncasedStringEqualityComparer : IEqualityComparer<string>
    {

        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }

        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }

}
