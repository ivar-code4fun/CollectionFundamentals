﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>()
                                 {
                                     {"JC", new PrimeMinister("James Callahan",1974)},
                                     {"MT", new PrimeMinister("Margaret Thacher",1979)},
                                     {"TB", new PrimeMinister("Tony Blair",1997)}
                                 };

            var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);
            //pmsReadOnly.Add("GB", new PrimeMinister("Gordon Brown", 2007));

            foreach (var pm in pmsReadOnly)
            {
                Console.WriteLine(pm);
            }

        }
    }
}
