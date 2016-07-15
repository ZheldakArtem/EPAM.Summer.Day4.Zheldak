using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BoxClasses
{
    public class SortByMinAscend : IComparer<int>
    {
        public int Comparer(int[] lhs, int[] rhs)
        {
            if (lhs.Min() > rhs.Min())
                return 1;
            if (lhs.Min() < rhs.Min())
                return -1;
            return 0;
        }

        /// <summary>
        /// Sorting rows of the matrix in ascending order of min elements rows of the matrix
        /// </summary>
        /// <param name="someJagged"></param>
        public void Sort(int[][] someJagged)
        {
            for (int i = 0; i < someJagged.Length; i++)
            {
                for (int j = 0; j < someJagged.Length - 1 - i; j++)
                {
                    if (someJagged[j].Min() > someJagged[j + 1].Min())
                    {
                        var temp = someJagged[j];
                        someJagged[j] = someJagged[j + 1];
                        someJagged[j + 1] = temp;
                    }
                }
            }
        }
    }
}
