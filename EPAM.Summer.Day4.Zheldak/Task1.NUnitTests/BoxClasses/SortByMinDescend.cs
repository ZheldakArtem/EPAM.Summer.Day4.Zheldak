using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BoxClasses
{
    public class SortByMinDescend : IComparer<int>
    {
        public int Comparer(int[] lhs, int[] rhs)
        {
            if (lhs.Min() < rhs.Min())
                return 1;
            if (lhs.Min() > rhs.Min())
                return -1;
            return 0;
        }
    }
}
