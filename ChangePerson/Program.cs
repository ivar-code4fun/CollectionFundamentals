using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                                            new Person { Name = "Peter", Age =35 },
                                            new Person { Name = "Ben", Age = 50 }
                                            };

            foreach (Person person in people)
            {
                person.Age = 20;
            }

            foreach (Person person in people)
            {
                Console.WriteLine("Name : {0} Age : {1}",person.Name,person.Age);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} age = {1}", Name, Age); 
        }
        
    }
}
