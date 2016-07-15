using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BoxClasses
{
    public class SortByMaxDescend : IComparer<int>
    {
        public int Comparer(int[] lhs, int[] rhs)
        {
            if (lhs.Max() < rhs.Max())
                return 1;
            if (lhs.Max() > rhs.Max())
                return -1;
            return 0;
        }
    }
}
