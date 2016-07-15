using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SortBySumAscend : IComparer<int>
    {
        public int Comparer(int[] lhs, int[] rhs)
        {
            if (lhs.Sum() > rhs.Sum())
                return 1;
            if (lhs.Sum() < rhs.Sum())
                return -1;
            return 0;
        }
    }
}
