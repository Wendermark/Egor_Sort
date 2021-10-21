using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Sort.BaseClass
{
    class AutoComparer : IComparer<Auto>
    {
        private readonly bool _isIncreasing;

        public AutoComparer(bool isIncreasing = true) => _isIncreasing = isIncreasing;

        public int Compare(Auto x, Auto y)
        {
            return (_isIncreasing ? 1 : -1) * (x.Id > y.Id ? 1 : x.Id < y.Id ? -1 : 0);
        }
    }
}
