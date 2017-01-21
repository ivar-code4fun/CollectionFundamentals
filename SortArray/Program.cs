using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Today", "Thursday","Loooooonnngday", "Friday", "Saturday", "Sunday" };

            //Array.Sort(daysOfWeek);
            var comparer = new StringComparer();
            Array.Sort(daysOfWeek, comparer);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }

    class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
