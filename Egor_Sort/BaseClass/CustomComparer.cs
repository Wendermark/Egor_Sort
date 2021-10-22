using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egor_Sort.BaseClass
{
    class CustomComparer<T> : IComparer<T> where T : IComparable<T>
    {
        private readonly bool _isIncreasing;

        public CustomComparer(bool isIncreasing = true) => _isIncreasing = isIncreasing;

        public int Compare(T x, T y)
        {
            dynamic X = x;
            dynamic Y = y;
            return (_isIncreasing ? 1 : -1) * X.CompareTo(Y);
        }
    }
}
