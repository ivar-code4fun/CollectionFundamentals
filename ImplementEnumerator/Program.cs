using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ImplementEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek daysOfWeek = new DaysOfWeek();

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }

    class DaysOfWeek :IEnumerable<string>
    {

        public IEnumerator<string> GetEnumerator()
        {
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
