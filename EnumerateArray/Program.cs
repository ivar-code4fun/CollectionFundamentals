using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                sb.Append(daysOfWeek[i]);

                if (i < daysOfWeek.Length - 2)
                {
                    sb.Append(", ");
                }
                else if (i == daysOfWeek.Length - 2)
                {
                    sb.Append(" and ");
                }
            }
            Console.WriteLine(sb.ToString());

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
