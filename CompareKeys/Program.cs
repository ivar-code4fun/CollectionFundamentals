using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            UncasedEqualityStringComparer comparer = new UncasedEqualityStringComparer();

            var primeMinisters = new Dictionary<string, PrimeMinister>(comparer)
            //var primeMinisters = new Dictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
                                 {
                                     {"JC", new PrimeMinister("James Callahan",1974)},
                                     {"MT", new PrimeMinister("Margaret Thacher",1979)},
                                     {"TB", new PrimeMinister("Tony Blair",1997)}
                                 };

            Console.WriteLine(primeMinisters["tb"]);
        }
    }

    class UncasedEqualityStringComparer : IEqualityComparer<string>
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
