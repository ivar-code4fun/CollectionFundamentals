using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            ICollection<string> collection = (ICollection<string>)daysOfWeek;
            Console.WriteLine("Count = " + collection.Count);
            Console.WriteLine("Length = " + daysOfWeek.Length);

            (collection as string[])[5] = "Slaveday";
            if (!collection.IsReadOnly)
                collection.Add("Slaveday");
            else
                Console.WriteLine(collection.GetType() + " : Read Only Collection!");

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
