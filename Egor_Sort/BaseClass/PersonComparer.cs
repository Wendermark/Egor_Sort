using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Sort.BaseClass
{
    class PersonComparer : IComparer<Person>
    {
        private readonly bool _isIncreasing;

        public PersonComparer(bool isIncreasing = true) => _isIncreasing = isIncreasing;

        public int Compare(Person x, Person y)
        {
            return (_isIncreasing ? 1 : -1) * (x.FirstName.CompareTo(y.FirstName));
        }
    }
}
