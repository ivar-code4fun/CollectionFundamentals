using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] squares = { 1, 4, 9, 16 };
            int[] copy = new int[8];

            squares.CopyTo(copy, 2);
            Array.Copy(squares, copy, 3);

            //int[] copy = new int[4];
            //copy = squares.ToArray();

            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Format("squares == copy {0}", squares.Equals(copy)));
        }
    }
}
