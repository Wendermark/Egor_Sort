using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egor_Sort.BaseClass;

namespace Egor_Sort
{
    class Program
    {
        static void Main()
        {
            var autos = new Auto[] { new Auto("Toyota Corolla", 180, 300000, 5, 4), new Auto("VAZ 2114i", 160, 220000, 0, 3), new Auto("Daewoo Nexia", 140, 260000, 5, 2), new Auto("Honda Torneo", 220, 400000, 7, 1) };

            Array.Sort(autos, new AutoComparer(false));

            foreach (Auto auto in autos)
                Console.WriteLine(auto);
            
            Console.WriteLine();

            var persons = new List<Person>
            {
                new Person("Damon", "Hill"),
                new Person("Niki", "Lauda"),
                new Person("Ayrton", "Senna"),
                new Person("Graham", "Hill"),
                new Person("Damon", "Crauch"),
            };

            persons.Sort(new PersonComparer(true));

            foreach (Person person in persons)
                Console.WriteLine(person);

            Console.ReadKey();
        }
    }

}
