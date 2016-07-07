using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static public class JaggedArrayOperation
    {
        /// <summary>
        /// Sorting rows of the matrix in ascending order of sums elements rows of the matrix`
        /// </summary>
        /// <param name="someJagged">Not sorted array</param>
        /// <returns>Sorted array</returns>
        public static int[][] JaggedSortRowsBySum(int[][] someJagged)
        {
           
            for (int i = 0; i < someJagged.Length; i++)
            {
                for (int j = 0; j < someJagged.Length - 1 - i; j++)
                {
                    if (someJagged[j].Sum() > someJagged[j + 1].Sum())
                    {
                        var temp = someJagged[j];
                        someJagged[j] = someJagged[j + 1];
                        someJagged[j + 1] = temp;
                    }
                }
            }
            return someJagged;
        }

        /// <summary>
        /// Sorting rows of the matrix in ascending order of max elements rows of the matrix
        /// </summary>
        /// <param name="someJagged"></param>
        /// <returns>Sorted array</returns>
        public static int[][] JaggedSortRowsByMax(int[][] someJagged)
        {

            for (int i = 0; i < someJagged.Length; i++)
            {
                for (int j = 0; j < someJagged.Length - 1 - i; j++)
                {
                    if (someJagged[j].Max() > someJagged[j + 1].Max())
                    {
                        var temp = someJagged[j];
                        someJagged[j] = someJagged[j + 1];
                        someJagged[j + 1] = temp;
                    }
                }
            }
            return someJagged;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="someJagged"></param>
        /// <returns>Sorted array</returns>
        public static int[][] JaggedSortRowsByMin(int[][] someJagged)
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
            return someJagged;
        }
    }
}
