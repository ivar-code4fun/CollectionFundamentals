using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> presidents = new ObservableCollection<string> { "Jimmy Carter", "Ronald Reagan","George HW Bush" };

            presidents.CollectionChanged += presidents_CollectionChanged;
            presidents.Add("Bill Clinton");
            presidents.Remove("Jimmy Carter");

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }

        private static void presidents_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                Console.WriteLine("Added item : " + e.NewItems[0]);
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                Console.WriteLine("Removed item : " + e.OldItems[0]);
        }
    }
}
