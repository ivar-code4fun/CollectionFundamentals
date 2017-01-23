using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>(12) { "Jimmy Carter", "Ronald Reagan", "George HW Bush", "Bill Clinton", "George W Bush" };
            presidents.Add("Barack Obama");
            //presidents.Add("Donald Trump");
            //Console.WriteLine("Count : " + presidents.Count);
            //Console.WriteLine("Capacity : " + presidents.Capacity);

            //presidents.Add("Michelle Obama");
            //presidents.Add("Stephen Spielberg");

            //presidents.RemoveAt(6);
            //Console.WriteLine("Count : " + presidents.Count);
            //Console.WriteLine("Capacity : " + presidents.Capacity);

            string firstElem = presidents[0];
            Console.WriteLine("First President : " + firstElem);

            var copy = presidents.AsReadOnly();
            BadCode(copy);

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }

        private static void BadCode(IList<string> presidents)
        {
            presidents.RemoveAt(2);
        }
    }
}
