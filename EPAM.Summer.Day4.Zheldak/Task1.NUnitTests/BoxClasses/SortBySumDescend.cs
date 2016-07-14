using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SortBySumDescend : ISortJagged
    {
        /// <summary>
        /// Sorting rows of the matrix in descending order of sums elements rows of the matrix`
        /// </summary>
        /// <param name="someJagged">Not sorted array</param>
        public void Sort(int[][] someJagged)
        {
            for (int i = 0; i < someJagged.Length; i++)
            {
                for (int j = 0; j < someJagged.Length - 1 - i; j++)
                {
                    if (someJagged[j].Sum() < someJagged[j + 1].Sum())
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
