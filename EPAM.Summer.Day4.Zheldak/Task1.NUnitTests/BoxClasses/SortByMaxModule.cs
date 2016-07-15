using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace Task1.BoxClasses
{
  public  class SortByMaxModule : IComparer<int>
    {
        public int Comparer(int[] lhs, int[] rhs)
        {
            throw new NotImplementedException();
        }

        public void Sort(int[][] someJagged)
        {
            for (int i = 0; i < someJagged.Length; i++)
            {
                for (int j = 0; j < someJagged.Length - 1 - i; j++)
                {
                    if (Abs(someJagged[j].Max()) > Abs(someJagged[j + 1].Max()))
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
