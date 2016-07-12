using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BoxClasses
{
  public  class SortByMaxDescend : ISortJagged
    {
        /// <summary>
        /// Sorting rows of the matrix in descending order of max elements rows of the matrix
        /// </summary>
        /// <param name="someJagged"></param>
        public void Sort(int[][] someJagged)
        {
            for (int i = 0; i < someJagged.Length; i++)
            {
                for (int j = 0; j < someJagged.Length - 1 - i; j++)
                {
                    if (someJagged[j].Max() < someJagged[j + 1].Max())
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
