using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Sort.BaseClass
{
    class Person
    {
        public Person(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return string.Format($"{FirstName}, {LastName}");
        }

    }
}
