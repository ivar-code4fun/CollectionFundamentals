using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //int indexOfTuesday = Array.IndexOf(daysOfWeek, "Thursday");
            //Console.WriteLine(indexOfTuesday);

            //int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            //Console.WriteLine(indexOfW);
            //Console.WriteLine(daysOfWeek[indexOfW]);

            string[] allwith6Chars = Array.FindAll(daysOfWeek, x => x.Length == 6);
            foreach (string item in allwith6Chars)
            {
                Console.WriteLine(item);
            }

        }
    }
}
